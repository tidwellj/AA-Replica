using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[System.Serializable]
public class SaveJson : MonoBehaviour
{

    static public bool expo2;
    static public int altScore = 0;
    static public int altLives;


    [System.Serializable]
    public class MyClass
    {
       
        
        public string playerName;
        public float pinSpeed;
        public float rotatorSpeed;
        public int lives;
        public int score;
        public float time;
       // public int music;
        

    }
    public   SaveJson.MyClass myObject = new SaveJson.MyClass();
    public void Start()
    {



    }

    public void SavvIt()
    {
        myObject.playerName = NameText.userIDs;
        myObject.score = Score.PinCount;
        myObject.rotatorSpeed = RotatorSpeed.rotatorSpeed;
        myObject.lives = GameManager.lives;
        myObject.time = TimeSlider.timeSlider;
       // myObject.music = Toggles.tog;
        Debug.Log(myObject.playerName);
       
        var json = JsonUtility.ToJson(myObject);
        
        Debug.Log(myObject.score);
        PlayerPrefs.SetString("Save", json);
       
        PlayerPrefs.Save();
        expo2 = false;
    }

    public void LoadIt()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        string json = PlayerPrefs.GetString("Save");
       
        myObject = JsonUtility.FromJson<SaveJson.MyClass>(json);
      

      /* 
        Debug.Log(myObject.playerName);
        Debug.Log(myObject.score);
        PlayerPrefs.SetString("Name", myObject.playerName);
        PlayerPrefs.SetInt("score", myObject.score);
        PlayerPrefs.SetFloat("rotatorspeed", myObject.rotatorSpeed);
        PlayerPrefs.SetInt("lives", myObject.lives);
        PlayerPrefs.SetFloat("pinspeed", myObject.pinSpeed);
        PlayerPrefs.SetFloat("time", myObject.time);
      */

        NameText.userIDs = myObject.playerName;
        Score.PinCount = myObject.score;
        altScore = myObject.score;
        RotatorSpeed.rotatorSpeed = myObject.rotatorSpeed;
        GameManager.lives = myObject.lives;
        altLives = myObject.lives;

        PinSpeed.pinSpeed = myObject.pinSpeed;
        //expo6 = myObject.music;
        PlayerPrefs.Save();
        
        expo2 = true;
    }
   
    
}
