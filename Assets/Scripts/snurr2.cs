using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snurrX : MonoBehaviour
{
    private Touch touch;

    private Vector2 touchPosition;

    private Quaternion rotationZ;

    private float rotateSpeedModifier = 0.1f;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                rotationZ = Quaternion.Euler(
                    0f,
                    0f,
                    - touch.deltaPosition.x * rotateSpeedModifier);

                transform.rotation = rotationZ * transform.rotation;
            }
        }
    }
}