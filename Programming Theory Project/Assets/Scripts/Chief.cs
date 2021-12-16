using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chief : Enemy  // INHERITANCE
{
   

    
    public override void SetWarrior()   // POLYMORPHISM
    {
        gameObject.GetComponent<Rigidbody>().mass = 5f;
    }
}
