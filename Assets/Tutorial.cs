using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Tutorial : MonoBehaviour
{
    public GameObject TutorialZone;
    public GameObject Laboratory;

    // Start is called before the first frame update
    void Start()
    {
        TutorialZone.gameObject.SetActive(true);
        Laboratory.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "LeftHand" || col.gameObject.name == "RightHand")
        {
            TutorialZone.gameObject.SetActive(false);
            Laboratory.gameObject.SetActive(true);
        }

    }
}
