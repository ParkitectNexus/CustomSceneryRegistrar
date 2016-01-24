using UnityEngine;

namespace CustomSceneryRegistrar.Decorators.Type
{
    class FenceDecorator : IDecorator
    {
        public void Decorate(GameObject go, CustomSceneryV1 customScenery)
        {
            go.AddComponent<Fence>();
            
            if (customScenery.FenceFlat != null)
            {
                go.GetComponent<Fence>().flatGO = customScenery.FenceFlat;
            }
            
            if (customScenery.FencePost != null)
            {
                go.GetComponent<Fence>().postGO = customScenery.FencePost;
            }

            go.GetComponent<Fence>().hasMidPosts = false;
        }
    }
}
