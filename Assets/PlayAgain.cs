using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayAgainPin()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        //DropD1.lives = DropD1.lives;
        //Score.CurrentScore = 0;
        TimeLimit.timeLeft = 30f;

    }



}
