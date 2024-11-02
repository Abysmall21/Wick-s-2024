using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    Camera cam;
    public GameObject Pawns;
    public bool TargetLocked = false;
    Vector3 CamPos;
    // Start is called before the first frame update
    void Start()
    {
        if (cam == null)
        {
            cam = Camera.main;
        }
        CamPos = Pawns.gameObject.transform.position;
        gameObject.transform.position = CamPos;
    }

    // Update is called once per frame
    void Update()
    {
        CamPos = Pawns.gameObject.transform.position;
        gameObject.transform.position = CamPos;
    }
    void LockedOn()
    {
        if (TargetLocked)
        {

        }
    }
}
