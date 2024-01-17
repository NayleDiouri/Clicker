using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentBerry : MonoBehaviour
{
    public SpriteRenderer sR;
    public Berries[] berrieToRead;
    private Berries currentBerry;
    public float digStrenght; 
    public float currentBerryHP;
    public BerryBar berryBar;

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
