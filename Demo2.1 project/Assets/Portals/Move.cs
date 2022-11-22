using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    [Header("動作參數")]
    [SerializeField] float movespeed_kmhr = 30f ;

    [Header("全域變數!!勿動!!")]
    public Vector3 camera_diraction ;
    Rigidbody man_rigidbody ;
    GameObject __camera ;

    private float movespeed = 0f ;
    private Vector3 move_direction ;



    void Start() {
        man_rigidbody = GetComponent<Rigidbody>();
        __camera = GameObject.Find("Main Camera");
        movespeed = movespeed_kmhr*0.02f/3600f*1000f;
    }

    void Update() {
    }

    void FixedUpdate() {
        if ( Input.GetAxis("Horizontal")!=0 || Input.GetAxis("Vertical")!=0 ) {
            MoveControll();
            return;
        }
    }
    void MoveControll(){
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        camera_diraction = __camera.gameObject.transform.TransformDirection(input);
        //把input轉換成攝影機的方向
        move_direction = new Vector3(camera_diraction.x, 0, camera_diraction.z).normalized;
        //去除Y值(通常地面和攝影機會有角度)
        transform.position = (transform.position + move_direction * movespeed);
        //角色移動
    }
}