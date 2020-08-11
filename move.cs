using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);

    void Update(){
        /* Vector3 이동 방식 4가지 */
        
        // 1. MoveTowards
        transform.position = Vector3.MoveTowards(transform.position, target, 2f);
        // MoveTowards(현재위치, 목표위치, 비례하여 속도 증감)

        // 2. SmoothDamp : 부드러운 감속 이동
        Vector3 velo = Vector3.zero;
        //Vector3 velo = Vector3.up * 50;
        transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 1f);
        // SmoothDamp(현재위치, 목표위치, 참조 속도, 속도)

        // 3. Lerp (선형 보간)
        transform.position = Vector3.Lerp(transform.position, target, 0.1f);

        // 4. SLerp (구면 선형 보간) - 포물선으로 
        transform.position = Vector3.Slerp(transform.position, target, 0.05f);
    }
}
