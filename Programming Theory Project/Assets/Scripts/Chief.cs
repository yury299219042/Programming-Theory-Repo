using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chief : Enemy  // INHERITANCE
{
    private Rigidbody enemyRb;
    void Awake()
    {
        enemyRb = GetComponent<Rigidbody>();
        SetWarrior();
    }

 
    public override void SetWarrior()   // POLYMORPHISM
    {
        enemyRb.mass = 5f;
    }
}
