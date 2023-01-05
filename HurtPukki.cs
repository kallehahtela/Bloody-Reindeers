using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HurtPukki : MonoBehaviour
{
    private HealthManager healthManager;
    public float waitToHurt = 2f;
    public bool isTouching;
    [SerializeField]
    private int damageToGive = 1;
    
    void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
    }

    void Update()
    {
        /*if (reloading)
        {
            //starts to count down from 2 to 0 
            waitToLoad -= Time.deltaTime;
            //if waitToLoad is 0 new scene will be reloaded
            if (waitToLoad <= 0)
            {
                SceneManager.LoadScene("Floor1");
            }
        }*/

        if (isTouching)
        {
            waitToHurt -= Time.deltaTime;
            if (waitToHurt <= 0)
            {
                healthManager.HurtPukki(damageToGive);
                waitToHurt = 2f;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Pukki")
        {
            //Destroy(other.gameObject);
            //other.gameObject.SetActive(false);
            other.gameObject.GetComponent<HealthManager>().HurtPukki(damageToGive);
            //reloading = true;
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.collider.tag == "Pukki")
        {
            isTouching = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.tag == "Pukki")
        {
            isTouching = false;
            waitToHurt = 2f;
        }
    }
}
