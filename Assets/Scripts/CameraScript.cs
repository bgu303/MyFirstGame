using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject target;
    public float speed = 3.0f;

    void Start()
    {
        
    }
    
    void Update()
    {
        transform.position += Vector3.right * Time.deltaTime * speed;
        // transform.position = new Vector3(target.transform.position.x, transform.position.y, -10);
    }
}
