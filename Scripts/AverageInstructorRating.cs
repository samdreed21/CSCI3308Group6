using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AverageInstructorRating : MonoBehaviour {

    // Use this for initialization

    private float instructorRating;

    private GameObject star;

    private float instructorRatingLeftover;



    void Start () {

        instructorRating = 5.5f;
        int instructorRatingint = (int)instructorRating;

        //instructorRating = instructorRating * 0.1f;

        instructorRatingLeftover = instructorRating % 1;


        Debug.Log(instructorRatingLeftover);

        

        Debug.Log(instructorRatingint);


        //if (instructorRating <= 1 && instructorRating > 2)
       // {

            for (int i = 0; i < instructorRatingint+1; i++)
            {

                if (i == instructorRatingint)
                {
                    star = Instantiate(Resources.Load("star", typeof(GameObject))) as GameObject;
                    star.transform.localScale = new Vector3(instructorRatingLeftover*0.002f, 0.002f , 0.002f);
				star.transform.position = new Vector3(-1.815f+i, star.transform.position.y, star.transform.position.z);

                }
                else
                {
                    star = Instantiate(Resources.Load("star", typeof(GameObject))) as GameObject;
				star.transform.position = new Vector3(-1.815f+i, star.transform.position.y, star.transform.position.z);
                }




            }


        //}
       /* else if (instructorRating >= 2 && instructorRating < 3)
        {

        }
        else if (instructorRating >= 3 && instructorRating < 4)
        {

        }
        else if (instructorRating >= 4 && instructorRating < 5)
        {

        }
        else if (instructorRating >= 5 && instructorRating < 6)
        {

        }
        else
        {

        }
        */



    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
