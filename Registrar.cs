using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomSceneryRegistrar.Decorators;
using UnityEngine;

namespace CustomSceneryRegistrar
{
    public class Registrar : MonoBehaviour
    {
        public static Registrar Instance;

        private List<BuildableObject> _customObjects = new List<BuildableObject>();

        void Awake()
        {
            Instance = this;
        }

        public static GameObject Register(CustomSceneryV1 customSceneryV1)
        {
            GameObject asset = customSceneryV1.Object;

            if (asset == null)
            {
                asset = new GameObject();
            }

            (new TypeDecorator(customSceneryV1.Type)).Decorate(asset, customSceneryV1);
            (new PriceDecorator(customSceneryV1.Price)).Decorate(asset, customSceneryV1);
            (new NameDecorator(customSceneryV1.Name)).Decorate(asset, customSceneryV1);

            //if (options.ContainsKey("grid"))
            //    (new GridDecorator((bool)options["grid"])).Register(asset, options);

            if (customSceneryV1.Recolorable)
                (new RecolorableDecorator(customSceneryV1.Colors)).Decorate(asset, customSceneryV1);

            DontDestroyOnLoad(asset);

            //AssetManager.Instance.registerObject(asset.GetComponent<BuildableObject>());
            //_sceneryObjects.Add(asset.GetComponent<BuildableObject>());

            //// hide it from view
            //asset.transform.parent = hider.transform;

            RegisterAsset(asset);

            return asset;
        }

        public static void RegisterAsset(GameObject gameObject)
        {
            Debug.Log(gameObject.GetComponent<BuildableObject>());

            BuildableObject buildableObject = gameObject.GetComponent<BuildableObject>();
            buildableObject.dontSerialize = true;
            buildableObject.isPreview = true;

            AssetManager.Instance.registerObject(buildableObject);
        }

        public void UnloadScenery()
        {
            foreach (BuildableObject customObject in _customObjects)
            {
                AssetManager.Instance.unregisterObject(customObject);
            }
        }
    }
}
