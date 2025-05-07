using System;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb; 
    private float movementX;
    private float movementY;
    public float speed = 0; 
    public UnityEvent onGameStart;
    
    void Start()
    {
        rb = GetComponent <Rigidbody>(); 
    }
    
    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("PickUp")) 
        {
            other.gameObject.SetActive(false);
            GlobalEventManager.EmitPickupMessage();
        }
    }
    
    void OnMove (InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>(); 
        movementX = movementVector.x; 
        movementY = movementVector.y; 
    }
    
  
    
    private void FixedUpdate() 
    {
        Vector3 movement = new Vector3 (movementX, 0.0f, movementY);
        rb.AddForce(movement * speed); 
    }
}
