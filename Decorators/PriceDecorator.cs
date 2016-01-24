using System.Collections.Generic;
using UnityEngine;

namespace CustomSceneryRegistrar.Decorators
{
    class PriceDecorator : IDecorator
    {
        private float _price;

        public PriceDecorator(float price)
        {
            _price = price;
        }

        public void Decorate(GameObject go, CustomObject customObject)
        {
            go.GetComponent<BuildableObject>().price = _price;
        }
    }
}
