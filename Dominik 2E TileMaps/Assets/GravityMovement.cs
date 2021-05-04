using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityMovement : MonoBehaviour
{
   public Rigidbody2D body;
    public GameObject bullet;
    public bool isRight;
    public bool isGrounded;
    public float runSpeed = 10.0f;
    public float health=100f;
    public float jumpforce;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag=="Collider")
        {
            isGrounded=true;
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.tag=="Collider")
        {
            isGrounded=false;
        }
    }
    void Start()
    {

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)&&isGrounded==true)
        {
            body.velocity = Vector2.up * jumpforce;
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(runSpeed*Time.deltaTime,0,0);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(-runSpeed*Time.deltaTime,0,0);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            var obj = Instantiate(bullet,transform.position, Quaternion.identity) as GameObject;
            obj.GetComponent<Bullet>().isRight=isRight;
        }
    }
}
