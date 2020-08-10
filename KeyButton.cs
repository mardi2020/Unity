using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    // 키보드와 마우스로 오브젝트 이동
    
    void Update(){
        if(Input.anyKeyDown) // anyKeyDown은 아무 입력을 최초로 받을 때 true
            Debug.Log("아무 키를 눌렀습니다.");
        if(Input.anyKey)
            Debug.Log("아무 키를 누르고 있습니다");
        

        //GetMouse : 마우스 버튼 입력을 받으면 true
        // 0 : 마우스 왼쪽 버튼
        // 1 : 마우스 오른쪽 버튼
        if(Input.GetMouseButtonDown(0))
            Debug.Log("미사일 발사");

        if(Input.GetMouseButton(0))
            Debug.Log("미사일 모으는 중...");

        if(Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사");

        // GetKey Down/Stay/Up
        if(Input.GetKeyDown(KeyCode.Return))
            Debug.Log("아이템을 구매하였습니다");

        if(Input.GetKey(KeyCode.LeftArrow)) // 키보드 버튼 입력을 받으면 true
            Debug.Log("왼쪽으로 이동 중");
        
        if(Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽으로 이동을 멈추었습니다");


        // GetButton : Input 버튼 입력을 받으면 true
        // 함수의 매개변수는 Input manager에 있는 string
        if(Input.GetButtonDown("Jump"))
            Debug.Log("JUMP");
        if(Input.GetButton("Jump"))
            Debug.Log("점프 모으는 중");
        if(Input.GetButtonUp("Jump"))
            Debug.Log("슈퍼 점프!!");

        if(Input.GetButton("Horizontal")){
            //Debug.Log("횡 이동중" + Input.GetAxis("Horizontal"));
            // 오브젝트는 변수 transform을 항상 갖고 있다
            Debug.Log("수평 이동중" + Input.GetAxisRaw("Horizontal"));
            // GetAxis() : 수평, 수직 버튼 입력을 받으면 float
            // GEtAxisRaw()
            
        }

        if(Input.GetButton("Vertical")){
            Debug.Log("수직 이동중" + Input.GetAxisRaw("Vertical"));
        }

    }
    
}

/*
Input : 게임 내 입력을 관리하는 클래스
*/
