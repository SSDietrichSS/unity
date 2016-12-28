using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    void Update()
    {// sterowanie góra dół
        Rigidbody rigidbody = transform.GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.AddTorque(-Vector3.left * 25);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody.AddTorque(Vector3.left * 25);
        }
        //sterowanie prawo lewo
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddTorque(-Vector3.forward * 25);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddTorque(Vector3.forward * 25);
        }

    }
}
