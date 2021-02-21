using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int numonCall;
    public GameObject attendee;
    Text[] names;
    // Start is called before the first frame update
    void Start()
    {

        //Connect to zoom
        //Collect info on how many people are on a call
        //Demo for testing
        numonCall = 3;
        
        names = new Text[numonCall];

        //Demo
        names[0].text = "Test";
        names[1].text = "Please";
        names[2].text = "Work";
        //Collect who is host or co-host
        //
        for (int i = 0; i < numonCall; i++)
        {
            Instantiate(attendee, new Vector3(0, 0 + i, 0), Quaternion.identity);
            this.attendee.GetComponent<Attendees>().nameSpace = names[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Is someone spotlighted?
        //
       
    }
}
