using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
        }
    }

    void Collect()
    {
        // Optional: You can add actions here, such as increasing the score
        // For example:
        // GameManager.instance.AddScore(scoreValue);

        // Play a sound (optional)
        // AudioManager.instance.PlayCollectSound();

        // Deactivate the collectible object
    }
}
