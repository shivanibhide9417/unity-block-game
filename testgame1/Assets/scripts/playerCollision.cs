using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour {
    private void OnCollisionEnter(Collision collideinfo)
    {
        Debug.Log(collideinfo.collider.tag);
    }
}
