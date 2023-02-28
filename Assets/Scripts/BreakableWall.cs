using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableWall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            breakWall();
        }
    }
    void breakWall()
    {
        gameObject.SetActive(false);
    }
}
