using UnityEngine;

namespace CustomSceneryRegistrar.Decorators.Type
{
    class SeatingDecorator : IDecorator
    {
        public void Decorate(GameObject go, CustomSceneryV1 customScenery)
        {
            go.AddComponent<Seating>();
            go.GetComponent<Seating>().hasBackRest = customScenery.HasBackRest;
        }
    }
}
