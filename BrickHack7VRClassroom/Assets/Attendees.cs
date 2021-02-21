using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attendees : MonoBehaviour
{
    // string name;
    bool isTalking;
    public Text nameSpace;
    [SerializeField]
    GameObject spotLight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isTalking == true)
        {
            spotLight.active = true;
        }
        else
        {
            spotLight.active = false;
        }
    }
}
