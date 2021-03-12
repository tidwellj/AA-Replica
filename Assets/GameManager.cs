using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;
    public Rotator rotator;
    public Spawner spawner;
    public Animator animator;
    public static int lives = DropD1.lives - 1;


    public void Update()
    {

    }
    public void EndGame()
    {
        if (gameHasEnded)
            return;

        rotator.enabled = false;
        spawner.enabled = false;
        animator.SetTrigger("EndGame");
        gameHasEnded = true;


    }

    public void RestartLevel()
    {








        if (lives > 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            lives--;

        }
        else if (lives == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            if (SaveBinary.loaded == 1)
            {
                lives = SaveBinary.newLives;
            }
            else if(SaveJson.expo2 == true)
            {
                lives = SaveJson.altLives;
            }
            else
            {
                lives = DropD1.lives - 1;
            }
        }




    }
}
