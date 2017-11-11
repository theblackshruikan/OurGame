using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadGame : MonoBehaviour {
    public GameObject[] bandNames;
    public GameObject[] progressions;
    public GameObject[] playTimes;
    public GameObject[] dates;

    // Use this for initialization
    void Start () {
        bandNames = GameObject.FindGameObjectsWithTag("BandName");
        progressions = GameObject.FindGameObjectsWithTag("Progression");
        playTimes = GameObject.FindGameObjectsWithTag("PlayTime");
        dates = GameObject.FindGameObjectsWithTag("Date");

        foreach (GameObject bandName in bandNames)
        {
            bandName.GetComponent<Text>().text = "Band Name:";
        }
        foreach (GameObject progression in progressions)
        {
            progression.GetComponent<Text>().text = "Progression: ";
        }
        foreach (GameObject playTime in playTimes)
        {
            playTime.GetComponent<Text>().text = "Play time: ";
        }
        foreach (GameObject date in dates)
        {
            date.GetComponent<Text>().text = "Date: ";
        }
    }

    // Update is called once per frame
    void Update ()
    {

    }
}