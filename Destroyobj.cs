using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyobj : MonoBehaviour
{
    [SerializeField] float deltaTime = 2;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
