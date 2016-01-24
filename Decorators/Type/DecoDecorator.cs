using System;
using UnityEngine;

namespace CustomSceneryRegistrar.Decorators.Type
{
    class DecoDecorator : IDecorator
    {
        public void Decorate(GameObject go, CustomSceneryV1 customScenery)
        {
            go.AddComponent<Deco>();

            if (Math.Abs(customScenery.HeightDelta) > 0.01f)
                (new HeightDecorator()).Decorate(go, customScenery);

            if (Math.Abs(customScenery.GridSubdivision) > 0.01f)
                (new GridDecorator()).Decorate(go, customScenery);

            if (Math.Abs(customScenery.GridSubdivision) > 0.01f)
                (new GridSubdivisionDecorator()).Decorate(go, customScenery);

            if (customScenery.SnapCenter)
                (new SnapToCenterDecorator()).Decorate(go, customScenery);
        }
    }
}
