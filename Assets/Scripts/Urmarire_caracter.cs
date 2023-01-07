using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Urmarire_caracter : MonoBehaviour
{
    //public GameObject caracter;

    //Vector3 distanta;

    [SerializeField]
    private Transform target;

    private Vector3 offsetPosition = new Vector3(0, 0.5f, -2);

    private Space offsetPositionSpace = Space.Self;

    [SerializeField]
    private bool lookAt = true;

    void Start()
    {
        //distanta = transform.position - caracter.transform.position;
    }
    void Update()
    {
        //transform.position = caracter.transform.position + distanta;

        // compute position
        if (offsetPositionSpace == Space.Self)
        {
            transform.position = target.TransformPoint(offsetPosition);
        }
        else
        {
            transform.position = target.position + offsetPosition;
        }

        // compute rotation
        if (lookAt)
        {
            transform.LookAt(target);
        }
        else
        {
            transform.rotation = target.rotation;
        }
    }
}
