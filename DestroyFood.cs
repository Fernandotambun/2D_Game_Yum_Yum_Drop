using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFood : MonoBehaviour
{
    private float destroyYThreshold = -4.41f; // Batas Y untuk menghancurkan objek
    void Update()
    {
        // Cek apakah posisi y objek berada di bawah batas
        if (transform.position.y <= destroyYThreshold)
        {
            Destroy(gameObject); 
            Debug.Log("Food destroyed");
            GameManager.instance.health -= 1;
            // GameManager.health -= 1;
        }
    }
}