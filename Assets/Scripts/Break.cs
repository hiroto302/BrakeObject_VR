using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{
    public GameObject explosion;  //爆発prefab
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    // 衝突判定  アタッチされているオブジェクトが他のオブジェクトと当たると呼ばれるメソッド
    // 衝突したオブジェクトは、collision に格納される
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Hand")
        {
            //オブジェクトを消し、爆発する
            Destroy(gameObject);  //小文字のgameObjectは、このスクリプトがアタッチされているオブジェクトを指す

            //爆発prefabの生成 第二引数に位置、第三引数に回転
            Instantiate(explosion, gameObject.transform.position, Quaternion.identity);

            OVRInput.SetControllerVibration(0.3f, 0.3f, OVRInput.Controller.RTouch);
            OVRInput.SetControllerVibration(0.3f, 0.3f, OVRInput.Controller.LTouch);
        }
    }
}
