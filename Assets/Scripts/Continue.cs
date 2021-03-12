using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continue : MonoBehaviour
{
    public GameObject Panel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        Time.timeScale = 1;
        Panel.gameObject.SetActive(false);
        Visible.staTe = 0;

    }
}
