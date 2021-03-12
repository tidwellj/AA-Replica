using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PinSpeed : MonoBehaviour
{
    public static float pinSpeed = 0;


    public void Change(float f)
    {

        if (f == 0)
        {
            Debug.Log("1");
            GetComponent<Text>().text = "Slow";
            pinSpeed = 0;
        }
        else
        {
            GetComponent<Text>().text = "Fast";
            pinSpeed = 20;
        }

    }

}
