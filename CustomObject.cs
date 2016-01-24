using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace CustomSceneryRegistrar
{
    public class CustomObject
    {
        public GameObject Object { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public float Price { get; set; }

        public float heightDelta { get; set; }

        public float GridSubdivision { get; set; }

        public bool SnapCenter { get; set; }

        public bool Recolorable { get; set; }

        public Color[] Colors { get; set; }
    }
}
