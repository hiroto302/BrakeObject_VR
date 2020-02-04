using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicController : MonoBehaviour
{
    public GameObject magicPrefab;
    GameObject breakObject;
    void Start()
    {
        this.breakObject = GameObject.Find("BreakableCube");
    }

    void Update()
    {
        if(OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) && OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger))
        {
            OVRInput.SetControllerVibration(0.3f, 0.3f, OVRInput.Controller.LTouch);
            Instantiate(magicPrefab, gameObject.transform.position, Quaternion.identity);
            this.breakObject.GetComponent<BoxCollider>().enabled = true;
            // this.breakObject.GetComponent<BoxCollider>().isTrigger = true;
        }
        else if(OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger) || OVRInput.GetUp(OVRInput.Button.PrimaryHandTrigger))
        {
            OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.LTouch);
            this.breakObject.GetComponent<BoxCollider>().enabled = false;
            // this.breakObject.GetComponent<BoxCollider>().isTrigger = false;
        }
    }
}
