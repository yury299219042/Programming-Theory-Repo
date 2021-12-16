using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float normalSpeed = 3.0f;
    public Vector3 lookDirection;

    // set Enemy speed >= 3.0f
    public float speed  // ENCAPSULATION
    {
        get { return normalSpeed; }
        set
        {
            if(value < 3.0f)
            {
                normalSpeed = 3.0f;
            }
            else
            {
                normalSpeed = value;
            }
        }
    }
    private Rigidbody enemyRb;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        SetWarrior();
    }

 
    void Update()
    {
        MoveEnemy();    // ABSTRACTION
    }

    public void MoveEnemy() // ABSTRACTION
    {
        lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }

    public virtual void SetWarrior()    // POLYMORPHISM
    {
        enemyRb.mass = 0.9f;
    }
}
