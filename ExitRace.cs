using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ExitRace : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI exitRaceText;

    private bool openPit;

    private void Start()
    {
        exitRaceText.gameObject.SetActive(false);
    }


    private void Update()
    {
        if (openPit && Input.GetKeyDown(KeyCode.E))
            Inside();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pukki"))
        {
            exitRaceText.gameObject.SetActive(true);
            openPit = true;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Pukki"))
        {
            exitRaceText.gameObject.SetActive(true);
            openPit = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Pukki"))
        {
            exitRaceText.gameObject.SetActive(false);
            openPit = false;
        }
    }

    private void Inside()
    {
        SceneManager.LoadScene("Kartano");
    }
}
