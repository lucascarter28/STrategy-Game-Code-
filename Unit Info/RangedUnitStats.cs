using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "unitStats", menuName = "ScriptableObjects/rangedUnit")]

public class RangedUnitStats : MonoBehaviour
{
    // this script handles ranged unit information (including ranged infantry such as peltasts, or as an example royal peltasts
    // from total war rome 2)

    [Header("Unit Stats")]

    [SerializeField] int health = 1;

    [SerializeField] float speed = 5f;

    [SerializeField] int armor = 10;

    [SerializeField] int defence = 5;

    [SerializeField] int attack = 4;

    [SerializeField] bool attacking = false;

    // Determins if the unit has armor piercing and what percentage of its attack is able to pierce
    [SerializeField] bool armorPiercing = false;

    [SerializeField] int moral = 30;

    // Determins if there is a moral penalty to other units when this unit is routed or broken
    [SerializeField] bool moralPenalty = false;

    [SerializeField] int stamina = 20;

    [SerializeField] int unitWeight = 15;

    [SerializeField] int unitSize = 1500;

    [SerializeField] int projectileRange = 10;

    [SerializeField] int projectileDamage = 25;
}

