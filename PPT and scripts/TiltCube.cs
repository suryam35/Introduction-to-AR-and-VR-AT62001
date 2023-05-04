using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltCube : MonoBehaviour
{
    private float tiltspeed = 15f;


    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.forward, angle: horizontal * Time.deltaTime * tiltspeed);


    }
}
