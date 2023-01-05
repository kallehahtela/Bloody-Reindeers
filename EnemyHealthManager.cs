using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthManager : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;

    private AudioSource hurtAudio;
    private bool flashActive;
    [SerializeField]
    private float flashLenght = 0f;
    private float flashCounter = 0f;
    private SpriteRenderer poroSprite;



    void Start()
    {
        poroSprite = GetComponent<SpriteRenderer>();
        hurtAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (flashActive)
        {
            if (flashCounter > flashLenght * .99f)
            {
                poroSprite.color = new Color(poroSprite.color.r, poroSprite.color.g, poroSprite.color.b, 0f);
            }
            else if (flashCounter > flashLenght * .82f)
            {
                poroSprite.color = new Color(poroSprite.color.r, poroSprite.color.g, poroSprite.color.b, 1f);
            }
            else if (flashCounter > flashLenght * .66f)
            {
                poroSprite.color = new Color(poroSprite.color.r, poroSprite.color.g, poroSprite.color.b, 0f);
            }
            else if (flashCounter > flashLenght * .49f)
            {
                poroSprite.color = new Color(poroSprite.color.r, poroSprite.color.g, poroSprite.color.b, 1f);
            }
            else if (flashCounter > flashLenght * .33f)
            {
                poroSprite.color = new Color(poroSprite.color.r, poroSprite.color.g, poroSprite.color.b, 0f);
            }
            else if (flashCounter > flashLenght * .16f)
            {
                poroSprite.color = new Color(poroSprite.color.r, poroSprite.color.g, poroSprite.color.b, 1f);
            }
            else if (flashCounter > 0)
            {
                poroSprite.color = new Color(poroSprite.color.r, poroSprite.color.g, poroSprite.color.b, 0f);
            }
            else
            {
                poroSprite.color = new Color(poroSprite.color.r, poroSprite.color.g, poroSprite.color.b, 1f);
                flashActive = false;
            }
            flashCounter -= Time.deltaTime;
        }
    }

    public void HurtEnemy(int damageToGive)
    {
        currentHealth -= damageToGive;
        flashActive = true;
        flashCounter = flashLenght;

        if (currentHealth <= 0)
        {
            hurtAudio.Play();
            Destroy(gameObject, .5f);
            
        }
    }
}
