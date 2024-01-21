using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Buttons : MonoBehaviour
{
    public CurrentBerry cB;
    public Berries[] berry;
    public float digPrice, gainPrice, autoClickPrice;
    public TextMeshProUGUI blueText, redText, yellowText;



    private void Start()
    {
        berry[0].money = 1;
        berry[1].money = 5;
        berry[2].money = 10;
        berry[3].money = 20;
        berry[4].money = 50;
        blueText.text = "better digging strenght " + digPrice;
        redText.text = "Better auto click " + autoClickPrice;
        yellowText.text = "More money! " + gainPrice;
    }
    public void UpgradeDig()
    {
      if(cB.totalMoney >= digPrice) 
        {
            cB.totalMoney -= digPrice;
            cB.moneyText.text = "Money : " + cB.totalMoney;
            digPrice += 10;
            cB.digStrenght += 1;
            blueText.text = "" + digPrice;

        }
    }

    public void UpgradeAutoClick()
    {
        if (cB.totalMoney >= autoClickPrice)
        {
            cB.autoClick += 1;
            cB.autoClickSpeed *= 0.92f;
            cB.totalMoney -= autoClickPrice;
            autoClickPrice *= 1.4f;
            cB.moneyText.text = "Money : " + cB.totalMoney;
            redText.text = "" + autoClickPrice;

        }
    }
    public void UpgradeGain()
    {
        if(cB.totalMoney >= gainPrice)
        {
            cB.totalMoney -= gainPrice;
            cB.moneyText.text = "Money : " + cB.totalMoney;
            gainPrice *= 1.6f;
            berry[0].money *= 1.4f;
            berry[1].money *= 1.4f;
            berry[2].money *= 1.4f;
            berry[3].money *= 1.4f;
            berry[4].money *= 1.4f;
            yellowText.text = "" + gainPrice;
        }
    }


}
