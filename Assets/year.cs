using UnityEngine;
using System.Collections;

public class year : MonoBehaviour {

    public UnityEngine.UI.Text yearDisplay;
    public int currentyear = 1;

    void Update()
    {
        yearDisplay.text = "Year: " + currentyear;
    }
}
