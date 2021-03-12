using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RotatorSpeed : MonoBehaviour
{
    public static float rotatorSpeed = 0;


    public void Change(float f)
    {

        if (f == 0)
        {
            Debug.Log("1");
            GetComponent<Text>().text = "Slow";
            rotatorSpeed = 0;
        }
        else
        {
            GetComponent<Text>().text = "Fast";
            rotatorSpeed = 75;
        }

    }

}
