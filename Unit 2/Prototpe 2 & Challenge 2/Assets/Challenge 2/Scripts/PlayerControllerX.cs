using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float dogSpawnCooldown = 1.0f;

    private float nextSpawnTime = 0f;

    void Update()
    {
        // Check if the spacebar is pressed and the cooldown period has passed
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= nextSpawnTime)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            // Set the next spawn time based on the cooldown
            nextSpawnTime = Time.time + dogSpawnCooldown;
        }
    }
}
