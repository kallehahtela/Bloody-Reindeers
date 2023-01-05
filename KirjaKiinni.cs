using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KirjaKiinni : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI pickUpText;
    public TextMeshProUGUI closerLookText;
    public TextMeshProUGUI closeBookText;
    public GameObject kirjaKiinni;
    public GameObject kirjaAuki;
    public GameObject kirjaSivuAuki;

    private void Start()
    {
        kirjaKiinni.SetActive(true);
        kirjaAuki.SetActive(false);
        kirjaSivuAuki.SetActive(false);
        pickUpText.gameObject.SetActive(false);
        closerLookText.gameObject.SetActive(false);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            Read();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pukki"))
        {
            pickUpText.gameObject.SetActive(true);
            closerLookText.gameObject.SetActive(false);
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Pukki"))
        {
            pickUpText.gameObject.SetActive(true);
            closerLookText.gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Pukki"))
        {
            pickUpText.gameObject.SetActive(false);
            closerLookText.gameObject.SetActive(false);
        }
    }

    private void Read()
    {
        kirjaKiinni.SetActive(false);
        kirjaAuki.SetActive(true);
        kirjaSivuAuki.SetActive(false);
        closerLookText.gameObject.SetActive(true);
        pickUpText.gameObject.SetActive(false);
    }
}
