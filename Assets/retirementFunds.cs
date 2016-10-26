using UnityEngine;
using System.Collections;

public class retirementFunds : MonoBehaviour {

    public UnityEngine.UI.Text retirementMoney;
    float money;

    public void Start()
    {
        money = PlayerPrefs.GetFloat("totalInvestment");
        retirementMoney.text = "Retirement Funds: $" + money;
    }

    
}
