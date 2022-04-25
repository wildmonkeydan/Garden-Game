using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpStuff : MonoBehaviour
{
    public Transform hands;

    private void OnMouseDown()
    {
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = hands.position;
        this.transform.parent = GameObject.Find("Player").transform;
    }

    private void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<BoxCollider>().enabled = true;
    }

}
