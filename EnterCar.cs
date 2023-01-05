using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EnterCar : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI enterCarText;

    private bool openCar;

    private void Start()
    {
        enterCarText.gameObject.SetActive(false);
    }


    private void Update()
    {
        if (openCar && Input.GetKeyDown(KeyCode.E))
            Upstairs();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pukki"))
        {
            enterCarText.gameObject.SetActive(true);
            openCar = true;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Pukki"))
        {
            enterCarText.gameObject.SetActive(true);
            openCar = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Pukki"))
        {
            enterCarText.gameObject.SetActive(false);
            openCar = false;
        }
    }

    private void Upstairs()
    {
        SceneManager.LoadScene("Minipeli");
    }
}
