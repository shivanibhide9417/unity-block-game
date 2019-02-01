using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerEnd : MonoBehaviour {
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("end game");
        gameManager.completeLevel();
    }
}
