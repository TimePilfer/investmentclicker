using UnityEngine;
using System.Collections;

public class stockMinus : MonoBehaviour {

    public dollars dollars;
    public stockClick stock;
    public UnityEngine.UI.Text stockDisplay;

    public void stockSold()
    {
        if (stock.stock > 0)
        {
            dollars.dollarsOwned += stock.stockCost * stock.stockPerClick;
            stock.stock -= stock.stockPerClick;
            stockDisplay.text = stock.itemName + ": " + stock.stock;
            dollars.dollarUpdate();
        }
    }
}
