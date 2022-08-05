using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BorderControl : MonoBehaviour
{
    public TMP_Text _touchingWalls;

    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _touchingWalls.text = "I heard sounds from the left path..";
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _touchingWalls.text = "";
        }
    }
}
