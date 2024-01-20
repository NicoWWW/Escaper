using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetForce : MonoBehaviour
{
    Rigidbody m_rigidbody;
    public float Force = 1000f;

    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
        GetComponent<Rigidbody>().AddRelativeForce(Force, 0, 0, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
