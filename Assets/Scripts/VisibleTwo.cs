using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisibleTwo : MonoBehaviour
{

    static public int staTe = 0;
    public GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {

        Panel.gameObject.SetActive(false);

    }

    // Update is called once per frame
    public void ClickHelp()
    {




        Panel.gameObject.SetActive(true);

        staTe = 1;


    }

        public void CLickHelpClose()
        {
            staTe = 0;
            Panel.gameObject.SetActive(false);


        }
    
}
