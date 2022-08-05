using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    private bool nearDoor;
    private bool interact;

    LoadLevel levelLoader;
    [SerializeField] GameObject loadLevel;

    [SerializeField] GameObject doorNumber1;

    void Start()
    {
        levelLoader = loadLevel.GetComponent<LoadLevel>();
    }

    private void Update()
    {
        interact = Input.GetKeyDown(KeyCode.Space);

        if (nearDoor && interact)
        {
            if (doorNumber1)
            {
                levelLoader.LoadNextScene();
            }
        }
    }

    // Checks for collision with player for doors
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Door")) {
            nearDoor = true;
        }

        if (collision.gameObject.CompareTag("NewEvent"))
        {
            levelLoader.LoadFantasyWorld();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Door"))
        {
            nearDoor = false;
        }
    }

}
