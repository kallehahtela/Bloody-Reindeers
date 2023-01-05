using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Floor5ToFloor4 : MonoBehaviour
{
    public GameObject floor5;
    public GameObject floor4;

    [SerializeField]
    public TextMeshProUGUI downText;

    private bool openStairs;

    private void Start()
    {
        floor5.gameObject.SetActive(true);
        floor4.gameObject.SetActive(false);
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
        floor5.gameObject.SetActive(false);
        floor4.gameObject.SetActive(true);
    }
}
