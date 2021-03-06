using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boton : MonoBehaviour
{

    public GameObject objeto;
    public GameObject cartel;
    public AudioSource botton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetButtonDown("Interactuar") && collision.CompareTag("Player"))
        {
            Destroy(objeto);
           botton.Play();
        }

        if (collision.CompareTag("Player"))
        {
            cartel.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            cartel.SetActive(false);
        }
    }
}

 