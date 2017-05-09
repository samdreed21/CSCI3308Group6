using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AverageCourseRatingDisplay : MonoBehaviour {

    // Use this for initialization

    private Material mountainSkybox;
    private Material alienSkybox;
    private Material beachSkybox;
    private Material citySkybox;
    private Material hellSkybox;
    private Material nukeSkybox;
    private Material plagueSkybox;

    private Material nebulaSkybox;

    private float courseRating;
    private GameObject courseRatingChart;



    void Start () {

		courseRating = float.Parse(CMySql.result1);


        mountainSkybox = Resources.Load("Skyboxes/PeacefulSkybox", typeof(Material)) as Material;
        alienSkybox = Resources.Load("Skyboxes/AlienSkybox", typeof(Material)) as Material;
        beachSkybox = Resources.Load("Skyboxes/BeachSkybox", typeof(Material)) as Material;
        citySkybox = Resources.Load("Skyboxes/CitySkybox", typeof(Material)) as Material;
        hellSkybox = Resources.Load("Skyboxes/HellSkybox", typeof(Material)) as Material;
        nukeSkybox = Resources.Load("Skyboxes/NukeSkybox", typeof(Material)) as Material;
        plagueSkybox = Resources.Load("Skyboxes/Plague", typeof(Material)) as Material;
        nebulaSkybox = Resources.Load("Skyboxes/NebulaSkybox", typeof(Material)) as Material;

        if (courseRating <= 1 && courseRating >2)
        {
            RenderSettings.skybox = hellSkybox;

        }
        else if (courseRating >= 2 && courseRating < 3)
        {
            RenderSettings.skybox = nukeSkybox;

        }
        else if (courseRating >= 3 && courseRating < 4)
        {
            RenderSettings.skybox = alienSkybox;

        }
        else if (courseRating >= 4 && courseRating < 5)
        {
            RenderSettings.skybox = mountainSkybox;

        }
        else if (courseRating >= 5 && courseRating < 6)
        {
            RenderSettings.skybox = beachSkybox;

        }
        else 
        {
            RenderSettings.skybox = nebulaSkybox;
        }




    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
