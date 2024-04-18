using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickBall : MonoBehaviour
{
    [SerializeField] GameObject prefeb_ChckBall;
    [SerializeField] float interval = 3.0f;

    void SpawnChickBall(){
        Instantiate(prefeb_ChckBall,transform.position,transform.rotation);    // ★★시험 == 프리팹은 Instantiate같은 키워드 제시 잘 해야함 
    }
        // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnChickBall",0.1f,interval);    // 지연시간
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
