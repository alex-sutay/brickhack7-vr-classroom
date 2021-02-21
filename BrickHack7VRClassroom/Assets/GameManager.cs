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
        GameObject screen = GameObject.Find("Screenwall");
        
        //Connect to zoom
        //Collect info on how many people are on a call
        numonCall = 16;
        
        //Collect who is host or co-host
        //

        //Demo
        for (int i = 0; i < numonCall; i++)
        {
            float posX;
            posX = 3.5f * i;
            //Needs to spawn in in rows, one behind the other.
            var test = Instantiate(attendee);
            test.GetComponent<Attendees>().nameSpace.text = i.ToString();

            test.transform.position = new Vector3(-9 + (3.5f * (i % 6)), 0.8f, 2 - (4 * Mathf.Floor(i / 6)));
            
            var videoPlayer = screen.AddComponent<UnityEngine.Video.VideoPlayer>();
            videoPlayer.playOnAwake = false;
            videoPlayer.Prepare();
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        //OVRInput.GetDown(OVRInput.Button.One);
        FunStressRelief();
    }
    
    public void Exit()
    {
        System.Environment.Exit(0);
    }
    public void StartVideo()
    {
        
        
    }
    public void FunStressRelief()
    {
        GameObject[] Friends;
        Physics2D.gravity = Vector3.zero;
        //access rigidbody, turn off gravity and give a bit of force.
        
        Friends = GameObject.FindGameObjectsWithTag("NPC");
        //Random.InitState((int) Mathf.Floor(Time.time));
        foreach(GameObject i in Friends)
        {
            Random.InitState(DateTime);
            Debug.Log(i.name);
            i.GetComponent<Rigidbody>().useGravity = false;
            i.GetComponent<Rigidbody>().AddForce(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1));
        }
        
    }
}
