using System.Collections.Generic;
using UnityEngine;

namespace CustomSceneryRegistrar.Decorators
{
    class NameDecorator : IDecorator
    {
        private string _name;

        public NameDecorator(string name)
        {
            _name = name;
        }

        public void Decorate(GameObject go, CustomObject customObject)
        {
            go.GetComponent<BuildableObject>().setDisplayName(_name);
            go.name = _name;
        }
    }
}
