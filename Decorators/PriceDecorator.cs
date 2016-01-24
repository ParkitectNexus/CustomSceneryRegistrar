using UnityEngine;

namespace CustomSceneryRegistrar.Decorators
{
    class PriceDecorator : IDecorator
    {
        public void Decorate(GameObject go, CustomSceneryV1 customScenery)
        {
            go.GetComponent<BuildableObject>().price = customScenery.Price;
        }
    }
}
