﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage_2_wall_rotation_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, (float)1.5, 0));
    }
}
