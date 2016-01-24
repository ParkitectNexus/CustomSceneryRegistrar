using System.Collections.Generic;
using UnityEngine;

namespace CustomSceneryRegistrar.Decorators.Type
{
    //class FenceDecorator : IDecorator
    //{
    //    public void Register(GameObject go, CustomObject customObject)
    //    {
    //        go.AddComponent<Fence>();

    //        Dictionary<string, object> fenceOptions = customObject["fenceOptions"] as Dictionary<string, object>;


    //        if (fenceOptions.ContainsKey("flat"))
    //        {
    //            GameObject flat = Object.Instantiate(assetBundle.LoadAsset((string)fenceOptions["flat"])) as GameObject;
    //            flat.transform.rotation = Quaternion.identity;
    //            go.GetComponent<Fence>().flatGO = flat;
    //        }

    //        if (fenceOptions.ContainsKey("post"))
    //        {
    //            GameObject post = Object.Instantiate(assetBundle.LoadAsset((string)fenceOptions["post"])) as GameObject;
    //            post.transform.rotation = Quaternion.identity;
    //            go.GetComponent<Fence>().postGO = post;
    //        }

    //        go.GetComponent<Fence>().hasMidPosts = false;
    //    }
    //}
}
