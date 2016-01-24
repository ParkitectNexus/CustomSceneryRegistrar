using CustomSceneryRegistrar.Decorators.Type;
using UnityEngine;

namespace CustomSceneryRegistrar.Decorators
{
    class TypeDecorator : IDecorator
    {
        public void Decorate(GameObject go, CustomSceneryV1 customScenery)
        {
            string type = customScenery.Type;

            switch (type)
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
                    Debug.Log(type + "is no valid type");
                    break;
            }
        }
    }
}
