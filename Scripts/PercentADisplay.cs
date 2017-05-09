using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PercentADisplay : MonoBehaviour {


    private GameObject cube;

    private float percentA;

    private float percentARemains;
    private int lastObject;


    // Use this for initialization
    void Start () {

        percentA = 39;

        percentA = percentA * 0.1f;

        percentARemains = percentA % 1;


        Debug.Log(percentARemains);

        int percentAint = (int)percentA;

        Debug.Log(percentAint);

        for (int i = 0; i < percentAint+1; i++)
        {

            if (i == percentAint)
            {
                cube = Instantiate(Resources.Load("cube", typeof(GameObject))) as GameObject;
				cube.transform.localScale = new Vector3(0.7f, percentARemains, 0.7f);
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
