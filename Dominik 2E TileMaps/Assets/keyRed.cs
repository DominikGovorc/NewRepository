using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyRed : MonoBehaviour
{
public keyManager keyManager;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag=="Player")
        {
            keyManager.red=true;
            Destroy(gameObject);
        }
    }
}
