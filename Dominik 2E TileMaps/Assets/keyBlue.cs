using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyBlue : MonoBehaviour
{
    public keyManager keyManager;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag=="Player")
        {
            keyManager.blue=true;
            Destroy(gameObject);
        }
    }
}
