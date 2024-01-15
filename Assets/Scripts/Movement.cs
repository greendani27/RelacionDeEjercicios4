using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] float moveSpeed = 10f;
    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Rotate(new Vector3(0,0, -horizontalInput));
        transform.Translate(new Vector3(0, verticalInput, 0) * moveSpeed * Time.deltaTime);
        
        //rb.velocity = new Vector3(0, verticalInput, 0) * moveSpeed * Time.deltaTime;

    }
}
