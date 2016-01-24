using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomSceneryRegistrar.Decorators;
using UnityEngine;

namespace CustomSceneryRegistrar.CustomScenery.Decorators
{
    class SnapToCenterDecorator : IDecorator
    {
        private bool _snap;

        public SnapToCenterDecorator(bool snap)
        {
            _snap = snap;
        }

        public void Decorate(GameObject go, CustomSceneryV1 customScenery)
        {
            if (go.GetComponent<Deco>() != null)
            {
                go.GetComponent<Deco>().defaultSnapToGridCenter = _snap;
            }
        }
    }
}
