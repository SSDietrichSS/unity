using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    //camera
    public Transform sphere;
    void Update()
    {
        Rigidbody rigidbody = transform.GetComponent<Rigidbody>();
        Vector3 vector = new Vector3(0, 5f, -5f);
        float velocity = rigidbody.velocity.sqrMagnitude;
        Debug.Log(velocity);
        Debug.Log(rigidbody.velocity.sqrMagnitude);
        vector =vector*(1f+velocity);
        transform.position = sphere.position + (vector);
        transform.LookAt(sphere);

    }
}
