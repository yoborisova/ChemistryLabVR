using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterEnabler : MonoBehaviour
{
    public GameObject waterObject;
    public bool setVisible;
    // Start is called before the first frame update
    void Start()
    {
        waterObject.GetComponent<MeshRenderer>().enabled = false;
        setVisible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (setVisible == true)
        {
            waterObject.GetComponent<MeshRenderer>().enabled = true;
        }
        else
        {
            waterObject.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
