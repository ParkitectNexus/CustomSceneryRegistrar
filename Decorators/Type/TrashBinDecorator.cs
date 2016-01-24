using UnityEngine;

namespace CustomSceneryRegistrar.Decorators.Type
{
    class TrashBinDecorator : IDecorator
    {
        public void Decorate(GameObject go, CustomSceneryV1 customScenery)
        {
            go.AddComponent<TrashBin>();
        }
    }
}
