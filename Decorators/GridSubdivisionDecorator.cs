using UnityEngine;

namespace CustomSceneryRegistrar.Decorators
{
    class GridSubdivisionDecorator : IDecorator
    {
        public void Decorate(GameObject go, CustomSceneryV1 customScenery)
        {
            if (go.GetComponent<Deco>() != null)
            {
                go.GetComponent<Deco>().defaultGridSubdivision = customScenery.GridSubdivision;
            }
        }
    }
}
