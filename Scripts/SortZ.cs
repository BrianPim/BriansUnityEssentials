using BriansEssentials.Extensions;
using UnityEngine;

namespace BriansEssentials
{
    /// <summary>
    /// Useful for 2D games. Sets location Z value based on Y value.
    /// </summary>
    public class SortZ : MonoBehaviour
    {
        public float yPointOffset = 0.0f;

        private void LateUpdate()
        {
            float y = transform.position.y + yPointOffset;
            float z = y * 0.001f;
            transform.SetZ(z);
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.green;
            Gizmos.DrawSphere(transform.position + Vector3.up * yPointOffset, 0.05f);
        }
    }
}