
using UnityEngine.UI;
using UnityEngine;
public class NameText : MonoBehaviour
{


    static public string userIDs;


    // Start is called before the first frame update
    public void NameTexter(string s)
    {
        userIDs = s;

        Debug.Log(userIDs);
        Debug.Log("Value Changed");

    }


}
