using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Floor0ToFloor1 : MonoBehaviour
{
    public GameObject floor1;
    public GameObject floor0;

    [SerializeField]
    public TextMeshProUGUI upText;

    private bool openStairs;

    private void Start()
    {
        floor1.gameObject.SetActive(false);
        floor0.gameObject.SetActive(true);
        upText.gameObject.SetActive(false);
    }


    private void Update()
    {
        if (openStairs && Input.GetKeyDown(KeyCode.E))
            Upstairs();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pukki"))
        {
            upText.gameObject.SetActive(true);
            openStairs = true;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Pukki"))
        {
            upText.gameObject.SetActive(true);
            openStairs = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Pukki"))
        {
            upText.gameObject.SetActive(false);
            openStairs = false;
        }
    }

    private void Upstairs()
    {
        floor1.gameObject.SetActive(true);
        floor0.gameObject.SetActive(false);
    }
}
