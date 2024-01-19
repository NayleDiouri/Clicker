using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CurrentBerry : MonoBehaviour
{
    public SpriteRenderer sR;
    public Berries[] berrieToRead;
    public Berries currentBerry;
    public float digStrenght; 
    public float currentBerryHP;
    public BerryBar berryBar;
    public TextMeshProUGUI moneyText;
    public float totalMoney;

    void Start()
    {
        GenerateBerry();
        berryBar.SetMaxHealth(currentBerryHP);
    }

    private void OnMouseDown()
    {
        DigBerry();
        if(currentBerryHP <= 0)
        {
            totalMoney += currentBerry.money;
            moneyText.text = "Money : " + totalMoney;
            GenerateBerry();
        }

    }

    public void GenerateBerry()
    {
        currentBerry = berrieToRead[Random.Range(0, berrieToRead.Length)];
        sR.sprite = currentBerry.berrySprite;
        currentBerryHP = currentBerry.berryHP;
        berryBar.SetMaxHealth(currentBerryHP);
    }
    public void DigBerry()
    {
        currentBerryHP -= digStrenght;
        berryBar.SetHealth(currentBerryHP);
    }


}
