using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnOnDrop : MonoBehaviour
{

    Vector3 originalPosition;
    Quaternion originalRotation;

    void Start()
    {
        originalPosition = this.gameObject.transform.position;
        originalRotation = this.gameObject.transform.rotation;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Floor")
        {
            this.gameObject.transform.position = originalPosition;
            this.gameObject.transform.rotation = originalRotation;
            this.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            this.gameObject.GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);
        }
    }

    
}
