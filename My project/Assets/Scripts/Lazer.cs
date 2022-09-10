using UnityEngine;
using UnityEngine.Events;

public class Lazer : MonoBehaviour
{
    void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        Destroy(gameObject);
    }
}
