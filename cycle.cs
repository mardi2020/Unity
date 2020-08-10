using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 프레임
// 초기화 -> (활성화) -> 물리 -> 게임로직 -> (비활성화) -> 해체
public class NewBehaviourScript : MonoBehaviour
{

    void Awake(){ // 게임 오브젝트 생성할 때, 최초 실행
        Debug.Log("플레이어의 데이터가 준비되었습니다.");
    }

    //오브젝트 사용/비사용 -> 활성화
    void OnEnable(){
        //게임 오브젝트가 활성화 되었을 때
        Debug.Log("Login");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    void FixedUpdate(){ // 물리 연산 업데이트
        // 고정된 실행 주기로 CPU를 많이 사용함
        Debug.Log("이동");
    }
    
    void Update(){
        //물리 연산을 제외한 게임 로직 업테이트
        //환경에 따라 실행 주기가 떨어질 수 있다
        Debug.Log("몬스터 사냥");
    }

    void LateUpdate(){
        //모든 업데이트가 끝난 후
        //로직의 후처리
        Debug.Log("경험치 획득");
    }
    
    void OnDisable(){
        // 게임 오브젝트가 비활성화 되었을 때
        Debug.Log("Logout");
    }

    void OnDestroy(){
        //게임 오브젝트가 삭제될 때
        Debug.Log("플레이어 데이터를 해체하였습니다.");
    }

    
}

