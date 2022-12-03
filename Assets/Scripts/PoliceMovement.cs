using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceMovement : MonoBehaviour
{
    public GameObject target;

    void Update()
    {
        transform.position = new Vector3(target.transform.position.x - 11.8f, target.transform.position.y, 0);
    }
}
