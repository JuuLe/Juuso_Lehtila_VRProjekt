using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MolkkyMovDtct : MonoBehaviour
{
    public static bool isMoving;
    private new Rigidbody rigidbody;
    [SerializeField] private float minspeed =  0.1F;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        isMoving = false;
    }

    void Update()
    {
        if (rigidbody.velocity.sqrMagnitude > minspeed)
        {
            isMoving = true;

        }
        else
        {
            isMoving = false;
        }
     //   Debug.Log("move check" + isMoving);
    }
}
