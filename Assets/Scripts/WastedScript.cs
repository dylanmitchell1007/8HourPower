using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WastedScript : MonoBehaviour
{
    
    public Text wastedText;
    public string thingToSay = "WASTED FOO /n Use the Balls" ;

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            wastedText.text = thingToSay;
          
                  
        }
    }
    
}