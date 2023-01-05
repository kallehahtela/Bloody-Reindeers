using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class muori_interact : MonoBehaviour
{
    [SerializeField]
    public GameObject textBox;

    private bool openStairs;

    private void Start()
    {
        textBox.gameObject.SetActive(false);
    }


    private void Update()
    {
        if (openStairs && Input.GetKeyDown(KeyCode.E))
            TextBox();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pukki"))
        {
            textBox.gameObject.SetActive(true);
            openStairs = true;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Pukki"))
        {
            textBox.gameObject.SetActive(true);
            openStairs = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Pukki"))
        {
            textBox.gameObject.SetActive(false);
            openStairs = false;
        }
    }

    private void TextBox()
    {
        textBox.gameObject.SetActive(true);
    }
}
