using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Floor3ToFloor4 : MonoBehaviour
{
    public GameObject floor3;
    public GameObject floor4;

    [SerializeField]
    public TextMeshProUGUI upText;

    private bool openStairs;

    private void Start()
    {
        floor3.gameObject.SetActive(true);
        floor4.gameObject.SetActive(false);
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
        floor3.gameObject.SetActive(false);
        floor4.gameObject.SetActive(true);
    }
}
