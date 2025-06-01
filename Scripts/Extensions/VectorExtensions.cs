using UnityEngine;

namespace BrianEssentials.Extensions
{
    public static class VectorExtensions
    {
        public static bool IsPointInsideCamera(this Vector3 vector3, Camera cam)
        {
            Vector3 view = cam.WorldToViewportPoint(vector3);

            return view.z > 0 && view.x >= 0 && view.x <= 1 && view.y >= 0 && view.y <= 1;
        }

        public static bool IsPointInsideCamera(this Vector2 vector2, Camera cam)
        {
            Vector3 view = cam.WorldToViewportPoint(vector2);

            return view.z > 0 && view.x >= 0 && view.x <= 1 && view.y >= 0 && view.y <= 1;
        }
    }
}
