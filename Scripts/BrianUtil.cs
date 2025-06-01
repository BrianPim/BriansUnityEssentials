using System.Collections.Generic;
using UnityEngine;

namespace BriansEssentials
{
    public static class BrianUtil
    {
        public static bool CheckForRaycastInterruption(string targetLayer, List<string> interruptLayers, Vector3 startPos, Vector3 endPos, float range = 10000)
        {
            var hits = Physics2D.RaycastAll(startPos, (endPos - startPos).normalized, range);

            foreach (var hit in hits)
            {
                if (interruptLayers.Contains(LayerMask.LayerToName(hit.collider.gameObject.layer)))
                {
                    return true;
                }

                //If we find the layer we're looking for we don't need to keep looping.
                if (hit.collider.gameObject.layer == LayerMask.NameToLayer(targetLayer))
                {
                    return false;
                }
            }

            return false;
        }
    }
}
