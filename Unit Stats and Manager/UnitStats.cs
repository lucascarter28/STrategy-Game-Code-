using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UnitStats", menuName = "Stats")]
public class UnitStats : ScriptableObject
{
    public int health;
    public int armor;
    public int defence;
    public int moral;
    public int attack;
    
    public float speed;
    public float stamina;


    public bool attacking;
    public bool armorPiercing;
    public bool moralPenaltry;
    public bool engaged;

}
