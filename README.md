# Unity

DeltaTime 이란?
전 프레임이 완료되기까지 걸린 시간을 나타내며 단위는 초를 사용한다. 컴퓨터의 성능이 느릴 수록 값이 커진다.
사용자의 Frame rate를 독립적으로 적용하기 위해서 사용한다.

매 프레임마다 어떤 값을 더하거나 빼는 계산을 하는 경우에, Time.deltaTime과 곱해서 사용할 수 있다.
Time.deltaTime과 곱하는 경우, 오브젝트를 프레임당 10미터가 아닌 초당 10미터 움직이고 싶은경우를 나타냅니다.

using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour {
    void Update() {
        float translation = Time.deltaTime * 10;
        transform.Translate(0, 0, translation);
    }
}



