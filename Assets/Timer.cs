using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{
    //jag lade till "UniteEngine.UI;" på rad 3 för att se till så att UI mekanism kan användas och ändras
    public Text TimerText;
    public float StartTime;


	// Use this for initialization
	void Start ()
    {
        StartTime = Time.time;
        //ser till så att StartTimevarieblen börjar på noll

    }
	
	// Update is called once per frame
	void Update ()
    {
        float t = StartTime + Time.time;
        // ser till så att "t" får ett värde som är StartTiden plus Tiden som har gått
        string minutes = ((int)t / 60).ToString();
        // ger "minutes" ett värde som är 60 "t":n... Hur många minuter som som har gått
        string seconds = (t % 60).ToString("f2");
        // hur många sekunder som har gått
        TimerText.text = minutes + ":" + seconds;
        //ser till så att minutvisaren visas
	}
}
