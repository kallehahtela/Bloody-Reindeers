using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ActivateFight : MonoBehaviour
{
    //public GameObject enemies;
    public Animator anim;
    public GameObject PortaatAlas;
    public GameObject piiloParketti;

    [SerializeField]
    public TextMeshProUGUI activateFight;

    [SerializeField] ParticleSystem waterParticle;

    private void Start()
    {
        anim = GetComponent<Animator>();
        activateFight.gameObject.SetActive(false);
        PortaatAlas.gameObject.SetActive(false);
        piiloParketti.gameObject.SetActive(true);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            Activate();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pukki"))
        {
            activateFight.gameObject.SetActive(true);
        }
    }

    /*private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Pukki"))
        {
            activateFight.gameObject.SetActive(true);
        }
    }*/

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Pukki"))
        {
            activateFight.gameObject.SetActive(false);
        }
    }

    private void Activate()
    {
        //enemies.gameObject.SetActive(true);
        anim.Play("boss_chop");
        waterParticle.Play();
        activateFight.gameObject.SetActive(false);
        piiloParketti.gameObject.SetActive(true);
        PortaatAlas.gameObject.SetActive(false);
    }
}
