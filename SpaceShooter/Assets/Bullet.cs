using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {


    public float AttackDam = 10;
    public float Speed = 10;

    public string FilterTag;

	// Use this for initialization
	void Update () {

        GetComponent<Rigidbody2D>().velocity += (Vector2)transform.up * Speed * Time.deltaTime;
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
       if( collision.gameObject.tag  != FilterTag)
        {
            collision.gameObject.SendMessage("DamMe",AttackDam);
        }

    }




}
