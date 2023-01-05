using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;

    private bool flashActive;
    [SerializeField]
    private float flashLenght = 0f;
    private float flashCounter = 0f;
    private SpriteRenderer pukkiSprite;

    // Start is called before the first frame update
    void Start()
    {
        pukkiSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (flashActive)
        {
            if (flashCounter > flashLenght * .99f)
            {
                pukkiSprite.color = new Color(pukkiSprite.color.r, pukkiSprite.color.g, pukkiSprite.color.b, 0f);
            }
            else if (flashCounter > flashLenght * .82f)
            {
                pukkiSprite.color = new Color(pukkiSprite.color.r, pukkiSprite.color.g, pukkiSprite.color.b, 1f);
            }
            else if (flashCounter > flashLenght * .66f)
            {
                pukkiSprite.color = new Color(pukkiSprite.color.r, pukkiSprite.color.g, pukkiSprite.color.b, 0f);
            }
            else if (flashCounter > flashLenght * .49f)
            {
                pukkiSprite.color = new Color(pukkiSprite.color.r, pukkiSprite.color.g, pukkiSprite.color.b, 1f);
            }
            else if (flashCounter > flashLenght * .33f)
            {
                pukkiSprite.color = new Color(pukkiSprite.color.r, pukkiSprite.color.g, pukkiSprite.color.b, 0f);
            }
            else if (flashCounter > flashLenght * .16f)
            {
                pukkiSprite.color = new Color(pukkiSprite.color.r, pukkiSprite.color.g, pukkiSprite.color.b, 1f);
            }
            else if (flashCounter > 0)
            {
                pukkiSprite.color = new Color(pukkiSprite.color.r, pukkiSprite.color.g, pukkiSprite.color.b, 0f);
            }
            else
            {
                pukkiSprite.color = new Color(pukkiSprite.color.r, pukkiSprite.color.g, pukkiSprite.color.b, 1f);
                flashActive = false;
            }
            flashCounter -= Time.deltaTime;
        }
    }

    public void HurtPukki(int damageToGive)
    {
        currentHealth -= damageToGive;
        flashActive = true;
        flashCounter = flashLenght;

        if (currentHealth <= 0)
        {
            //gameObject.SetActive(false);
            SceneManager.LoadScene("MainMenu");
        }
    }
}
