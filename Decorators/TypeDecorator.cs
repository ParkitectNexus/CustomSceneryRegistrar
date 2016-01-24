using System.Collections.Generic;
using CustomSceneryRegistrar.Decorators.Type;
using UnityEngine;

namespace CustomSceneryRegistrar.Decorators
{
    class TypeDecorator : IDecorator
    {
        private string _type;

        public TypeDecorator(string type)
        {
            _type = type;
        }

        public void Decorate(GameObject go, CustomObject customObject)
        {
            switch (_type)
            {
                case "deco":
                    (new DecoDecorator()).Decorate(go, customObject);
                    break;
                case "trashbin":
                    (new TrashBinDecorator()).Decorate(go, customObject);
                    break;
                case "seating":
                    (new SeatingDecorator()).Decorate(go, customObject);
                    break;
                case "seatingAuto":
                    (new SeatingAutoDecorator()).Decorate(go, customObject);
                    break;
                //case "fence":
                //    (new FenceDecorator()).Register(go, customObject);
                //    break;
                case "lamp":
                    (new LampDecorator()).Decorate(go, customObject);
                    break;
                default:
                    Application.Quit();
                    Debug.Log(_type + "is no valid type");
                    break;
            }
        }

        //public GameObject Register(CustomObject customObject)
        //{
        //    GameObject asset = null;

        //    switch (_type)
        //    {
        //        case "deco":
        //        case "trashbin":
        //        case "seating":
        //        case "seatingAuto":
        //        case "lamp":
        //            asset = Object.Instantiate(bundle.LoadAsset((string) options["model"])) as GameObject;
        //            break;
        //        case "fence":
        //            asset = new GameObject();
        //            break;
        //    }

        //    Register(asset, (CustomObject) options);

        //    return asset;
        //}
    }
}
