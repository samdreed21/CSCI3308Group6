using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumEnrolledDisplay : MonoBehaviour {

    // Use this for initialization

    private GameObject cube;
	private float NumberEnroll;
	void Start () {
		NumberEnroll = float.Parse(CMySql.result1);
		for (int i = 0; i < NumberEnroll; i++)
        {
            float x = Random.Range(0, 0.2f);

			cube = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            cube.transform.position = new Vector3(0.038f, i, 0.84f);
            cube.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            
            cube.AddComponent<Rigidbody>();

        }




    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
