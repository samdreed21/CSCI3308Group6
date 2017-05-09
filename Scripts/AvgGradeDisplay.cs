using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvgGradeDisplay : MonoBehaviour {


    private GameObject A;
    private GameObject Aminus;
    private GameObject Bplus;
    private GameObject B;
    private GameObject Bminus;
    private GameObject Cplus;


    private float AvgGrade;



    // Use this for initialization
    void Start () {








    }
	
	// Update is called once per frame
	void Update () {



		//AvgGrade = 2.4f;


		A = GameObject.Find("A");
		A.SetActive(true);



		if(AvgGrade >= 3.7f && AvgGrade <= 4)
		{
			//A
			A = GameObject.Find("A");
			A.SetActive(true);

		}
		else if (AvgGrade >= 3.3f && AvgGrade < 3.7f)
		{
			//A-
			Aminus = GameObject.Find("Aminus");
			Aminus.SetActive (true);
		}
		else if (AvgGrade >= 3 && AvgGrade < 3.3f)
		{
			//B+
			Bplus = GameObject.Find("Bplus");
			Bplus.SetActive (true);
		}
		else if (AvgGrade >= 2.7f && AvgGrade < 3)
		{
			//B
			B = GameObject.Find("B");
			B.SetActive (true);
		}
		else if (AvgGrade >= 2.3f && AvgGrade < 2.7f)
		{
			//B-
			Bminus = GameObject.Find("Bminus");
			Bminus.SetActive (true);

		}
		else if (AvgGrade >= 2 && AvgGrade < 2.3f)
		{
			//C+
			Cplus = GameObject.Find("Cplus");
			Cplus.SetActive (true);
		}
		else
		{

		}




		
	}
}
