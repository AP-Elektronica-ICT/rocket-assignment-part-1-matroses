using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    //Ik maakte gebruik van https://docs.unity3d.com/2017.3/Documentation/ScriptReference/Transform-rotation.html voor de rotatie

    float tiltAngle = -90.0f;
    Vector3 power = new Vector3(0, 20, 0);

    void Update()
    {
        // Smoothly tilts a transform towards a target rotation.
        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;

        Quaternion target = Quaternion.Euler(0, 0, tiltAroundZ);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime);

        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(transform.rotation * power);
        }
    }
}
