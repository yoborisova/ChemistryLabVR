using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Acid : MonoBehaviour
{

    public GameObject AcidStrip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "LeftHand" || col.gameObject.name == "RightHand")
        {
            if (col.gameObject.GetComponent<Hand>().interactedObject.name == "AcidStrip")
            {
                AcidStrip.GetComponent<Renderer>().material.color = new Color32(255, 165, 0, 100);
            }
        }

    }
}
