using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCode : MonoBehaviour
{
    public Animator animator;
    public Collider CTrigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider CTrigger)
    {
        DoorOpen();
    }

    private void OnTriggerExit(Collider CTrigger)
    {
        DoorClose();
    }

    void DoorOpen()
    {
        animator.SetBool("isOpen", true );
    }

    void DoorClose()
    {
        animator.SetBool("isopen", false);
    }

}
