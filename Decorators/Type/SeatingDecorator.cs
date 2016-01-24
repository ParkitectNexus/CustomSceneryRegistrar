using System.Collections.Generic;
using UnityEngine;

namespace CustomSceneryRegistrar.Decorators.Type
{
    class SeatingDecorator : IDecorator
    {
        public void Decorate(GameObject go, CustomObject customObject)
        {
            //if (customObject.ContainsKey("seatingOptions"))
            //{
            //    Dictionary<string, object> seatingOptions = customObject["seatingOptions"] as Dictionary<string, object>;
                
            //    go.AddComponent<Seating>();

            //    go.GetComponent<Seating>().hasBackRest = (bool)seatingOptions["hasBackRest"];
            //}
        }
    }
}
