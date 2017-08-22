using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnDeath : MonoBehaviour {



    [SerializeField]
    GameObject ObjToSpawn;

    [SerializeField]
    float DestroyDelay;



    void OnDestroy()
    {

        Destroy(Instantiate(ObjToSpawn,transform.position,Quaternion.identity),DestroyDelay);

    }

}
