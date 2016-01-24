using System.Collections.Generic;
using UnityEngine;

namespace CustomSceneryRegistrar.Decorators
{
    interface IDecorator
    {
        void Decorate(GameObject go, CustomSceneryV1 customScenery);
    }
}
