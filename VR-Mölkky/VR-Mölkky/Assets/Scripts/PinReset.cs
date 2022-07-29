using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinReset : MonoBehaviour
{
    public PrimaryButtonWatcher watcher;
    public bool IsPressed = false; // used to display button state in the Unity Inspector window
    float startHeight;
    float currentX;
    float currentZ;
    float startRotationX;
    float startRotationY;
    float startRotationZ;
    private new Rigidbody rigidbody;
 //   bool isMoving;
    float currentAngle;
    public static bool AllowNext;
    [SerializeField] private float slowdown = 0.8F;

    void Start()
    {
        watcher.primaryButtonPress.AddListener(onPrimaryButtonEvent);
        startHeight = transform.position.y;
        rigidbody = GetComponent<Rigidbody>();
        // startRotationX = transform.eulerAngles.x;
        //  startRotationY = transform.eulerAngles.y;
        // startRotationZ = transform.eulerAngles.z;
    }

    IEnumerator moveCheck()
    {
        yield return new WaitForSeconds(0.5F);
    }

  //  private void Update()
  //  {
   //      isMoving = MolkkyMovDtct.isMoving;

   // }

    private void OnCollisionStay(Collision collision)
    {
        rigidbody.velocity = rigidbody.velocity * slowdown;
    }


    public void onPrimaryButtonEvent(bool pressed)
    {
        if (IsPressed = pressed)
        {
            Debug.Log("Pin AllowReset" + ResetAllow.AllowNext);
            MolkkyMovDtct.isMoving = false;
            StartCoroutine(moveCheck());

            if (ResetAllow.AllowNext == true || KlossReset.currentZ < LineLoc.Location)
            {
                rigidbody.velocity = Vector3.zero;
                rigidbody.angularVelocity = Vector3.zero;
                currentAngle = transform.eulerAngles.x;
 //               Debug.Log("vinkel " + currentAngle);
                currentX = transform.position.x;
                currentZ = transform.position.z;

                transform.position = new Vector3(currentX, startHeight, currentZ);

                transform.eulerAngles = new Vector3(0, 0, 0);

                //           rigidbody.isKinematic = true;
                //           rigidbody.isKinematic = false;

                //          rigidbody.velocity = Vector3.zero;
                //         rigidbody.angularVelocity = Vector3.zero;
                //rigidbody.Sleep();
            }
        }
    }
}
