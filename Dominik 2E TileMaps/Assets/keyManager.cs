using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyManager : MonoBehaviour
{
    public bool blue;
    public GameObject blueTrigger;
    public bool red;
    public GameObject redTrigger;
    public bool yellow;
    public GameObject yellowTrigger;
    public bool green;
    public GameObject greenTrigger;
    private void Start() {
        blueTrigger.GetComponent<Image>().enabled=false;
        redTrigger.GetComponent<Image>().enabled=false;
        yellowTrigger.GetComponent<Image>().enabled=false;
        greenTrigger.GetComponent<Image>().enabled=false;
    }
    private void Update() {
        if(blue==true) {
            {
                blueTrigger.GetComponent<Image>().enabled=true;
            }
        }
        if(red==true) {
            {
                redTrigger.GetComponent<Image>().enabled=true;
            }
        }
        if(yellow==true) {
            {
                yellowTrigger.GetComponent<Image>().enabled=true;
            }
        }
        if(green==true) {
            {
                greenTrigger.GetComponent<Image>().enabled=true;
            }
        }
    }
}
