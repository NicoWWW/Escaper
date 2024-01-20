using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCanvas : MonoBehaviour
{
    public GameObject m_canvas;

    // Use this for initialization
    void Start()
    {
        GameObject obj = GameObject.FindGameObjectWithTag("Canvas");
        if (!obj)
        {
            obj = (GameObject)Instantiate(m_canvas);
        }
        else if (this != obj)
        {
            Destroy(this);
        }
    }
}