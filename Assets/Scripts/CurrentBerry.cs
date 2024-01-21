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
    public float digStrenght, currentBerryHP, totalMoney, upgradeHp, autoClick, autoClickSpeed;
    public BerryBar berryBar;
    public TextMeshProUGUI moneyText;

    void Start()
    {
        GenerateBerry();
        berryBar.SetMaxHealth(currentBerryHP);
        StartCoroutine(AutoClic());
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
    public IEnumerator AutoClic()
    {
        while (true)
        {
            currentBerryHP -= autoClick;
            yield return new WaitForSeconds(autoClickSpeed);
            berryBar.SetHealth(currentBerryHP);
            if (currentBerryHP <= 0)
            {
                totalMoney += currentBerry.money;
                moneyText.text = "Money : " + totalMoney;
                GenerateBerry();
            }
        }
    }
    public void GenerateBerry()
    {
        upgradeHp += 0.1f;
        currentBerry = berrieToRead[Random.Range(0, berrieToRead.Length)];
        sR.sprite = currentBerry.berrySprite;
        currentBerryHP = currentBerry.berryHP * upgradeHp;
        berryBar.SetMaxHealth(currentBerryHP);
    }
    public void DigBerry()
    {
        currentBerryHP -= digStrenght;
        berryBar.SetHealth(currentBerryHP);
    }


}
