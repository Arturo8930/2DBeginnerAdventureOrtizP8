using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //Variables related to player character movement
    public int maxHealth = 5;
    public int health { get { return currentHealth ; }}
    int currentHealth = 1;



    public InputAction MoveAction;
    Rigidbody2D rigidbody2d;
    Vector2 move;
    public float speed = 3.04f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        MoveAction.Enable();
        rigidbody2d = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        move = MoveAction.ReadValue<Vector2>();



        if (!Mathf.Approximately(move.x, 0.0f) || !Mathf.Approximately(move.y, 0.0f))
        {
            MoveDirection.Set(move.x, move.y);
            MoveDirection.Normalize();
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 position = transform.position;
        position.x = position.x + 0.01f * horizontal;
        position.y = position.y + 0.01f * vertical;
        transform.position = position;


        
    }
    public void ChangeHealth (int amount)
    {
        if (amount < 0)
        {
            if (isInvincible)
            {
                return;
            }
            isInvincible = true;
            damageCooldown = timeInvincible;
        }

        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }

    //Variables related to temporary invincibility
    public float timeInvincible = 2.0f;
    bool isInvincible;
    float damageCooldown;

     
    
}   
