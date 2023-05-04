using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceBoosterSphere : MonoBehaviour
{
   [SerializeField]private float addforceamt = 100f;
    private Rigidbody rigidbody1;

    private void Awake()
    {
        rigidbody1 = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            rigidbody1.AddForce(Vector3.up * addforceamt);
                
        }
            }
}
