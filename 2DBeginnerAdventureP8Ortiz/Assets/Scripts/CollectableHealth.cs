using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableHealth : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Object that entered the trigger: " +  other);
    }
}
