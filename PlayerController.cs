using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 8.0f;
    [SerializeField] float moveableRange = 5;
    [SerializeField] GameObject cannonBall;
    [SerializeField] Transform spawPoint;
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(
            Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, //x 축
            0,0); //y,z 축                                                   // 중간 고사 나올 수 있 
        
        transform.position = new Vector2(                                    // 거리 제한 걸기
            Mathf.Clamp(transform.position.x, -5,5),
            transform.position.y
        );

        if(Input.GetKeyDown(KeyCode.Space)){
            GameObject newBullet = Instantiate(cannonBall,
                spawPoint.position,
                Quaternion.identity 
                ) as GameObject;

           newBullet.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 1000f);     // 하늘로 쏘는 코드  
        }
    }   
}
