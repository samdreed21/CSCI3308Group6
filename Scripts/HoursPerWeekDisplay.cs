using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoursPerWeekDisplay : MonoBehaviour {

    private string hoursPerWeek;

    private GameObject Book;
    private GameObject Book2;
    private GameObject Book3;
    private GameObject Book4;
    private GameObject Book5;
    private GameObject Book6;
    private GameObject Book7;
    private GameObject Book8;
    private GameObject Book9;
    private GameObject Book10;
    private GameObject Book11;
    private GameObject Book12;

    private GameObject Hours4to6;
    private GameObject Hours7to9;
    private GameObject Hours10to12;




    void Start()
    {
 
		hoursPerWeek = CMySql.result1;

        if (hoursPerWeek == "46")
        {
            Hours4to6 = Instantiate(Resources.Load("Hours4-6", typeof(GameObject))) as GameObject;

            Book = Instantiate(Resources.Load("Book", typeof(GameObject))) as GameObject;
            Book2 = Instantiate(Resources.Load("Book", typeof(GameObject))) as GameObject;
            Book3 = Instantiate(Resources.Load("Book", typeof(GameObject))) as GameObject;
            Book4 = Instantiate(Resources.Load("Book", typeof(GameObject))) as GameObject;
            Book5 = Instantiate(Resources.Load("Book", typeof(GameObject))) as GameObject;
            Book6 = Instantiate(Resources.Load("Book", typeof(GameObject))) as GameObject;


            Book.transform.position = new Vector3(1, 1, 1);
            Book2.transform.position = new Vector3(1, 4, 1);
            Book3.transform.position = new Vector3(1, 8, 1);
            Book4.transform.position = new Vector3(1, 12, 1);
            Book5.transform.position = new Vector3(1, 16, 1);
            Book6.transform.position = new Vector3(1, 20, 1);


        }
        else if (hoursPerWeek == "79")
        {

            Hours7to9 = Instantiate(Resources.Load("Hours7-9", typeof(GameObject))) as GameObject;

            Book = Instantiate(Resources.Load("Book", typeof(GameObject))) as GameObject;
            Book2 = Instantiate(Resources.Load("Book", typeof(GameObject))) as GameObject;
            Book3 = Instantiate(Resources.Load("Book", typeof(GameObject))) as GameObject;
            Book4 = Instantiate(Resources.Load("Book", typeof(GameObject))) as GameObject;
            Book5 = Instantiate(Resources.Load("Book", typeof(GameObject))) as GameObject;
            Book6 = Instantiate(Resources.Load("Book", typeof(GameObject))) as GameObject;
            Book7 = Instantiate(Resources.Load("Book", typeof(GameObject))) as GameObject;
            Book8 = Instantiate(Resources.Load("Book", typeof(GameObject))) as GameObject;
            Book9 = Instantiate(Resources.Load("Book", typeof(GameObject))) as GameObject;


            Book.transform.position = new Vector3(1, 1, 1);
            Book2.transform.position = new Vector3(1, 4, 1);
            Book3.transform.position = new Vector3(1, 8, 1);
            Book4.transform.position = new Vector3(1, 12, 1);
            Book5.transform.position = new Vector3(1, 16, 1);
            Book6.transform.position = new Vector3(1, 20, 1);
            Book7.transform.position = new Vector3(1, 24, 1);
            Book8.transform.position = new Vector3(1, 28, 1);
            Book9.transform.position = new Vector3(1, 32, 1);




        }
        else if (hoursPerWeek == "1012")
        {
            Hours10to12 = Instantiate(Resources.Load("Hours10-12", typeof(GameObject))) as GameObject;

            Book = Instantiate(Resources.Load("Book", typeof(GameObject))) as GameObject;
            Book2 = Instantiate(Resources.Load("Book", typeof(GameObject))) as GameObject;
            Book3 = Instantiate(Resources.Load("Book", typeof(GameObject))) as GameObject;
            Book4 = Instantiate(Resources.Load("Book", typeof(GameObject))) as GameObject;
            Book5 = Instantiate(Resources.Load("Book", typeof(GameObject))) as GameObject;
            Book6 = Instantiate(Resources.Load("Book", typeof(GameObject))) as GameObject;
            Book7 = Instantiate(Resources.Load("Book", typeof(GameObject))) as GameObject;
            Book8 = Instantiate(Resources.Load("Book", typeof(GameObject))) as GameObject;
            Book9 = Instantiate(Resources.Load("Book", typeof(GameObject))) as GameObject;
            Book10 = Instantiate(Resources.Load("Book", typeof(GameObject))) as GameObject;
            Book11 = Instantiate(Resources.Load("Book", typeof(GameObject))) as GameObject;
            Book12 = Instantiate(Resources.Load("Book", typeof(GameObject))) as GameObject;

            Book.transform.position = new Vector3(1, 1, 1);
            Book2.transform.position = new Vector3(1, 4, 1);
            Book3.transform.position = new Vector3(1, 8, 1);
            Book4.transform.position = new Vector3(1, 12, 1);
            Book5.transform.position = new Vector3(1, 16, 1);
            Book6.transform.position = new Vector3(1, 20, 1);
            Book7.transform.position = new Vector3(1, 24, 1);
            Book8.transform.position = new Vector3(1, 28, 1);
            Book9.transform.position = new Vector3(1, 32, 1);
            Book10.transform.position = new Vector3(1, 36, 1);
            Book11.transform.position = new Vector3(1, 40, 1);
            Book12.transform.position = new Vector3(1, 44, 1);

        }
        else
        {

        }



    }

    // Update is called once per frame
    void Update () {
		
	}
}
