using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeSlider : MonoBehaviour
{
    public static float timeSlider = 0;


    public void Change(float f)
    {

        if (f == 0)
        {
            Debug.Log("1");
            GetComponent<Text>().text = "30 Seconds";
            timeSlider = 0;
        }
        else
        {
            GetComponent<Text>().text = "60 Seconds";
            timeSlider = 30;
        }

    }

}
