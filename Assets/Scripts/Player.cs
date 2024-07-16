using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public float jumpPower;

    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            GetComponent<Animator>().SetBool("Run", true);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            GetComponent<Animator>().SetBool("Run", true);
        }

        else
        {
            GetComponent<Animator>().SetBool("Run", false);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpPower);
        }
    }
}
