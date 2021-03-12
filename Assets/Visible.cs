using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Visible : MonoBehaviour
{

    static public int staTe = 0;
    public GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {

        Panel.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        if ((Input.GetKeyDown("space")) && (staTe == 0))
        {

            Panel.gameObject.SetActive(true);

            Time.timeScale = 0;
            staTe = 1;




        }
        else if ((Input.GetKeyDown("space")) && (staTe == 1))
        {
            Time.timeScale = 1;
            staTe = 0;
            Panel.gameObject.SetActive(false);


        }
    }
}
