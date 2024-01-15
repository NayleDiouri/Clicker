using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentBerry : MonoBehaviour
{
    public SpriteRenderer sR;
    public Berries[] berrieToRead;
    private Berries currentBerry;
    void Start()
    {
        GenerateBerry();
    }

    public void GenerateBerry()
    {
        currentBerry = berrieToRead[Random.Range(0, berrieToRead.Length)];
        sR.sprite = currentBerry.berrySprite;

    }


}
