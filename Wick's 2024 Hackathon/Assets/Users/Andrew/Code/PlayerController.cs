using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public ScriptableObject playerStats;

    public Rigidbody rb;

    public float moveSpeed;

    private Vector3 moveInput = Vector3.zero;

    public InputActionReference move;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = move.action.ReadValue<Vector2>();
    }
    private void FixedUpdate()
    {
        Vector3 moveDir = new Vector3(moveInput.x, 0, moveInput.y);


        rb.velocity = new Vector3(moveInput.x * moveSpeed, 0, moveInput.y * moveSpeed);
        transform.rotation = Quaternion.LookRotation(moveDir);


    }
    private void OnEnable()
    {
        
    }


    private void OnDisable()
    {
        
    }
}
