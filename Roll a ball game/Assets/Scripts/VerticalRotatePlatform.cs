using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalRotatePlatform : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(25, 0.0f, 0.0f) * Time.deltaTime);
    }
}
