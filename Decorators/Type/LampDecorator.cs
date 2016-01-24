using System.Collections.Generic;
using UnityEngine;

namespace CustomSceneryRegistrar.Decorators.Type
{
    class LampDecorator : IDecorator
    {
        public void Decorate(GameObject go, CustomSceneryV1 customScenery)
        {
            go.AddComponent<PathAttachment>();
        }
    }
}
