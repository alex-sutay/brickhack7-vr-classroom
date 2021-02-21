using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
   // public GameObject manager;
    public GameObject attendee;
    public GameObject[] charPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        int numonCall;
        Text[] names;
        //Connect to zoom
        //Collect info on how many people are on a call
        //Demo for testing
        
        numonCall = 16;
        /*
        names = new Text[numonCall];
        //Demo
        names[0].text = "Test";
        names[1].text = "Please";
        names[2].text = "Work";
        */
        //Collect who is host or co-host
        //

        //Demo
        //-16 - 2
        
        //float posZ = 
        
        for (int i = 0; i < numonCall; i++)
        {
            float posX;
            posX = 3.5f * i;
            //Needs to spawn in in rows, one behind the other.
            var test = Instantiate(attendee);
            test.GetComponent<Attendees>().nameSpace.text = i.ToString();
            
            if(i < 5)
            {
                test.transform.position = new Vector3(-9 + posX, 0.8f, 2);
            }
            if (5 <= i && i < 10)
            {
                test.transform.position = new Vector3(-9 + posX, 0.8f, 2 - 4);
            }
            if (10 <= i && i < 15)
            {
                test.transform.position = new Vector3(-9 + posX, 0.8f, 2 - 8);
            }
            //Arrays don't work????
            //charPrefabs[i] = test;
            /*
            while(5 < i || i < 10)
            {
                test.transform.position = new Vector3(-9 + posX, 0.8f, 2 - 4);
            }
            while(10 < i || i < 15)
            {
                test.transform.position = new Vector3(-9 + posX, 0.8f, 22 - 8);
            }
            */


        }
        
        /*
        var test = (GameObject)Instantiate(attendee);
        test.transform.position = new Vector3(0, 0, 12);
        test.GetComponent<Attendees>().nameSpace.text = "Test";
        */
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }

    public void Exit()
    {
        System.Environment.Exit(0);
    }
    public void StartVideo()
    {
        //Activate video, or attach to zoom
    }
    public void FunStressRelief()
    {
        //access rigidbody, turn off gravity and give a bit of force.
    }
}
