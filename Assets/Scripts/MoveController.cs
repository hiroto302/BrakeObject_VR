using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    private float angleSpeed = 10.0f;
    void Start()
    {
        
    }

    void Update()
    {
        // 右スティック操作 位置
        Vector3 righitStick = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);
        Vector3 velocity = new Vector3(righitStick.x / 10, 0, righitStick.y / 10);
        transform.Translate(velocity);

        // 左スティック操作 角度
        Vector3 leftStick = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
        Vector3 angle = new Vector3(0, leftStick.x * angleSpeed, 0);
        transform.Rotate(angle / 2);
    }
}
