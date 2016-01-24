using UnityEngine;

namespace CustomSceneryRegistrar.Decorators
{
    class NameDecorator : IDecorator
    {
        public void Decorate(GameObject go, CustomSceneryV1 customScenery)
        {
            go.GetComponent<BuildableObject>().setDisplayName(customScenery.Name);
            go.name = customScenery.Name;
        }
    }
}
