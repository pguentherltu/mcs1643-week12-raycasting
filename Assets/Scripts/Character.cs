using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float jumpForce = 8.0f;
    public float moveSpeed = 3.0f;
    private Rigidbody rb;
    private bool onGround;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space) && onGround)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 jumpVector = transform.forward * .2f + transform.up;
            Debug.Log(jumpVector);
            rb.AddForce(jumpVector * jumpForce, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.DownArrow)) 
        {
            gameObject.transform.eulerAngles = new Vector3(0, 180, 0);
            gameObject.transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
            gameObject.transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.eulerAngles = new Vector3(0, 90, 0);
            gameObject.transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.eulerAngles = new Vector3(0, 270, 0);
            gameObject.transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        onGround = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        onGround = false;
    }
}
