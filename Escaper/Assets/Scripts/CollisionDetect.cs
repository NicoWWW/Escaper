using System.Collections;
using System.Collections.Generic;
using OpenCover.Framework.Model;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    public GameObject[] m_HPS;


    public PlayerMovement m_player;
    GameObject previous;
    AudioSource m_sound;
    int count = 2;

    void Start()
    {
        m_sound = GetComponent<AudioSource>();
        m_player = this.GetComponent<PlayerMovement>();

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            if (collision.collider.gameObject != previous)
            {
                m_sound.Play();
                m_player.m_HP--;
                if (count >= 0)
                {
                    m_HPS[count].SetActive(false);
                    count--;
                }
                previous = collision.collider.gameObject;
            }
            
            if (m_player.m_HP <= 0)
            {
                m_player.enabled = false;
                FindObjectOfType<GameManager>().EndGame();
            }
        }
    }
}
