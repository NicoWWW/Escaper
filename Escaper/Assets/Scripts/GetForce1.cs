using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetForce1 : MonoBehaviour
{
    public GameManager gameManager;

    // Start is called before the first frame update
    void OnTriggerEnter()
    {
        gameManager.playerGetForce();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
