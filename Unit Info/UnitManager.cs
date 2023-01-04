using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager : MonoBehaviour
{
    // This script handles combat information and how units interact with each other in combat. 

    [SerializeField] private UnitStats unitStats;

    private Rigidbody rb;

    private bool engaged = false;

    // The attack trigger should equal the range of attack for ranged attacks, and should trigger automatically for melee units
    // E.G. Units have a trigger on them that turns true to start attacking once the triggers interact 
    // think of the damage triggers from the scriptable objects tutorial from samyam for triggers for damaging health. 

    [SerializeField] private GameObject attackTrigger;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        Combat();
        Moral();
        UnitPhysics();
    }

    private void Moral()
    {
        // Handles the moral of units. Set it so that 25-40% damage gives the unit a percent chance of routing, with it scaling
        // with more damage, and 50%-65% damage a scaling percentage chance to shatter the unti. Then make sure to set the unit to not
        // be selectable during break and route. Also handles moral penelty status effect
    }

    private void Combat()
    {
        // Handles unit interaction with attack and defence 
        // Handles damage, hit chance, armor piercing, etc    

        // for the if statments, look into using switch-case statements instead for better performance if needed. 

      

            if (UnitStats.attacking == true)
            {
            if (UnitStats.attack < UnitStats.defence)
            {

                UnitStats.attack -= UnitStats.defence;

                if (UnitStats.attack < UnitStats.armor)
                {
                    UnitStats.attack -= UnitStats.armor;

                    UnitStats.health += UnitStats.armor;

                    if (UnitStats.armorPiercing == true)
                    {
                        UnitStats.attack -= UnitStats.health;
                    }

                    // Checks damage without armor piercing 
                    UnitStats.attack -= UnitStats.health;

                    StartCoroutine(CombatTrigger());
                }

            }

            // Figure out how unit whos attack doesnt break through defence and armor can still do damage
        }

    }

    private void UnitPhysics()
    {
        // Handles unit mass and the abilitie to push units (essentially adds "weight" like the older total war games) 
        // Use if statements to transform unit position backwards or forwards depending on if the unit is heavier or lighter than the
        // opposing unit. 

        //Rigidbody mass is mass of an object, weight = force and changes on an object

      //  rb.detectCollisions= true;

        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        UnitStats.attacking = true;
        engaged = true;
    }

    private void OnTriggerExit(Collider other)
    {
        UnitStats.attacking = false;
        engaged = false;
    }

    // Use IEnumerators to do iterations (look up what those are) 
    IEnumerator CombatTrigger()
    {
        UnitStats.attacking = true;
        yield return new WaitForSeconds(5f); 
        
    }


    // Let line of sight be handled by the behavior manager. Maybe use an FSM alongside it. 
}
