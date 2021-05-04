using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    public Transform spark; 
    ParticleSystem myParticleSystem; 
    ParticleSystem.ColorOverLifetimeModule colorModule; 
    Gradient ourGradient;
    void Start() 
    {         
        spark.GetComponent<ParticleSystem> ().enableEmission=false; 
    }
    void OnTriggerEnter2D() 
    { 
        spark.GetComponent<ParticleSystem>().enableEmission = true; 
        StartCoroutine(stopSparkles()); 
    } 
    IEnumerator stopSparkles() 
    { 
        yield return new WaitForSeconds(2); 
        spark.GetComponent<ParticleSystem>().enableEmission = false; 
    } 
}
