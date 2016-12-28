using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public Transform sphere;
    void Update()
    { //przypisy
        Rigidbody rigidbody = transform.GetComponent<Rigidbody>();
        float velocity = rigidbody.velocity.sqrMagnitude;
        Vector3 vector = new Vector3(0, 5f, -5f);
        //test
        Debug.Log(velocity);
        Debug.Log(rigidbody.velocity.sqrMagnitude);
        //skierowanie kamery
        vector = vector * (1f + velocity);
        transform.position = sphere.position + (vector);
        transform.LookAt(sphere);

    }
}
