using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Floor1ToFloor2 : MonoBehaviour
{
    public GameObject floor1;
    public GameObject floor2;

    [SerializeField]
    public TextMeshProUGUI upText;

    private bool openStairs;

    private void Start()
    {
        floor1.gameObject.SetActive(true);
        floor2.gameObject.SetActive(false);
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
        floor1.gameObject.SetActive(false);
        floor2.gameObject.SetActive(true);
    }
}
