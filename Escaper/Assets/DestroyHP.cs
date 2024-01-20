using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyHP : MonoBehaviour
{
    public GameObject[] m_list;
    PlayerMovement m_player;
    int curr;
    // Start is called before the first frame update
    void Start()
    {
        m_player = FindObjectOfType<PlayerMovement>();
        curr = m_player.m_HP - 1;
    }

    // Update is called once per frame
    void Update()
    {
        curr = m_player.m_HP - 1;
        if (curr >= 0)
        {
            if (m_list[curr])
            {
                m_list[curr].SetActive(false);
            }
        }
        
    }
}
