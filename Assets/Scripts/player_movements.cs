using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movements : MonoBehaviour
{
   public float speed;
   private Rigidbody2D _rb;

    private void Start() {
        _rb = GetComponent<Rigidbody2D>();

    }
    // Hello Wor

    private void FixedUpdate(){
        if(Input.GetAxis("Horizontal") < 0){
            _rb.velocity = new Vector2(-5f, 0f) * speed * Time.deltaTime;

        }else if(Input.GetAxis("Horizontal") > 0){
            _rb.velocity = new Vector2(5f, 0f) * speed * Time.deltaTime;

        }else if(Input.GetAxis("Vertical") < 0){
            _rb.velocity = new Vector2(0f, -5f) * speed * Time.deltaTime;

        }else if(Input.GetAxis("Vertical") > 0){
            _rb.velocity = new Vector2(0f, 5f) * speed * Time.deltaTime;

        }
    }
}
