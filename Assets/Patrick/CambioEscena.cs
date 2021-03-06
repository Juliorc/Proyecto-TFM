using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    [SerializeField] private Animator transicion;
    [SerializeField] private float tiempoTransicion = 1f;
    [SerializeField] private string nombreNivel;
    private bool pauseFlag = true;

    void Update()
    {
        /*if (pauseFlag)
        {
            StartCoroutine(TiempoInicial());
        }

        if (transicion.isActiveAndEnabled)
        {
            transicion.SetBool("TransicionActivaInicio", false);
        }

        if (Input.GetMouseButtonDown(0))
        {
            
        }*/
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            CargarSiguienteEscena();
        }
    }

    public void CargarSiguienteEscena()
    {
        StartCoroutine(CargarEscena(nombreNivel));
    }
    IEnumerator CargarEscena(string escenaNombre)
    {
        transicion.SetTrigger("InicioTransicion");
        transicion.SetBool("TransicionActiva", true);
        yield return new WaitForSeconds(tiempoTransicion);
        transicion.SetBool("TransicionActiva", false);

        SceneManager.LoadScene(escenaNombre);
    }

    IEnumerator TiempoInicial()
    {
        yield return new WaitForSeconds(1);
        pauseFlag = false;
    }
}
