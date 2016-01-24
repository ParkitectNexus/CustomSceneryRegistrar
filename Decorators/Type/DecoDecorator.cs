using System.Collections.Generic;
using CustomSceneryRegistrar.CustomScenery.Decorators;
using UnityEngine;

namespace CustomSceneryRegistrar.Decorators.Type
{
    class DecoDecorator : IDecorator
    {
        public void Decorate(GameObject go, CustomObject customObject)
        {
            go.AddComponent<Deco>();
            Debug.Log("Added deco");

            //if (customObject.ContainsKey("heightDelta"))
            //    (new HeightDecorator((double)customObject["heightDelta"])).Register(go, customObject);

            //if (customObject.ContainsKey("gridSubdivision"))
            //    (new GridSubdivisionDecorator((double)customObject["gridSubdivision"])).Register(go, customObject);

            //if (customObject.ContainsKey("snapCenter"))
            //    (new SnapToCenterDecorator((bool)customObject["snapCenter"])).Register(go, customObject);
        }
    }
}
