using System.Collections.Generic;
using UnityEngine;

namespace CustomSceneryRegistrar.Decorators.Type
{
    class SeatingAutoDecorator : IDecorator
    {
        public void Decorate(GameObject go, CustomSceneryV1 customScenery)
        {
            //if (CustomSceneryV1.ContainsKey("seatingOptions"))
            //{
            //    Dictionary<string, object> seatingOptions = CustomSceneryV1["seatingOptions"] as Dictionary<string, object>;
                
            //    if (seatingOptions.ContainsKey("seatCount"))
            //    {
            //        if ((double)seatingOptions["seatCount"] == 1.0)
            //        {
            //            GameObject seat1 = new GameObject("Seat");

            //            seat1.transform.parent = go.transform;

            //            seat1.transform.localPosition = new Vector3(0, 0.1f, 0);
            //            seat1.transform.localRotation = Quaternion.Euler(Vector3.zero);
            //        }
            //        else if ((double)seatingOptions["seatCount"] == 2.0)
            //        {
            //            GameObject seat1 = new GameObject("Seat");
            //            GameObject seat2 = new GameObject("Seat");

            //            seat1.transform.parent = go.transform;
            //            seat2.transform.parent = go.transform;

            //            seat1.transform.localPosition = new Vector3(0.1f, 0.1f, 0);
            //            seat1.transform.localRotation = Quaternion.Euler(Vector3.zero);
            //            seat2.transform.localPosition = new Vector3(-0.1f, 0.1f, 0);
            //            seat2.transform.localRotation = Quaternion.Euler(Vector3.zero);
            //        }
            //    }

            //    go.AddComponent<Seating>();

            //    go.GetComponent<Seating>().hasBackRest = (bool)seatingOptions["hasBackRest"];
            //}
        }
    }
}
