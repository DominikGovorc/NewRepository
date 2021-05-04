using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class block2 : MonoBehaviour
{
    private ParticleSystem particle; 
    public SpriteRenderer sr; 
    public BoxCollider2D bc; 
    public Text tekst;
        private void Start() 
    { 
        
        particle = gameObject.GetComponentInChildren<ParticleSystem>(); particle.enableEmission=false;
    } 
    private void OnCollisionEnter2D(Collision2D other) 
    { 
        if (other.collider.gameObject.GetComponent<Movement>()&&other.contacts[0].normal.y>0.5) 
        {//da li je player i da li je udarac odozdo 
            StartCoroutine(razbij()); 
        } 
    } 
    public IEnumerator razbij() 
    { 
        particle.Play(); 
        sr.enabled=false;
        bc.enabled=false;
        tekst.GetComponent<yes>().score++;
        yield return new WaitForSeconds(1f); 
        Destroy(gameObject); 
    } 
}
