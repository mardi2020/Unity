using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    // Time.DeltaTime : 이전 프레임의 완료까지 걸린 시간
    // 델타타임 값은 프레임이 적으면 크고, 프레임이 많으면 작다

    // Translate : 벡터에 곱하기
    // transform.Translate(Vec * Time.deltaTime);

    // Vector 함수 : tlrks aoroqustndp rhqgkrl
    // Vector3.Lerp(v1, v2, T * Time.deltaTime);
    void Start(){

    }

    void Update(){
        Vector3 v1 = new Vector3(
            Input.GetAxisRaw("Horizontal") * Time.deltaTime,
            Input.GetAxisRaw("Vertical") * Time.deltaTime,
            0
        );
        transform.Translate(v1);
    }
}

