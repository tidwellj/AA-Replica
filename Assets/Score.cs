using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int PinCount;
    public Text text;
    public int score = 0;
    void Start()
    {
        PinCount = 0;   
    }

    private void Update()
    {
        if (SaveBinary.loaded == 1)
        {
            score = (SaveBinary.score2 + PinCount);
            text.text = score.ToString();

        }
        else if(SaveJson.expo2 == true)
        {
            score = ((int)(SaveJson.altScore + PinCount));
            text.text = score.ToString();
        }
        else
        {
            text.text = PinCount.ToString();
        
        }
    }


}
