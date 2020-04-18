using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVerticalPlatform : MonoBehaviour
{
    private float speed = 2;

    private float rightPositionZ;
    private float leftPositionZ;

    private bool flagX = true;

    void Start()
    {
        rightPositionZ = transform.position.z + 8;
        leftPositionZ = transform.position.z;
    }
    void Update()
    {
        if (flagX == true)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);

            if (rightPositionZ < transform.position.z)
            {
                flagX = false;
            }
        }

        if (flagX == false)
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
            if (leftPositionZ > transform.position.z)
            {
                flagX = true;
            }
        }
    }
}
