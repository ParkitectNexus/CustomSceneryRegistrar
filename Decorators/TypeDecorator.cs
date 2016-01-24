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

        public void Decorate(GameObject go, CustomSceneryV1 customScenery)
        {
            switch (_type)
            {
                case "deco":
                    (new DecoDecorator()).Decorate(go, customScenery);
                    break;
                case "trashbin":
                    (new TrashBinDecorator()).Decorate(go, customScenery);
                    break;
                case "seating":
                    (new SeatingDecorator()).Decorate(go, customScenery);
                    break;
                case "fence":
                    (new FenceDecorator()).Decorate(go, customScenery);
                    break;
                case "lamp":
                    (new LampDecorator()).Decorate(go, customScenery);
                    break;
                default:
                    Debug.Log(_type + "is no valid type");
                    break;
            }
        }

        //public GameObject Register(CustomSceneryV1 CustomSceneryV1)
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

        //    Register(asset, (CustomSceneryV1) options);

        //    return asset;
        //}
    }
}
