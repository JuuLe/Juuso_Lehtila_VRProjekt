using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkLjud : MonoBehaviour
{
    AudioSource ljud;

    void Start()
    {
        ljud = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Mark"))
        {
            ljud.Play();
        }
    }
}
