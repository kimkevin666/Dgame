using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Animator animator;
    Rigidbody2D _rigidbody2D;

    public float flapForce = 6f;
    public float forwardSpeed = 3f;
    public bool IsDead = false;
    float deathcooldown = 0f;

    bool isFlap = false;

    public bool godMode = false;



    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildern<Animator>();
        _rigidbody2D = GetComponent<Rigidbody2D>();

        if(animator == null)
            Debug.LogError("Not Founded Animator");
        
        if(_rigidbody2D == null)
            Debug.LogError("Not Founded Rigidbody");
    }

        
}




    // Update is called once per frame
    void Update()
{
    if (isDead)
    {

    }
    else
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetmouseButtonDown(0))
        {
            isFlap = true;
        }
    }
}


private boid FixedUpdate()
{
    if (isDead) return;
    
    vector3 velocity = _rigidbody2D.velocity;
    velocity.x = forwardSpeed;

    if(isFlap)
    {
               velocity.y = flapForce;
        isFlap = false;
    }

    _rigidbody.velocity = velocity; 
}
