using UnityEngine;
using System.Collections;

public class dollars : MonoBehaviour {

    public UnityEngine.UI.Text totalInvestmentDisplay;
    public UnityEngine.UI.Text dollarsDisplay;
    public float dollarsOwned = 1000.00f;
    public float totalInvestments;
    public stockClick stock;
    public stockClick bond;
    public stockClick moneyMarket;
    public stockClick realEstate;
    public stockClick mattress;
    public stockClick options;
    public stockClick collectables;


    void Start()
    {
        dollarUpdate();
    }

    public void dollarUpdate()
    {
        dollarsDisplay.text = "Dollars: $" + dollarsOwned;
        totalInvestments = 0;
        totalInvestments += dollarsOwned;
        totalInvestments += stock.stockCost * stock.stock;
        totalInvestments += bond.stockCost * bond.stock;
        totalInvestments += moneyMarket.stockCost * moneyMarket.stock;
        totalInvestments += realEstate.stockCost * realEstate.stock;
        totalInvestments += mattress.stockCost * mattress.stock;
        totalInvestments += options.stockCost * options.stock;
        totalInvestments += collectables.stockCost * collectables.stock;
        PlayerPrefs.SetFloat("totalInvestment", totalInvestments);
        totalInvestmentDisplay.text = "Total Investments: $" + totalInvestments;

    }


}
