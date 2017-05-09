using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PercentBDisplay : MonoBehaviour {

    private GameObject cube;

    private float percentB;

    private float percentBRemains;
    private int lastObject;


    // Use this for initialization
    void Start()
    {

        percentB = 27;

        percentB = percentB * 0.1f;

        percentBRemains = percentB % 1;


        Debug.Log(percentBRemains);

        int percentAint = (int)percentB;

        Debug.Log(percentAint);

        for (int i = 0; i < percentAint + 1; i++)
        {

			if (i == percentAint)
			{
				cube = Instantiate(Resources.Load("cube", typeof(GameObject))) as GameObject;
				cube.transform.localScale = new Vector3(0.7f, percentBRemains, 0.7f);
				cube.transform.position = new Vector3(0, i-0.3f, 0.7f);
			}
			else
			{
				cube = Instantiate(Resources.Load("cube", typeof(GameObject))) as GameObject;
				cube.transform.position = new Vector3(0.7f, 0 + i-0.3f, 0.7f);
			}




        }

    }

        // Update is called once per frame
        void Update () {
		
	}
}
