using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


    [SerializeField]
    float MoveSpeed = 1;

    
    [SerializeField]
    float Health = 100;

    public GameObject bullet;



    Vector2 MouseInWorld;

	// Use this for initialization
	void Start () {
		

	}


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }


    // Update is called once per frame
    void FixedUpdate () {
        MouseInWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        transform.position = Vector3.Lerp(transform.position, MouseInWorld,MoveSpeed);
    }




    void Shoot()
    {
       GameObject myBullet = Instantiate(bullet,transform.position,transform.rotation);
        myBullet.GetComponent<Bullet>().FilterTag = gameObject.tag;
    }

    public void DamMe(float Dam)
    {
        Health -= Dam;

        if(Health <= 0)
        {
            KillMe();
        }
    }

    void KillMe()
    {
        Destroy(gameObject);
    }
}
