using UnityEngine;
using System.Collections;
using System;

public class changeClickValue : MonoBehaviour {

    int counter = 1;
    public stockClick stockClick;
    public stockClick bondClick;
    public stockClick moneyMarketClick;
    public stockClick realEstateClick;
    public stockClick mattressClick;
    public stockClick optionsClick;
    public stockClick collectablesClick;
    String[] clickAmount = new String[5] {"1", "5", "10", "25", "100"};
    public UnityEngine.UI.Text clickAmountDisplay;

    public void buttonClicked()
    {
        clickAmountDisplay.text = "x" + clickAmount[counter];
        stockClick.stockPerClick = UInt32.Parse(clickAmount[counter]);
        bondClick.stockPerClick = UInt32.Parse(clickAmount[counter]);
        moneyMarketClick.stockPerClick = UInt32.Parse(clickAmount[counter]);
        realEstateClick.stockPerClick = UInt32.Parse(clickAmount[counter]);
        mattressClick.stockPerClick = UInt32.Parse(clickAmount[counter]);
        optionsClick.stockPerClick = UInt32.Parse(clickAmount[counter]);
        collectablesClick.stockPerClick = UInt32.Parse(clickAmount[counter]);
        counter++;
        if (counter == clickAmount.Length)
        {
            counter = 0;
        }
    }

}
