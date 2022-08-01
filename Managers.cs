using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{

    static Managers Instance; // 유일성이 보장된다.
    public static Managers GetInstance() { return Instance; } // 유일한 매니저를 갖고온다.


    void Start()
    {
        // 초기화
        GameObject go = GameObject.Find("@Managers");
        Instance = go.GetComponent<Managers>();
    }
    void Update()
    {
        
    }
}
