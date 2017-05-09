using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class disableButton : MonoBehaviour {



    //Define all buttons and their toggle component

    private UnityEngine.UI.Toggle csciToggle;
    private UnityEngine.UI.Toggle mathToggle;
    private UnityEngine.UI.Toggle socyToggle;

    private GameObject csci;
    private GameObject math;
    private GameObject socy;

    private GameObject Math1071;
    private GameObject CS1300;

    private UnityEngine.UI.Toggle Math1071Toggle;
    private UnityEngine.UI.Toggle CS1300Toggle;

    private GameObject Math2300;
    private GameObject CS3155;
    private GameObject Soc1016;

    private UnityEngine.UI.Toggle Math2300Toggle;
    private UnityEngine.UI.Toggle CS3155Toggle;
    private UnityEngine.UI.Toggle Soc1016Toggle;

    private GameObject Math2001;
    private GameObject CS3308;
    private GameObject Soc3024;

    private UnityEngine.UI.Toggle Math2001Toggle;
    private UnityEngine.UI.Toggle CS3308Toggle;
    private UnityEngine.UI.Toggle Soc3024Toggle;

    private GameObject Math3130;
    private GameObject Math4430;
    private GameObject CS4229;
    private GameObject Soc2034;
    private GameObject Soc3011;

    private UnityEngine.UI.Toggle Math3130Toggle;
    private UnityEngine.UI.Toggle Math4430Toggle;
    private UnityEngine.UI.Toggle CS4229Toggle;
    private UnityEngine.UI.Toggle Soc2034Toggle;
    private UnityEngine.UI.Toggle Soc3011Toggle;

    private GameObject CS4273;
    private GameObject Soc3041;

    private UnityEngine.UI.Toggle CS4273Toggle;
    private UnityEngine.UI.Toggle Soc3041Toggle;

    private GameObject dataToDisplayText;
    private GameObject CourseNumberButtons;

    private UnityEngine.UI.Button reset;

    private bool pressed;

    private GameObject AvgGrade;
    private GameObject NumEnrolled;
    private GameObject PercentA;
    private GameObject PercentB;
    private GameObject HoursPerWeek;
    private GameObject AverageCourseRating;
    private GameObject AverageInstructorRating;

    private UnityEngine.UI.Toggle AvgGradeToggle;
    private UnityEngine.UI.Toggle NumEnrolledToggle;
    private UnityEngine.UI.Toggle PercentAToggle;
    private UnityEngine.UI.Toggle PercentBToggle;
    private UnityEngine.UI.Toggle HoursPerWeekToggle;
    private UnityEngine.UI.Toggle AverageCourseRatingToggle;
    private UnityEngine.UI.Toggle AverageInstructorRatingToggle;

    private GameObject courseRatingChart;

	private GameObject A;
	private GameObject Aminus;
	private GameObject Bplus;
	private GameObject B;
	private GameObject Bminus;
	private GameObject Cplus;
	private GameObject C;

	private GameObject numenr;





    // Use this for initialization
    void Start () {

        //courseRatingChart = GameObject.Find("CourseRatingText");
        //courseRatingChart.SetActive(false);




        //Get buttons as a GameObject so that we can enable and disable it
        csci = GameObject.Find("CSCI");
        math = GameObject.Find("MATH");
        socy = GameObject.Find("SOCY");

        //Get the toggle component of each button so we can check whether it isOn or off
        csciToggle = csci.GetComponent<UnityEngine.UI.Toggle>();
        mathToggle = math.GetComponent<UnityEngine.UI.Toggle>();
        socyToggle = socy.GetComponent<UnityEngine.UI.Toggle>();


        Math1071 = GameObject.Find("1071Math");
        CS1300 = GameObject.Find("1300CS");

        Math1071Toggle = Math1071.GetComponent<UnityEngine.UI.Toggle>();
        CS1300Toggle = CS1300.GetComponent<UnityEngine.UI.Toggle>();

        Math2300 = GameObject.Find("2300Math");
        CS3155 = GameObject.Find("3155CS");
        Soc1016 = GameObject.Find("1016Soc");

        Math2300Toggle = Math2300.GetComponent<UnityEngine.UI.Toggle>();
        CS3155Toggle = CS3155.GetComponent<UnityEngine.UI.Toggle>();
        Soc1016Toggle = Soc1016.GetComponent<UnityEngine.UI.Toggle>();

        Math2001 = GameObject.Find("2001Math");
        CS3308 = GameObject.Find("3308CS");
        Soc3024 = GameObject.Find("3042Soc");

        Math2001Toggle = Math2001.GetComponent<UnityEngine.UI.Toggle>();
        CS3308Toggle = CS3308.GetComponent<UnityEngine.UI.Toggle>();
        Soc3024Toggle = Soc3024.GetComponent<UnityEngine.UI.Toggle>();


        Math3130 = GameObject.Find("3130Math");
        Math4430 = GameObject.Find("4430Math");
        CS4229 = GameObject.Find("4229CS");
        Soc2034 = GameObject.Find("2034Soc");
        Soc3011 = GameObject.Find("3011Soc");

        Math3130Toggle = Math3130.GetComponent<UnityEngine.UI.Toggle>();
        Math4430Toggle = Math4430.GetComponent<UnityEngine.UI.Toggle>();
        CS4229Toggle = CS4229.GetComponent<UnityEngine.UI.Toggle>();
        Soc2034Toggle = Soc2034.GetComponent<UnityEngine.UI.Toggle>();
        Soc3011Toggle = Soc3011.GetComponent<UnityEngine.UI.Toggle>();

        CS4273 = GameObject.Find("4273CS");
        Soc3041 = GameObject.Find("3041Soc");

        CS4273Toggle = CS4273.GetComponent<UnityEngine.UI.Toggle>();
        Soc3041Toggle = Soc3041.GetComponent<UnityEngine.UI.Toggle>();

        dataToDisplayText = GameObject.Find("DataToDisplay");


        CourseNumberButtons = GameObject.Find("CourseNumberButtons");
        CourseNumberButtons.SetActive(false);

        reset = GameObject.Find("Reset").GetComponent<UnityEngine.UI.Button>();

        reset.onClick.AddListener(ResetButtons); // Listen for if the reset button is pressed, if it is then call ResetButtons function

        AvgGrade = GameObject.Find("AvgGrade");
        NumEnrolled = GameObject.Find("NumEnrolled");
        PercentA = GameObject.Find("PercentA");
        PercentB = GameObject.Find("PercentB");
        HoursPerWeek = GameObject.Find("HoursPerWeek");
        AverageCourseRating = GameObject.Find("AverageCourseRating");
        AverageInstructorRating = GameObject.Find("AverageInstructorRating");

        AvgGradeToggle = AvgGrade.GetComponent<UnityEngine.UI.Toggle>();
        NumEnrolledToggle = NumEnrolled.GetComponent<UnityEngine.UI.Toggle>();
        PercentAToggle = PercentA.GetComponent<UnityEngine.UI.Toggle>();
        PercentBToggle = PercentB.GetComponent<UnityEngine.UI.Toggle>();
        HoursPerWeekToggle = HoursPerWeek.GetComponent<UnityEngine.UI.Toggle>();
        AverageCourseRatingToggle = AverageCourseRating.GetComponent<UnityEngine.UI.Toggle>();
        AverageInstructorRatingToggle = AverageInstructorRating.GetComponent<UnityEngine.UI.Toggle>();
        

		A = GameObject.Find("A");
		A.SetActive (false);
		Aminus = GameObject.Find("Aminus");
		Aminus.SetActive (false);
		Bplus = GameObject.Find("Bplus");
		Bplus.SetActive (false);
		B = GameObject.Find("B");
		B.SetActive (false);
		Bminus = GameObject.Find("Bminus");
		Bminus.SetActive (false);
		Cplus = GameObject.Find("Cplus");
		Cplus.SetActive (false);
		C = GameObject.Find("C");
		C.SetActive (false);

		numenr = GameObject.Find ("NumEnrolledThing");
		numenr.SetActive (false);




    }



    void ResetButtons()
    {
        pressed = true;

    }



    // Update is called once per frame
    void Update()
    {


        if (!pressed) // if reset button has not been pressed
        {

            //Set all class buttons inactive to avoid someone pressing a class button before pressing the department button
            Math1071.SetActive(false);
            Math2300.SetActive(false);
            Math2001.SetActive(false);
            Math3130.SetActive(false);
            Math3130.SetActive(false);
            Math4430.SetActive(false);

            Soc1016.SetActive(false);
            Soc3024.SetActive(false);
            Soc2034.SetActive(false);
            Soc3011.SetActive(false);
            Soc3041.SetActive(false);

            CS1300.SetActive(false);
            CS3155.SetActive(false);
            CS3308.SetActive(false);
            CS4229.SetActive(false);
            CS4273.SetActive(false);

            AvgGrade.SetActive(false);
            NumEnrolled.SetActive(false);
            PercentA.SetActive(false);
            PercentB.SetActive(false);
            HoursPerWeek.SetActive(false);
            AverageCourseRating.SetActive(false);
            AverageInstructorRating.SetActive(false);

            dataToDisplayText.SetActive(false);

            if (csciToggle.isOn) //if csci buttton is on, disable all buttons not realated to csci courses
			{   CMySql.depatment="CSCI";
                CourseNumberButtons.SetActive(true);
                CS1300.SetActive(true);
                CS3155.SetActive(true);
                CS3308.SetActive(true);
                CS4229.SetActive(true);
                CS4273.SetActive(true);

                if (CS1300Toggle.isOn)// If one of the csci classes are pressed, disable the other csci classes
				{	CMySql.couresenumber= "1300";
					CS4229.SetActive(false);
                    CS3155.SetActive(false);
                    CS3308.SetActive(false);
                    CS4273.SetActive(false);
                    dataToDisplayText.SetActive(true);

                    AvgGrade.SetActive(true);
                    NumEnrolled.SetActive(true);
                    PercentA.SetActive(true);
                    PercentB.SetActive(true);
                    HoursPerWeek.SetActive(true);
                    AverageCourseRating.SetActive(true);
                    AverageInstructorRating.SetActive(true);

                    if (AvgGradeToggle.isOn)
                    {
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

						C.SetActive (true);


                    }
                    else if (NumEnrolledToggle.isOn)
					{   CMySql.special="Number_Enrolled";
						CMySql.main();
                        AvgGrade.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

						numenr.SetActive (true);
                    }
                    else if (PercentAToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (PercentBToggle.isOn)
					{  
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (HoursPerWeekToggle.isOn)
					{  CMySql.special="Hours_per_week";
						CMySql.main();
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (AverageCourseRatingToggle.isOn)
					{	CMySql.special="Average_Course_Rating";
						CMySql.main();
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (AverageInstructorRatingToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);

                    }
                    else
                    {
                        AvgGrade.SetActive(true);
                        NumEnrolled.SetActive(true);
                        PercentA.SetActive(true);
                        PercentB.SetActive(true);
                        HoursPerWeek.SetActive(true);
                        AverageCourseRating.SetActive(true);
                        AverageInstructorRating.SetActive(true);

                    }

                }
                else if (CS3155Toggle.isOn)
                {
                    CS1300.SetActive(false);
                    CS3308.SetActive(false);
                    CS4229.SetActive(false);
                    CS4273.SetActive(false);
                    dataToDisplayText.SetActive(true);

                    AvgGrade.SetActive(true);
                    NumEnrolled.SetActive(true);
                    PercentA.SetActive(true);
                    PercentB.SetActive(true);
                    HoursPerWeek.SetActive(true);
                    AverageCourseRating.SetActive(true);
                    AverageInstructorRating.SetActive(true);

                    if (AvgGradeToggle.isOn)
                    {
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (NumEnrolledToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);
                    }
                    else if (PercentAToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (PercentBToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (HoursPerWeekToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (AverageCourseRatingToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (AverageInstructorRatingToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);

                    }
                    else
                    {
                        AvgGrade.SetActive(true);
                        NumEnrolled.SetActive(true);
                        PercentA.SetActive(true);
                        PercentB.SetActive(true);
                        HoursPerWeek.SetActive(true);
                        AverageCourseRating.SetActive(true);
                        AverageInstructorRating.SetActive(true);

                    }


                }
                else if (CS3308Toggle.isOn)
                {
                    CS1300.SetActive(false);
                    CS3155.SetActive(false);
                    CS4229.SetActive(false);
                    CS4273.SetActive(false);
                    dataToDisplayText.SetActive(true);

                    AvgGrade.SetActive(true);
                    NumEnrolled.SetActive(true);
                    PercentA.SetActive(true);
                    PercentB.SetActive(true);
                    HoursPerWeek.SetActive(true);
                    AverageCourseRating.SetActive(true);
                    AverageInstructorRating.SetActive(true);

                    if (AvgGradeToggle.isOn)
                    {
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (NumEnrolledToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);
                    }
                    else if (PercentAToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (PercentBToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (HoursPerWeekToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (AverageCourseRatingToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (AverageInstructorRatingToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);

                    }
                    else
                    {
                        AvgGrade.SetActive(true);
                        NumEnrolled.SetActive(true);
                        PercentA.SetActive(true);
                        PercentB.SetActive(true);
                        HoursPerWeek.SetActive(true);
                        AverageCourseRating.SetActive(true);
                        AverageInstructorRating.SetActive(true);

                    }


                }
                else if (CS4229Toggle.isOn)
                {
                    CS1300.SetActive(false);
                    CS3155.SetActive(false);
                    CS3308.SetActive(false);
                    CS4273.SetActive(false);
                    dataToDisplayText.SetActive(true);

                    AvgGrade.SetActive(true);
                    NumEnrolled.SetActive(true);
                    PercentA.SetActive(true);
                    PercentB.SetActive(true);
                    HoursPerWeek.SetActive(true);
                    AverageCourseRating.SetActive(true);
                    AverageInstructorRating.SetActive(true);

                    if (AvgGradeToggle.isOn)
                    {
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (NumEnrolledToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);
                    }
                    else if (PercentAToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (PercentBToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (HoursPerWeekToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (AverageCourseRatingToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (AverageInstructorRatingToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);

                    }
                    else
                    {
                        AvgGrade.SetActive(true);
                        NumEnrolled.SetActive(true);
                        PercentA.SetActive(true);
                        PercentB.SetActive(true);
                        HoursPerWeek.SetActive(true);
                        AverageCourseRating.SetActive(true);
                        AverageInstructorRating.SetActive(true);

                    }

                }
                else if (CS4273Toggle.isOn)
                {
                    CS1300.SetActive(false);
                    CS3155.SetActive(false);
                    CS3308.SetActive(false);
                    CS4229.SetActive(false);
                    dataToDisplayText.SetActive(true);

                    AvgGrade.SetActive(true);
                    NumEnrolled.SetActive(true);
                    PercentA.SetActive(true);
                    PercentB.SetActive(true);
                    HoursPerWeek.SetActive(true);
                    AverageCourseRating.SetActive(true);
                    AverageInstructorRating.SetActive(true);

                    if (AvgGradeToggle.isOn)
                    {
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (NumEnrolledToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);
                    }
                    else if (PercentAToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (PercentBToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (HoursPerWeekToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (AverageCourseRatingToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (AverageInstructorRatingToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);

                    }
                    else
                    {
                        AvgGrade.SetActive(true);
                        NumEnrolled.SetActive(true);
                        PercentA.SetActive(true);
                        PercentB.SetActive(true);
                        HoursPerWeek.SetActive(true);
                        AverageCourseRating.SetActive(true);
                        AverageInstructorRating.SetActive(true);

                    }


                }
                else
                {
                    CS1300.SetActive(true);
                    CS3155.SetActive(true);
                    CS3308.SetActive(true);
                    CS4229.SetActive(true);
                    CS4273.SetActive(true);

                }


                math.SetActive(false);
                socy.SetActive(false);

                Math1071.SetActive(false);
                Math2300.SetActive(false);
                Math2001.SetActive(false);
                Math3130.SetActive(false);
                Math3130.SetActive(false);
                Math4430.SetActive(false);

                Soc1016.SetActive(false);
                Soc3024.SetActive(false);
                Soc2034.SetActive(false);
                Soc3011.SetActive(false);
                Soc3041.SetActive(false);


            }


            if (mathToggle.isOn)
            {
                CourseNumberButtons.SetActive(true);
                Math1071.SetActive(true);
                Math2300.SetActive(true);
                Math2001.SetActive(true);
                Math3130.SetActive(true);
                Math4430.SetActive(true);

                if (Math1071Toggle.isOn)
                {
                    Math2300.SetActive(false);
                    Math2001.SetActive(false);
                    Math3130.SetActive(false);
                    Math4430.SetActive(false);
                    dataToDisplayText.SetActive(true);

                    AvgGrade.SetActive(true);
                    NumEnrolled.SetActive(true);
                    PercentA.SetActive(true);
                    PercentB.SetActive(true);
                    HoursPerWeek.SetActive(true);
                    AverageCourseRating.SetActive(true);
                    AverageInstructorRating.SetActive(true);

                    if (AvgGradeToggle.isOn)
                    {
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (NumEnrolledToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);
                    }
                    else if (PercentAToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (PercentBToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (HoursPerWeekToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (AverageCourseRatingToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (AverageInstructorRatingToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);

                    }
                    else
                    {
                        AvgGrade.SetActive(true);
                        NumEnrolled.SetActive(true);
                        PercentA.SetActive(true);
                        PercentB.SetActive(true);
                        HoursPerWeek.SetActive(true);
                        AverageCourseRating.SetActive(true);
                        AverageInstructorRating.SetActive(true);

                    }


                }
                else if (Math2300Toggle.isOn)
                {
                    Math1071.SetActive(false);
                    Math2001.SetActive(false);
                    Math3130.SetActive(false);
                    Math4430.SetActive(false);
                    dataToDisplayText.SetActive(true);

                    AvgGrade.SetActive(true);
                    NumEnrolled.SetActive(true);
                    PercentA.SetActive(true);
                    PercentB.SetActive(true);
                    HoursPerWeek.SetActive(true);
                    AverageCourseRating.SetActive(true);
                    AverageInstructorRating.SetActive(true);

                    if (AvgGradeToggle.isOn)
                    {
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (NumEnrolledToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);
                    }
                    else if (PercentAToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (PercentBToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (HoursPerWeekToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (AverageCourseRatingToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (AverageInstructorRatingToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);

                    }
                    else
                    {
                        AvgGrade.SetActive(true);
                        NumEnrolled.SetActive(true);
                        PercentA.SetActive(true);
                        PercentB.SetActive(true);
                        HoursPerWeek.SetActive(true);
                        AverageCourseRating.SetActive(true);
                        AverageInstructorRating.SetActive(true);

                    }

                }
                else if (Math2001Toggle.isOn)
                {
                    Math1071.SetActive(false);
                    Math2300.SetActive(false);
                    Math3130.SetActive(false);
                    Math4430.SetActive(false);
                    dataToDisplayText.SetActive(true);

                    AvgGrade.SetActive(true);
                    NumEnrolled.SetActive(true);
                    PercentA.SetActive(true);
                    PercentB.SetActive(true);
                    HoursPerWeek.SetActive(true);
                    AverageCourseRating.SetActive(true);
                    AverageInstructorRating.SetActive(true);

                    if (AvgGradeToggle.isOn)
                    {
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (NumEnrolledToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);
                    }
                    else if (PercentAToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (PercentBToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (HoursPerWeekToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (AverageCourseRatingToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (AverageInstructorRatingToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);

                    }
                    else
                    {
                        AvgGrade.SetActive(true);
                        NumEnrolled.SetActive(true);
                        PercentA.SetActive(true);
                        PercentB.SetActive(true);
                        HoursPerWeek.SetActive(true);
                        AverageCourseRating.SetActive(true);
                        AverageInstructorRating.SetActive(true);

                    }

                }
                else if (Math3130Toggle.isOn)
                {
                    Math1071.SetActive(false);
                    Math2300.SetActive(false);
                    Math2001.SetActive(false);
                    Math4430.SetActive(false);
                    dataToDisplayText.SetActive(true);

                    AvgGrade.SetActive(true);
                    NumEnrolled.SetActive(true);
                    PercentA.SetActive(true);
                    PercentB.SetActive(true);
                    HoursPerWeek.SetActive(true);
                    AverageCourseRating.SetActive(true);
                    AverageInstructorRating.SetActive(true);

                    if (AvgGradeToggle.isOn)
                    {
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (NumEnrolledToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);
                    }
                    else if (PercentAToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (PercentBToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (HoursPerWeekToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (AverageCourseRatingToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (AverageInstructorRatingToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);

                    }
                    else
                    {
                        AvgGrade.SetActive(true);
                        NumEnrolled.SetActive(true);
                        PercentA.SetActive(true);
                        PercentB.SetActive(true);
                        HoursPerWeek.SetActive(true);
                        AverageCourseRating.SetActive(true);
                        AverageInstructorRating.SetActive(true);

                    }
                }
                else if (Math4430Toggle.isOn)
                {
                    Math1071.SetActive(false);
                    Math2300.SetActive(false);
                    Math2001.SetActive(false);
                    Math3130.SetActive(false);
                    dataToDisplayText.SetActive(true);

                    AvgGrade.SetActive(true);
                    NumEnrolled.SetActive(true);
                    PercentA.SetActive(true);
                    PercentB.SetActive(true);
                    HoursPerWeek.SetActive(true);
                    AverageCourseRating.SetActive(true);
                    AverageInstructorRating.SetActive(true);

                    if (AvgGradeToggle.isOn)
                    {
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (NumEnrolledToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);
                    }
                    else if (PercentAToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (PercentBToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (HoursPerWeekToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (AverageCourseRatingToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (AverageInstructorRatingToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);

                    }
                    else
                    {
                        AvgGrade.SetActive(true);
                        NumEnrolled.SetActive(true);
                        PercentA.SetActive(true);
                        PercentB.SetActive(true);
                        HoursPerWeek.SetActive(true);
                        AverageCourseRating.SetActive(true);
                        AverageInstructorRating.SetActive(true);

                    }

                }
                else
                {
                    Math1071.SetActive(true);
                    Math2300.SetActive(true);
                    Math2001.SetActive(true);
                    Math3130.SetActive(true);
                    Math4430.SetActive(true);




                }

                socy.SetActive(false);
                csci.SetActive(false);

                Soc1016.SetActive(false);
                Soc3024.SetActive(false);
                Soc2034.SetActive(false);
                Soc3011.SetActive(false);
                Soc3041.SetActive(false);

                CS1300.SetActive(false);
                CS3155.SetActive(false);
                CS3308.SetActive(false);
                CS4229.SetActive(false);
                CS4273.SetActive(false);

            }


            if (socyToggle.isOn)
            {
                CourseNumberButtons.SetActive(true);
                Soc1016.SetActive(true);
                Soc3024.SetActive(true);
                Soc2034.SetActive(true);
                Soc3011.SetActive(true);
                Soc3041.SetActive(true);

                if (Soc1016Toggle.isOn)
                {
                    Soc3024.SetActive(false);
                    Soc2034.SetActive(false);
                    Soc3011.SetActive(false);
                    Soc3041.SetActive(false);
                    dataToDisplayText.SetActive(true);

                    AvgGrade.SetActive(true);
                    NumEnrolled.SetActive(true);
                    PercentA.SetActive(true);
                    PercentB.SetActive(true);
                    HoursPerWeek.SetActive(true);
                    AverageCourseRating.SetActive(true);
                    AverageInstructorRating.SetActive(true);

                    if (AvgGradeToggle.isOn)
                    {
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

						B.SetActive (true);

                    }
                    else if (NumEnrolledToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);
                    }
                    else if (PercentAToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (PercentBToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (HoursPerWeekToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (AverageCourseRatingToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (AverageInstructorRatingToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);

                    }
                    else
                    {
                        AvgGrade.SetActive(true);
                        NumEnrolled.SetActive(true);
                        PercentA.SetActive(true);
                        PercentB.SetActive(true);
                        HoursPerWeek.SetActive(true);
                        AverageCourseRating.SetActive(true);
                        AverageInstructorRating.SetActive(true);

                    }


                }
                else if (Soc3024Toggle.isOn)
                {
                    Soc1016.SetActive(false);
                    Soc2034.SetActive(false);
                    Soc3011.SetActive(false);
                    Soc3041.SetActive(false);
                    dataToDisplayText.SetActive(true);

                    AvgGrade.SetActive(true);
                    NumEnrolled.SetActive(true);
                    PercentA.SetActive(true);
                    PercentB.SetActive(true);
                    HoursPerWeek.SetActive(true);
                    AverageCourseRating.SetActive(true);
                    AverageInstructorRating.SetActive(true);
                    if (AvgGradeToggle.isOn)
                    {
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (NumEnrolledToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);
                    }
                    else if (PercentAToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (PercentBToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (HoursPerWeekToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (AverageCourseRatingToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (AverageInstructorRatingToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);

                    }
                    else
                    {
                        AvgGrade.SetActive(true);
                        NumEnrolled.SetActive(true);
                        PercentA.SetActive(true);
                        PercentB.SetActive(true);
                        HoursPerWeek.SetActive(true);
                        AverageCourseRating.SetActive(true);
                        AverageInstructorRating.SetActive(true);

                    }

                }
                else if (Soc2034Toggle.isOn)
                {
                    Soc1016.SetActive(false);
                    Soc3024.SetActive(false);
                    Soc3011.SetActive(false);
                    Soc3041.SetActive(false);
                    dataToDisplayText.SetActive(true);

                    AvgGrade.SetActive(true);
                    NumEnrolled.SetActive(true);
                    PercentA.SetActive(true);
                    PercentB.SetActive(true);
                    HoursPerWeek.SetActive(true);
                    AverageCourseRating.SetActive(true);
                    AverageInstructorRating.SetActive(true);

                    if (AvgGradeToggle.isOn)
                    {
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (NumEnrolledToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);
                    }
                    else if (PercentAToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (PercentBToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (HoursPerWeekToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (AverageCourseRatingToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (AverageInstructorRatingToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);

                    }
                    else
                    {
                        AvgGrade.SetActive(true);
                        NumEnrolled.SetActive(true);
                        PercentA.SetActive(true);
                        PercentB.SetActive(true);
                        HoursPerWeek.SetActive(true);
                        AverageCourseRating.SetActive(true);
                        AverageInstructorRating.SetActive(true);

                    }

                }
                else if (Soc3011Toggle.isOn)
                {
                    Soc1016.SetActive(false);
                    Soc3024.SetActive(false);
                    Soc2034.SetActive(false);
                    Soc3041.SetActive(false);
                    dataToDisplayText.SetActive(true);

                    AvgGrade.SetActive(true);
                    NumEnrolled.SetActive(true);
                    PercentA.SetActive(true);
                    PercentB.SetActive(true);
                    HoursPerWeek.SetActive(true);
                    AverageCourseRating.SetActive(true);
                    AverageInstructorRating.SetActive(true);

                    if (AvgGradeToggle.isOn)
                    {
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (NumEnrolledToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);
                    }
                    else if (PercentAToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (PercentBToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (HoursPerWeekToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (AverageCourseRatingToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (AverageInstructorRatingToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);

                    }
                    else
                    {
                        AvgGrade.SetActive(true);
                        NumEnrolled.SetActive(true);
                        PercentA.SetActive(true);
                        PercentB.SetActive(true);
                        HoursPerWeek.SetActive(true);
                        AverageCourseRating.SetActive(true);
                        AverageInstructorRating.SetActive(true);

                    }

                }
                else if (Soc3041Toggle.isOn)
                {
                    Soc1016.SetActive(false);
                    Soc3024.SetActive(false);
                    Soc2034.SetActive(false);
                    Soc3011.SetActive(false);
                    dataToDisplayText.SetActive(true);

                    AvgGrade.SetActive(true);
                    NumEnrolled.SetActive(true);
                    PercentA.SetActive(true);
                    PercentB.SetActive(true);
                    HoursPerWeek.SetActive(true);
                    AverageCourseRating.SetActive(true);
                    AverageInstructorRating.SetActive(true);

                    if (AvgGradeToggle.isOn)
                    {
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (NumEnrolledToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);
                    }
                    else if (PercentAToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (PercentBToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);


                    }
                    else if (HoursPerWeekToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        AverageCourseRating.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (AverageCourseRatingToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageInstructorRating.SetActive(false);

                    }
                    else if (AverageInstructorRatingToggle.isOn)
                    {
                        AvgGrade.SetActive(false);
                        NumEnrolled.SetActive(false);
                        PercentA.SetActive(false);
                        PercentB.SetActive(false);
                        HoursPerWeek.SetActive(false);
                        AverageCourseRating.SetActive(false);

                    }
                    else
                    {
                        AvgGrade.SetActive(true);
                        NumEnrolled.SetActive(true);
                        PercentA.SetActive(true);
                        PercentB.SetActive(true);
                        HoursPerWeek.SetActive(true);
                        AverageCourseRating.SetActive(true);
                        AverageInstructorRating.SetActive(true);

                    }

                }
                else
                {
                    Soc1016.SetActive(true);
                    Soc3024.SetActive(true);
                    Soc2034.SetActive(true);
                    Soc3011.SetActive(true);
                    Soc3041.SetActive(true);


                }

                math.SetActive(false);
                csci.SetActive(false);

                CS1300.SetActive(false);
                CS3155.SetActive(false);
                CS3308.SetActive(false);
                CS4229.SetActive(false);
                CS4273.SetActive(false);

                Math1071.SetActive(false);
                Math2300.SetActive(false);
                Math2001.SetActive(false);
                Math3130.SetActive(false);
                Math4430.SetActive(false);


            }











        }
        else // If the reset button is pressed, turn off all buttons that were selected and disable them
        {
            SceneManager.LoadScene("DataVisual");

        }


		/*if()
		AvgGrade = 2.4f;


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
			 */





















    }


}
