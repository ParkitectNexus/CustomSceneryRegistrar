using UnityEngine;

namespace CustomSceneryRegistrar.Decorators
{
    class RecolorableDecorator : IDecorator
    {
        public void Decorate(GameObject go, CustomSceneryV1 customScenery)
        {
            if (go.GetComponent<BuildableObject>() != null && customScenery.Recolorable)
            {
                CustomColors cc = go.AddComponent<CustomColors>();
                
                cc.setColors(customScenery.Colors);

                foreach (Material material in AssetManager.Instance.objectMaterials)
                {
                    if (material.name == "CustomColorsDiffuse")
                    {
                        SetMaterial(go, material);

                        // edge case for fences
                        Fence fence = go.GetComponent<Fence>();

                        if (fence != null)
                        {
                            if (fence.flatGO != null)
                            {
                                SetMaterial(fence.flatGO, material);
                            }

                            if (fence.postGO != null)
                            {
                                SetMaterial(fence.postGO, material);
                            }
                        }

                        break;
                    }
                }
            }
        }

        private void SetMaterial(GameObject go, Material material)
        {
            // Go through all child objects and recolor		
            Renderer[] renderCollection;
            renderCollection = go.GetComponentsInChildren<Renderer>();

            foreach (Renderer render in renderCollection)
            {
                render.sharedMaterial = material;
            }
        }
    }
}
