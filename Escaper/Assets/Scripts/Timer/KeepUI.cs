using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepUI : MonoBehaviour
{
    static GameObject m_theUI;
    public GameObject rootCanvas;

    // Start is called before the first frame update
    void Start()
    {
        if (!m_theUI)
        {
            DontDestroyOnLoad(rootCanvas);
            m_theUI = rootCanvas;
        }
        else
        {
            Destroy(rootCanvas);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
