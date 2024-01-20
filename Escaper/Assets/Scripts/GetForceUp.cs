using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetForceUp : MonoBehaviour
{
    public GameManager gameManager;

    // Start is called before the first frame update
    void OnTriggerEnter()
    {
        gameManager.playerGetForceUP();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
