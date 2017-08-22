using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField]
    float ShootingDelay = 2;

    float ShootingTimer;

    [SerializeField]
    float Health = 10;

    public GameObject bullet;


    public float speed = 1;


	// Use this for initialization
	void Start () {
		
	}
	


	// Update is called once per frame
	void Update () {

        ShootingTimer += Time.deltaTime;

        if(ShootingTimer > ShootingDelay)
        {
            Shoot();
        }

        transform.position += Vector3.down * speed * Time.deltaTime;



	}

    void Shoot()
    {
        GameObject myBullet = Instantiate(bullet,transform.Find("gra").position, transform.Find("gra").rotation);
        myBullet.transform.Rotate(0,0,180);
        myBullet.GetComponent<Bullet>().FilterTag = gameObject.tag;
        ShootingTimer = 0;
    }


    public void DamMe(float Dam)
    {
        Health -= Dam;

        if (Health <= 0)
        {
            KillMe();
        }
    }

    void KillMe()
    {
        Destroy(gameObject);
    }

}
