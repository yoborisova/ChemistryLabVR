using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class AddWaterToMyself : MonoBehaviour
{
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

            if (col.gameObject.GetComponent<Hand>().interactedObject.name == "measuring25" ||
                col.gameObject.GetComponent<Hand>().interactedObject.name == "measuring50" ||
                col.gameObject.GetComponent<Hand>().interactedObject.name == "measuring100")
            {
                col.gameObject.GetComponent<Hand>().interactedObject.GetComponent<WaterEnabler>().setVisible = false;
                this.GetComponent<WaterEnabler>().setVisible = true;
            }
        }

    }
}
