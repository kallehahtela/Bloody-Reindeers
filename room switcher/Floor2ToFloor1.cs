using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Floor2ToFloor1 : MonoBehaviour
{
    public GameObject floor2;
    public GameObject floor1;

    [SerializeField]
    public TextMeshProUGUI downText;

    private bool openStairs;

    private void Start()
    {
        floor2.gameObject.SetActive(true);
        floor1.gameObject.SetActive(false);
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
        floor2.gameObject.SetActive(false);
        floor1.gameObject.SetActive(true);
    }
}
