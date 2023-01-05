using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Floor3ToFloor2 : MonoBehaviour
{
    public GameObject floor3;
    public GameObject floor2;

    [SerializeField]
    public TextMeshProUGUI downText;

    private bool openStairs;

    private void Start()
    {
        floor3.gameObject.SetActive(true);
        floor2.gameObject.SetActive(false);
        downText.gameObject.SetActive(false);
    }


    private void Update()
    {
        if (openStairs && Input.GetKeyDown(KeyCode.E))
            Downstairs();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pukki"))
        {
            downText.gameObject.SetActive(true);
            openStairs = true;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Pukki"))
        {
            downText.gameObject.SetActive(true);
            openStairs = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Pukki"))
        {
            downText.gameObject.SetActive(false);
            openStairs = false;
        }
    }

    private void Downstairs()
    {
        floor3.gameObject.SetActive(false);
        floor2.gameObject.SetActive(true);
    }
}
