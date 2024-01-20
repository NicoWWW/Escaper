using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    public GameManager gameManager;

    public float forwardForce = 1000f;
    public float sidewayForce = 600f;
    public float outRange = -0.5f;

    Vector3 tilt = Vector3.zero;

    public int m_HP = 3; //chance to hit the obstacle

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        tilt = Input.acceleration;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (tilt.x > 0)
        {
            rb.AddForce(new Vector3(sidewayForce * Time.deltaTime, 0, 0), ForceMode.VelocityChange);
        }
        if (tilt.x < 0)
        {
            rb.AddForce(new Vector3(-sidewayForce * 0.01f, 0, 0), ForceMode.VelocityChange);
        }

#if UNITY_EDITOR
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(new Vector3(sidewayForce * Time.deltaTime, 0, 0), ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(new Vector3(-sidewayForce * 0.01f, 0, 0), ForceMode.VelocityChange);
        }

        /*
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(new Vector3(0, sidewayForce * Time.deltaTime, 0), ForceMode.VelocityChange);
        }
        */
        
        if (Input.GetKey("r"))
        {
            gameManager.Restart();
        }
#endif

        if (rb.position.y < outRange)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        if (m_HP <= 0)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
