﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    
    void FixedUpdate()
    {
        transform.position += new Vector3(0, 0, -0.1f * Time.deltaTime);     
    }
}
