using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeLimit: MonoBehaviour
{
    public Text text;
    public static float rounded = 0f;
    public  static float timeLeft = 30f;
    //public bool timerIsRunning = false;
    private void Start()
    {


    }


    void FixedUpdate()
    {


        rounded = Mathf.RoundToInt(timeLeft -= Time.fixedDeltaTime);
        rounded = rounded + TimeSlider.timeSlider;
        if (timeLeft > 0)
        {
            text.text = rounded.ToString();
        }
        else
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}