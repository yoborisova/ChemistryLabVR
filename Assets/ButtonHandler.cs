using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public float scale = 0.1f;
    public GameObject WaterDrip;
    public Transform source;
    public bool IsTurnedOn = false;
    public GameObject waterContainer; // just to keep the scene clear
    public float time = 0.5f;
    public float last = 0;
    bool waterDropping = false;
    public Transform water_spawn_point;
    // Start is called before the first frame update
    void Start()
    {
        //WaterDrip = GetComponent<GameObject>();
    }

    // Update is called once per frame


    float dt = 0;
    void Update()
    {
        if (dt < 0.2)
        {
            Debug.Log("dt increasing to " + dt);
            dt += Time.fixedDeltaTime;
        }
        else
        {
            dt = 0;
            if (waterDropping)
            {
                Debug.Log("Time to spawn some shit!");
                Instantiate(WaterDrip, water_spawn_point.position, Quaternion.identity);
            }

        }

    }


    void OnTriggerEnter(Collider C)
    {

        if (C.gameObject.layer == 9 || C.gameObject.layer == 10)
        {
            Debug.Log("Collision with hands!");
            waterDropping = !waterDropping;
        }
    }
}