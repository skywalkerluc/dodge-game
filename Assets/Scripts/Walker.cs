using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walker : MonoBehaviour
{
    float moveSpeed = 8f;
    void Update()
    {
        if(GetComponent<Rigidbody>().useGravity == true) {
            float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
            float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

            // creating opposite translation
            transform.Translate(zValue, 0, xValue);
        }
    }
}
