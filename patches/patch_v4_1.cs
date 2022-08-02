using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Patch_v4_1 : MonoBehaviour {
    void Start() 
    { 
        Debug.Log("PATCH WORKS!!");
        IG.System.UI.instance.Notification.NewNotification("Patch has been added");
    }
}
