using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class nextYear : MonoBehaviour {

    public year year;
    public dollars dollars;
    public UnityEngine.UI.Text dollarDisplay;
    public UnityEngine.UI.Text yearDisplay;
    

    public void ChangeYear()
    {
        if (year.currentyear == 50)
        {
            dollars.dollarUpdate();
            SceneManager.LoadScene("End Game", LoadSceneMode.Single);
            
            
        }
        else
        {
            year.currentyear += 1;
            dollars.dollarsOwned += 1000;
            dollars.dollarUpdate();

        }

        

    }


    
}
