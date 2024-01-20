using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;

    public GameObject LevelCompleteUI;

    public Rigidbody player;
    public float rbForce = 1000f;

    public GameObject m_list;

    private void Start()
    {

    }

    public void playerGetForce()
    {
        player.AddForce(0, 0, rbForce * Time.deltaTime, ForceMode.VelocityChange);
    }

    public void playerGetForceUP()
    {
        player.AddForce(0, rbForce * Time.deltaTime, 0, ForceMode.VelocityChange);
    }

    public void LevelComplete()
    {
        LevelCompleteUI.SetActive(true);
    }

    public void EndGame()
    {
        if (!gameHasEnded)
        {
            
            if (SceneManager.GetActiveScene().buildIndex != 10)
            {
                foreach (Transform child in m_list.transform)
                {
                    Debug.Log("true1");
                    if (!child.gameObject.activeSelf)
                    {
                        Debug.Log("true2");
                        child.gameObject.SetActive(true);
                    }
                }
            }
            
            gameHasEnded = true;
            Debug.Log("Game Over!");
            Invoke("Restart", restartDelay);
        }
    }

    public void Restart()
    {
        
        if (SceneManager.GetActiveScene().buildIndex != 10)
        {
            foreach (Transform child in m_list.transform)
            {
                if (!child.gameObject.activeSelf)
                {
                    child.gameObject.SetActive(true);
                }
            }
        }
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
