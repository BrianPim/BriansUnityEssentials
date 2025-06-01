using UnityEngine;

namespace BriansEssentials.Extensions
{
    public static class TransformExtensions
    {
        public static void SetZ(this Transform transform, float z)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, z);
        }
    }
}
