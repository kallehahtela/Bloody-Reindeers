using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController2 : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settingsMenu;
    public GameObject creditsMenu;
    public GameObject howToPlayMenu;

    
    public void Play()
    {
        SceneManager.LoadScene("Kartano");
    }

    public void Menu()
    {
        mainMenu.gameObject.SetActive(true);
        settingsMenu.gameObject.SetActive(false);
        creditsMenu.gameObject.SetActive(false);
        howToPlayMenu.gameObject.SetActive(false);
    }

    public void Settings()
    {
        mainMenu.gameObject.SetActive(false);
        settingsMenu.gameObject.SetActive(true);
        creditsMenu.gameObject.SetActive(false);
        howToPlayMenu.gameObject.SetActive(false);
    }

    public void HowToPlay()
    {
        mainMenu.gameObject.SetActive(false);
        settingsMenu.gameObject.SetActive(false);
        creditsMenu.gameObject.SetActive(false);
        howToPlayMenu.gameObject.SetActive(true);
    }

    public void Credits()
    {
        mainMenu.gameObject.SetActive(false);
        settingsMenu.gameObject.SetActive(false);
        creditsMenu.gameObject.SetActive(true);
        howToPlayMenu.gameObject.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }

    
}
