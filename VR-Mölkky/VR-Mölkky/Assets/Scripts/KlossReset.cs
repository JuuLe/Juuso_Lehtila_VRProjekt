using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KlossReset : MonoBehaviour
{
    public PrimaryButtonWatcher watcher;
    public bool IsPressed = false; // used to display button state in the Unity Inspector window
    float startHeight;
    float startX;
    float startZ;
//    float currentX;
    public static float currentZ;
    float startRotationX;
    float startRotationY;
    float startRotationZ;
    private new Rigidbody rigidbody;
    private new Collider collider;
    //   public bool isMoving;
    public static bool AllowNext;
    public static float Location;

    [SerializeField] private float slowdown = 0.9F;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        collider = GetComponent<Collider>();
        watcher.primaryButtonPress.AddListener(onPrimaryButtonEvent);
        startHeight = transform.position.y;
        startX = transform.position.x;
        startZ = transform.position.z;
        startRotationX = transform.eulerAngles.x;
        startRotationY = transform.eulerAngles.y;
        startRotationZ = transform.eulerAngles.z;
    }

    IEnumerator moveCheck()
    {
        yield return new WaitForSeconds(0.5F);
    }

    private void Update()
    {
   //       isMoving = MolkkyMovDtct.isMoving;
          currentZ = transform.position.z;
    }

    void OnCollisionStay(Collision collisionInfo)
    {
        {
            if (collisionInfo.gameObject.name == "Mark")
            {
                rigidbody.velocity = rigidbody.velocity * slowdown;
            }
        }   
    } 

    void onPrimaryButtonEvent(bool pressed)
    {
        if (IsPressed = pressed)
        {
            MolkkyMovDtct.isMoving = false;
            StartCoroutine(moveCheck());
            Debug.Log("Kloss AllowReset" + ResetAllow.AllowNext);

            if (ResetAllow.AllowNext == true || currentZ < LineLoc.Location)
            {

                transform.position = new Vector3(startX, startHeight, startZ);

                transform.eulerAngles = new Vector3(startRotationX, startRotationY, startRotationZ);
            }
        }
    }
}