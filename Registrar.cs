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

        void Awake()
        {
            Instance = this;
        }

        public static GameObject Register(CustomObject customObject)
        {
            GameObject asset = customObject.Object;
            (new TypeDecorator(customObject.Type)).Decorate(asset, customObject);
            (new PriceDecorator(customObject.Price)).Decorate(asset, customObject);
            (new NameDecorator(customObject.Name)).Decorate(asset, customObject);

            //if (options.ContainsKey("grid"))
            //    (new GridDecorator((bool)options["grid"])).Register(asset, options);

            if (customObject.Recolorable)
                (new RecolorableDecorator(customObject.Colors)).Decorate(asset, customObject);

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

            Debug.Log("Registered " + gameObject.GetComponent<BuildableObject>().name);
        }
    }
}
