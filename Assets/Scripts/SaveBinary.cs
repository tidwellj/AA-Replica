using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public class SaveBinary : MonoBehaviour
{
    public static int loaded = 0;
    public static int newLives = 0;
    public static int score2 = 0;

    private Save CreateSaveGameObject()
    {

        Save save = new Save();
        save.name = NameText.userIDs;
        save.time = TimeSlider.timeSlider;
        save.lives = GameManager.lives;
        save.pSpeed = PinSpeed.pinSpeed;
        save.rSpeed = RotatorSpeed.rotatorSpeed;
        save.score = Score.PinCount;
        return save;
    }


    public void SaveGame()
    {
        Save save = CreateSaveGameObject();
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/Savegame.save");
        bf.Serialize(file, save);
        file.Close();

    }

    public void LoadGame()
    {
        if (File.Exists(Application.persistentDataPath + "/Savegame.save"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/savegame.save", FileMode.Open);
            Save save = (Save)bf.Deserialize(file);
            file.Close();
            //TimeManager.timeRemaining = save.timeRemain
            NameText.userIDs = save.name;
            TimeSlider.timeSlider = save.time;
            PinSpeed.pinSpeed = save.pSpeed;
            GameManager.lives = save.lives;
            newLives = save.lives;
            RotatorSpeed.rotatorSpeed = save.rSpeed;
            Score.PinCount = save.score;
            Debug.Log(Score.PinCount + "yarp");
            score2 = save.score;
           // Debug.Log(NameText.userIDs);
            loaded = 1;
        }
    }

}
