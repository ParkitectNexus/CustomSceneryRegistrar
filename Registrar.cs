using System.Collections.Generic;
using CustomSceneryRegistrar.Decorators;
using UnityEngine;

namespace CustomSceneryRegistrar
{
    public class Registrar
    {
        private static List<BuildableObject> _customObjects = new List<BuildableObject>();

        private static readonly GameObject _hider = new GameObject();
        
        public static GameObject Register(CustomSceneryV1 customSceneryV1)
        {
            GameObject asset = customSceneryV1.Object;

            if (asset == null)
            {
                asset = new GameObject();
            }

            (new TypeDecorator()).Decorate(asset, customSceneryV1);
            (new PriceDecorator()).Decorate(asset, customSceneryV1);
            (new NameDecorator()).Decorate(asset, customSceneryV1);
            (new RecolorableDecorator()).Decorate(asset, customSceneryV1);

            Object.DontDestroyOnLoad(asset);
            
            asset.transform.parent = _hider.transform;
            _hider.SetActive(false);
            
            BuildableObject buildableObject = asset.GetComponent<BuildableObject>();
            buildableObject.dontSerialize = true;
            buildableObject.isPreview = true;

            AssetManager.Instance.registerObject(buildableObject);

            return asset;
        }
        
        public static void UnloadScenery()
        {
            foreach (BuildableObject customObject in _customObjects)
            {
                AssetManager.Instance.unregisterObject(customObject);
            }
        }
    }
}
