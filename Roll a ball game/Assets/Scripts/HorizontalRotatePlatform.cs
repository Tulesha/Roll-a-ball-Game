﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalRotatePlatform : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0.0f, 0.0f, 25) * Time.deltaTime);
    }
}
