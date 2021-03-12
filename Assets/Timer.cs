

using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    Dropdown m_Dropdown;
    static public int timer;
    static public string timer1;
    //public Text m_Text;
    int m_DropdownValue;

    void Start()
    {
        m_Dropdown = GetComponent<Dropdown>();
    }

    void Update()
    {
        m_DropdownValue = m_Dropdown.value;
        timer1 = m_Dropdown.options[m_DropdownValue].text;
        timer = int.Parse(timer1);

    }
}