using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MolkkyHit : MonoBehaviour
{
    AudioSource ljud;

    void Start()
    {
      ljud = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("KastKloss") || (collision.collider.CompareTag("Mölkky")))
        {
            ljud.Play();
        }
    }
}
