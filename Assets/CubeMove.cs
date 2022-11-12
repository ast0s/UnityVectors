using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), 0.1f);
    }
}
