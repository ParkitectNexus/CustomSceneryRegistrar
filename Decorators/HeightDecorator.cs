using System.Collections.Generic;
using UnityEngine;

namespace CustomSceneryRegistrar.Decorators
{
    class HeightDecorator : IDecorator
    {
        private float _height;

        public HeightDecorator(double height)
        {
            _height = (float)height;
        }

        public void Decorate(GameObject go, CustomObject customObject)
        {
            go.GetComponent<Deco>().heightChangeDelta = _height;
        }
    }
}
