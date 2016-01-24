using System.Collections.Generic;
using UnityEngine;

namespace CustomSceneryRegistrar.Decorators
{
    class GridDecorator : IDecorator
    {
        public void Decorate(GameObject go, CustomSceneryV1 customScenery)
        {
            if (go.GetComponent<Deco>() != null)
            {
                go.GetComponent<Deco>().buildOnGrid = true;
                go.GetComponent<Deco>().defaultGridSubdivision = customScenery.GridSubdivision;
            }
        }
    }
}
