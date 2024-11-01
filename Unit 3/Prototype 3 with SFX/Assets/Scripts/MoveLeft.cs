using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30f;
    public PlayerController playerControllerScript;
    private float leftBound = -10.0f;
    // Start is called before the first frame update
    void Start()
    {
     playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (gameObject.CompareTag("Obstacle") && transform.position.x <  leftBound)
        {
            Destroy(gameObject);
        }
    }
}
