using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Arkku2 : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI pickUpText;
    public GameObject arkku1;
    public GameObject arkku2;
    public GameObject arkku3;
    public GameObject AvainEiOtettu;
    public GameObject AvainOtettu;
    private bool pickUpAllowed;

    private void Start()
    {
        arkku1.SetActive(false);
        arkku2.SetActive(true);
        arkku3.SetActive(false);
        AvainEiOtettu.SetActive(true);
        AvainOtettu.SetActive(false);
        pickUpText.gameObject.SetActive(false);
    }


    private void Update()
    {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E))
            PickUp();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pukki"))
        {
            pickUpText.gameObject.SetActive(true);
            pickUpAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Pukki"))
        {
            pickUpText.gameObject.SetActive(false);
            pickUpAllowed = false;
        }
    }

    private void PickUp()
    {
        arkku1.SetActive(false);
        arkku2.SetActive(false);
        arkku3.SetActive(true);
        AvainEiOtettu.SetActive(false);
        AvainOtettu.SetActive(true);
    }
}
