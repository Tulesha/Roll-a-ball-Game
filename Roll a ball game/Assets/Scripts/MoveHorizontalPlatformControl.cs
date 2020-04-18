using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHorizontalPlatformControl : MonoBehaviour
{
    private float speed = 2;

    private float rightPositionX;
    private float leftPositionX;

    private bool flagX = true;

    void Start()
    {
        rightPositionX = transform.position.x + 8;
        leftPositionX = transform.position.x;
    }
    void Update()
    {
        if (flagX == true)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);

            if (rightPositionX < transform.position.x)
            {
                flagX = false;
            }
        }

        if (flagX == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            if (leftPositionX > transform.position.x)
            {
                flagX = true;
            }
        }
    }
}
