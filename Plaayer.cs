using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plaayer : MonoBehaviour
{
    void Start()
    {
        // Managers mg = new Managers(); 와 똑같은 기능임. 근데 유니티에 있는거만 사용해야 되므로,
        // 일반적인 문법으로는 불가하다. 그래서 이 방법을 사용한다.
        Managers mg = Managers.GetInstance();
        // 게임 오브젝트를 이름으로 찾는거 자체가 부하가 심함. -> 싱글톤

    }
    void Update()
    {
        
    }
}
