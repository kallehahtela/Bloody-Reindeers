using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KidutushuoneToFloor3 : MonoBehaviour
{
    public GameObject kidutushuone;
    public GameObject floor3;

    [SerializeField]
    public TextMeshProUGUI openText;

    private bool openStairs;

    private void Start()
    {
        kidutushuone.gameObject.SetActive(true);
        floor3.gameObject.SetActive(false);
        openText.gameObject.SetActive(false);
    }


    private void Update()
    {
        if (openStairs && Input.GetKeyDown(KeyCode.E))
            OpenDoor();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pukki"))
        {
            openText.gameObject.SetActive(true);
            openStairs = true;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Pukki"))
        {
            openText.gameObject.SetActive(true);
            openStairs = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Pukki"))
        {
            openText.gameObject.SetActive(false);
            openStairs = false;
        }
    }

    private void OpenDoor()
    {
        kidutushuone.gameObject.SetActive(false);
        floor3.gameObject.SetActive(true);
    }
}
