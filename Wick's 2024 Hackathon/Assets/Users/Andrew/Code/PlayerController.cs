using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public ScriptableObject playerStats;

    public Rigidbody rb;

    public float moveSpeed;

    private Vector3 moveDir = Vector3.zero;

    public InputActionReference move;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveDir = move.action.ReadValue<Vector2>();
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(moveDir.x * moveSpeed, 0, moveDir.y * moveSpeed);
    }
    private void OnEnable()
    {
        
    }


    private void OnDisable()
    {
        
    }
}
