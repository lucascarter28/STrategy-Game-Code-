using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UnitManager : MonoBehaviour
{
    private UnitStats unitStats;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        StartCoroutine(CombatTrigger());
    }

    public void Combat()
    {
        if (unitStats.attacking == true)
        {
            if (unitStats.attack < unitStats.defence)
            {

                unitStats.attack -= unitStats.defence;

                if (unitStats.attack < unitStats.armor)
                {
                    unitStats.attack -= unitStats.armor;

                    unitStats.health += unitStats.armor;

                    if (unitStats.armorPiercing == true)
                    {
                        unitStats.attack -= unitStats.health;
                    }

                    // Checks damage without armor piercing 
                    unitStats.attack -= unitStats.health;


                }

            }

            // Figure out how unit whos attack doesnt break through defence and armor can still do damage
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        unitStats.attacking = true;
        unitStats.engaged = true;
    }

    private void OnTriggerExit(Collider other)
    {
        unitStats.attacking = false;
        unitStats.engaged = false;
    }

    // Use IEnumerators to do iterations (look up what those are) 
    IEnumerator CombatTrigger()
    {
        unitStats.attacking = true;
        yield return new WaitForSeconds(5f);

    }
}
