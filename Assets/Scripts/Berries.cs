using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Berries", menuName ="berry", order = 100)]
public class Berries : ScriptableObject
{

    public string berryName;
    public Sprite berrySprite;
    public int berryHP;
}
