using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // This script destroys the GameObject when the game starts.
    void Start()
    {
        Destroy(gameObject); // Removes the GameObject from the scene at the beginning.
    }
}


