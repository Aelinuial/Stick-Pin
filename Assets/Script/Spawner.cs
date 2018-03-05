using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject pinFrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            SpawnPin();
        }
	}

    void SpawnPin()
    {
        Instantiate(pinFrefab, transform.position, transform.rotation);
    }
}
