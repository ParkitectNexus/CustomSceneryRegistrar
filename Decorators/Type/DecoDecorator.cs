using System;
using System.Collections.Generic;
using CustomSceneryRegistrar.CustomScenery.Decorators;
using UnityEngine;

namespace CustomSceneryRegistrar.Decorators.Type
{
    class DecoDecorator : IDecorator
    {
        public void Decorate(GameObject go, CustomSceneryV1 customScenery)
        {
            go.AddComponent<Deco>();

            if (Math.Abs(customScenery.HeightDelta) > 0.01f)
                (new HeightDecorator(customScenery.HeightDelta)).Decorate(go, customScenery);

            if (Math.Abs(customScenery.GridSubdivision) > 0.01f)
                (new GridDecorator()).Decorate(go, customScenery);

            if (customScenery.SnapCenter)
                (new SnapToCenterDecorator(customScenery.SnapCenter)).Decorate(go, customScenery);

            //if (CustomSceneryV1.ContainsKey("gridSubdivision"))
            //    (new GridSubdivisionDecorator((double)CustomSceneryV1["gridSubdivision"])).Register(go, CustomSceneryV1);

            //if (CustomSceneryV1.ContainsKey("snapCenter"))
            //    (new SnapToCenterDecorator((bool)CustomSceneryV1["snapCenter"])).Register(go, CustomSceneryV1);
        }
    }
}
