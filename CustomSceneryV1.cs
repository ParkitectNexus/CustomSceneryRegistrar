using UnityEngine;

namespace CustomSceneryRegistrar
{
    public class CustomSceneryV1
    {
        // General
        public GameObject Object { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        // Deco options
        public float HeightDelta { get; set; }
        public float GridSubdivision { get; set; }
        public bool SnapCenter { get; set; }
        public bool BuildOnGrid { get; set; }

        // Recolor options
        public bool Recolorable { get; set; }
        public Color[] Colors { get; set; }

        // Fence options
        public GameObject FenceFlat { get; set; }
        public GameObject FencePost { get; set; }

        // Seating options
        public bool HasBackRest { get; set; }
    }
}
