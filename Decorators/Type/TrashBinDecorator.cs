using System.Collections.Generic;
using UnityEngine;

namespace CustomSceneryRegistrar.Decorators.Type
{
    class TrashBinDecorator : IDecorator
    {
        public void Decorate(GameObject go, CustomObject customObject)
        {
            go.AddComponent<TrashBin>();
        }
    }
}
