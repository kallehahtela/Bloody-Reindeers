using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class EliminateBoss : MonoBehaviour
{
    public GameObject muoriSave;
    public GameObject floor5;
    //public Animator anim;
    //[SerializeField] ParticleSystem bloodParticle1;
    //public TextMeshProUGUI activateFight;
    //public GameObject PortaatAlas;
    //public GameObject piiloParketti;

    private void Start()
    {
        //anim = GetComponent<Animator>();
        //PortaatAlas.gameObject.SetActive(false);
        //piiloParketti.gameObject.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Kirves"))
        {
            Activate();
        }
    }

    private void Activate()
    {
        //enemies.gameObject.SetActive(true);
        //anim.Play("boss_dead");
        //bloodParticle1.Play();
        //PortaatAlas.gameObject.SetActive(true);
        //activateFight.gameObject.SetActive(false);
        //piiloParketti.gameObject.SetActive(false);
        //PortaatAlas.gameObject.SetActive(true);
        //SceneManager.LoadScene("SaveMuori");
        muoriSave.gameObject.SetActive(true);
        floor5.gameObject.SetActive(false);
    }
}
