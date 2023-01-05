using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MuoriSaveToMainMenu : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI downText;

    private bool openStairs;

    private void Start()
    {
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
        SceneManager.LoadScene("MainMenu");
    }
}
