using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour {


    Transform target;

	// Use this for initialization
	void Awake () {

        target = GameObject.FindGameObjectWithTag("Player").transform;

	}
	

	// Update is called once per frame
	void Update () {

        transform.LookAt(target);

        

	}
}
