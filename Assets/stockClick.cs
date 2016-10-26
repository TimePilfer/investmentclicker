using UnityEngine;
using System.Collections;

public class stockClick : MonoBehaviour {

    public dollars dollars;
    public UnityEngine.UI.Text stockDisplay;
    public UnityEngine.UI.Text stockCostDisplay;
    public uint stock = 0;
    public uint stockPerClick;
    public float stockCost;
    public string itemName;
    public float minRandom;
    public float maxRandom;
    public float count = 0;
    public float average;
    public float range;

    public void stockClicked()
    {
        if (dollars.dollarsOwned >= stockCost * stockPerClick)
        {
            dollars.dollarsOwned -= stockCost * stockPerClick;
            stock += stockPerClick;
            stockDisplay.text = itemName + ": " + stock;
            dollars.dollarUpdate();
        }

    }



    public void nextTurn()
    {
        count += 1;

        float luck = Random.Range(1, 1000);

        if(luck>=160 && luck <= 500)
        {

            float averageRoll = Random.Range(average-range, average);

            stockCost = Mathf.Round(stockCost * averageRoll);

        }
        if (luck >= 501 && luck <= 841)
        {

            float averageRoll = Random.Range(average, average + range);

            stockCost = Mathf.Round(stockCost * averageRoll);

        }

        else if (luck >=23 && luck <=159)
        {
            float lowRoll = Random.Range(average - (2 * range), average - range);

            stockCost = Mathf.Round(stockCost * lowRoll);
        }

        else if (luck >= 2 && luck <= 22)
        {
            float veryLowRoll = Random.Range(average - (3 * range), average - (2*range));

            stockCost = Mathf.Round(stockCost * veryLowRoll);
        }
        else if (luck == 1)
        {
            float worstRoll = minRandom;

            stockCost = Mathf.Round(stockCost * worstRoll);
        }
        else if (luck >= 842 && luck <= 978)
        {
            float highRoll = Random.Range(average + (2 * range), average + range);

            stockCost = Mathf.Round(stockCost * highRoll);
        }
        else if (luck >= 979 && luck <= 999)
        {
            float veryHighRoll = Random.Range(average + (3 * range), average + (2*range));

            stockCost = Mathf.Round(stockCost * veryHighRoll);
        }
        else if (luck == 1000)
        {
            float bestRoll = maxRandom;

            stockCost = Mathf.Round(stockCost * bestRoll);
        }

        stockCostDisplay.text = "$" + stockCost;
        dollars.dollarUpdate();

    }
}
