using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu(fileName = "unitStats", menuName = "ScriptableObjects/unit")]
public class UnitStats : ScriptableObject
{

    // this script handles unit stats 

    [Header("Unit Stats")]

    public static int health = 1;
    public static float speed = 5f;
    public static int armor = 10;
    public static int defence = 5;
    public static int attack = 4;
    public static int moral = 30;
    public static int stamina = 20;
    public static int unitSize = 1500;
    public static float attackRate = 5;
    public static float lineOfSight = 30f;


    [Header("Unit Physics")]
    public int unitWeight = 15;
    public int unitMass = 50;

    [Header("Unit Bools")]
    public static bool attacking = false;
    // Determins if the unit has armor piercing and what percentage of its attack is able to pierce
    public static bool armorPiercing = false;
    // Determins if there is a moral penalty to other units when this unit is routed or broken
    public static bool moralPenalty = false;


  

}
