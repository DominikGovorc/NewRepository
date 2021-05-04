using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyYellow : MonoBehaviour
{
    public keyManager keyManager;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag=="Player")
        {
            keyManager.yellow=true;
            Destroy(gameObject);
        }
    }
}
