using UnityEngine;

namespace CustomSceneryRegistrar.Decorators
{
    class HeightDecorator : IDecorator
    {
        public void Decorate(GameObject go, CustomSceneryV1 customScenery)
        {
            go.GetComponent<Deco>().heightChangeDelta = customScenery.HeightDelta;
        }
    }
}
