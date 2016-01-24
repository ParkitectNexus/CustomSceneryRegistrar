using System.Collections.Generic;
using UnityEngine;

namespace CustomSceneryRegistrar.Decorators
{
    interface IDecorator
    {
        void Decorate(GameObject go, CustomObject customObject);
    }
}
