using UnityEngine;

namespace CustomSceneryRegistrar.Decorators
{
    class SnapToCenterDecorator : IDecorator
    {
        public void Decorate(GameObject go, CustomSceneryV1 customScenery)
        {
            if (go.GetComponent<Deco>() != null)
            {
                go.GetComponent<Deco>().defaultSnapToGridCenter = customScenery.SnapCenter;
            }
        }
    }
}
