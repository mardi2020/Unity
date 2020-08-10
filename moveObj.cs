using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    void Start(){
        // Vector3 : 3차원 벡터
        Vector3 vec = new Vector3(0, 0, 0); // x, y, z 축  벡터 값
        transform.Translate(Vec); //오브젝트가 갖고있는 transform
        // Translate : Vec의 크기만큼 오브젝트 이동하기

    }

    void Update(){
        //통상적으로 1초에 60회씩 동작함
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical"), 0);
        transform.Translate(vec);
    }
}

