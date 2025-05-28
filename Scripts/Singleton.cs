using System;
using UnityEngine;

namespace BriansEssentials
{
    public class Singleton<T> : MonoBehaviour where T : Singleton<T>
    {
        public static bool HasInstance => PrivateInstance != null;
        private static T PrivateInstance;
        public static T Instance
        {
            get
            {
                if (PrivateInstance == null)
                {
                    PrivateInstance = FindFirstObjectByType<T>();
                }

                return PrivateInstance;
            }
            set
            {
                PrivateInstance = value;
            }
        }

        public virtual void Awake()
        {
            if (PrivateInstance == this) return;

            if (PrivateInstance != null)
            {
                Debug.LogError($"Only one of {typeof(T).Name} can exist at a time!");
                throw new Exception();
            }

            PrivateInstance = (T)this;
        }

        public virtual void OnDestroy()
        {
            PrivateInstance = null;
        }
    }
}