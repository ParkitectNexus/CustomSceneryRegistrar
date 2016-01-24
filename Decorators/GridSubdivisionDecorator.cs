using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomSceneryRegistrar.Decorators;
using UnityEngine;

namespace CustomSceneryRegistrar.CustomScenery.Decorators
{
    class GridSubdivisionDecorator : IDecorator
    {
        private float _subdivision;

        public GridSubdivisionDecorator(double subdivision)
        {
            _subdivision = (float)subdivision;
        }

        public void Decorate(GameObject go, CustomObject customObject)
        {
            if (go.GetComponent<Deco>() != null)
            {
                go.GetComponent<Deco>().defaultGridSubdivision = _subdivision;
            }
        }
    }
}
