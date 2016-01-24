using System.Collections.Generic;
using UnityEngine;

namespace CustomSceneryRegistrar.Decorators.Type
{
    class LampDecorator : IDecorator
    {
        public void Decorate(GameObject go, CustomObject customObject)
        {
            go.AddComponent<PathAttachment>();
        }
    }
}
