using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yes : MonoBehaviour
{
    public int score;
    void Update()
    {
        gameObject.GetComponent<Text>().text = "Score: " + score; 
    }
}
