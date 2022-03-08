using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float moveXSpeed = 10f;
    [SerializeField] float moveYSpeed  = 10f;
    [SerializeField] float rotateSpeed  = 250f;

    void Start()
    {
        //transform.Rotate(0, 0, 45);
    }

    void Update()
    {
        float deltaTime = Time.deltaTime;
        float moveXAmount  = Input.GetAxis("Horizontal") * moveXSpeed * deltaTime;
        float moveYAmount = Input.GetAxis("Vertical") * moveYSpeed * deltaTime;

        float direction = Input.GetKey(KeyCode.Q) ? 1 : Input.GetKey(KeyCode.E) ? -1 : 0;
        float rotateAmount = direction * rotateSpeed * deltaTime;
        
        transform.Rotate(0, 0, rotateAmount);
        transform.Translate(moveXAmount, 0, 0);
        transform.Translate(0, moveYAmount, 0);
    }
}
