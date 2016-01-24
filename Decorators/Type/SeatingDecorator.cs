using System.Collections.Generic;
using UnityEngine;

namespace CustomSceneryRegistrar.Decorators.Type
{
    class SeatingDecorator : IDecorator
    {
        public void Decorate(GameObject go, CustomSceneryV1 customScenery)
        {
            //if (CustomSceneryV1.ContainsKey("seatingOptions"))
            //{
            //    Dictionary<string, object> seatingOptions = CustomSceneryV1["seatingOptions"] as Dictionary<string, object>;
                
            //    go.AddComponent<Seating>();

            //    go.GetComponent<Seating>().hasBackRest = (bool)seatingOptions["hasBackRest"];
            //}
        }
    }
}
