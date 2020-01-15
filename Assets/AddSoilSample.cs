using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class AddSoilSample : MonoBehaviour
{
    public GameObject DirtyWater;
    public GameObject FilterImage;
    public GameObject Residue;

    // Start is called before the first frame update
    void Start()
    {
        DirtyWater.gameObject.SetActive(false);
        FilterImage.gameObject.SetActive(false);
        Residue.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "LeftHand" || col.gameObject.name == "RightHand")
        {
            if (col.gameObject.GetComponent<Hand>().interactedObject.name == "jarwithcontaminatedsoil")
            {
                if (col.gameObject.GetComponent<Hand>().interactedObject.GetComponent<WaterEnabler>().setVisible == true)
                {
                    DirtyWater.gameObject.SetActive(true);
                    FilterImage.gameObject.SetActive(true);
                    Residue.gameObject.SetActive(false);
                    col.gameObject.GetComponent<Hand>().interactedObject.GetComponent<WaterEnabler>().setVisible = false;
                }
            }
        }

    }
}
