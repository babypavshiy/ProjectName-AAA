using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    public bool FaceRight = true;

    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            FaceRight = true;

            Quaternion rot = transform.rotation;
            rot.y = 0;
            transform.rotation = rot;
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            FaceRight = false;

            Quaternion rot = transform.rotation;
            rot.y = 180;
            transform.rotation = rot;
        }
    }
}
