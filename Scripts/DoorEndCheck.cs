using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorEndCheck : MonoBehaviour
{
    Vector3 BDC;
    Vector3 TDC;
    private void Awake()
    {
        BDC = new Vector3(transform.localPosition.x, transform.localPosition.y - 2, transform.localPosition.z);
        TDC = transform.localPosition;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            transform.DoorOpen(BDC);
            StartCoroutine(CloseDoor());
            Debug.Log("Open");
        }
    }

    IEnumerator CloseDoor()
    {
        while (true)
        {
            yield return new WaitForSeconds(2.5f);
            transform.DoorClose(TDC);
            Debug.Log("Close");
        }
    }
}
