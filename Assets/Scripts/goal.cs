using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goal : MonoBehaviour
{
    public GameObject MainText;

    // Use this for initialization
    void Start()
    {
        MainText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }


    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("OnTrriger");
            MainText.SetActive(true);
        }
    }



}



