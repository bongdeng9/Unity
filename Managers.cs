using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{

    static Managers Instance; // 유일성이 보장된다. 전역으로 사용.
    public static Managers GetInstance() { Init(); return Instance; } // 유일한 매니저를 갖고온다.


    void Start()
    {
        Init();
    }
    void Update()
    {
        
    }

    static void Init()
    {
        if (Instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if (go == null)
            {
                go = new GameObject { name = "@Managers" };
                go.AddComponent<Managers>();
            }

            DontDestroyOnLoad(go);
            Instance = go.GetComponent<Managers>();
        }
    }
}
