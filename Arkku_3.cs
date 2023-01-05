using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Arkku_3 : MonoBehaviour
{
    
    public GameObject arkku1;
    public GameObject arkku2;
    public GameObject arkku3;
    public GameObject AvainEiOtettu;
    public GameObject AvainOtettu;

    private void Start()
    {
        arkku1.SetActive(false);
        arkku2.SetActive(false);
        arkku3.SetActive(true);
        AvainEiOtettu.SetActive(false);
        AvainOtettu.SetActive(true);

    }
}

