using System.Collections.Generic;
using UnityEngine;

namespace CustomSceneryRegistrar.Decorators
{
    class GridDecorator : IDecorator
    {
        private bool _grid;

        public GridDecorator(bool grid)
        {
            _grid = grid;
        }
        
        public void Decorate(GameObject go, CustomObject customObject)
        {
            if (go.GetComponent<Deco>() != null && _grid)
            {
                go.GetComponent<Deco>().buildOnGrid = _grid;
            }
        }
    }
}
