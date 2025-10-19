using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class MuestraEventos : MonoBehaviour
{
    public UnityEvent MiEventoUnity;
    public event EventHandler EnCasoDeEspacioPresionado;
    // Start is called before the first frame update
    void Start()
    {
        EnCasoDeEspacioPresionado += EvenetoEscuchado;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            EnCasoDeEspacioPresionado?.Invoke(this,EventArgs.Empty);
            MiEventoUnity.Invoke();
        }
    }

    public void EvenetoEscuchado(object sender, EventArgs e)
    {
        Debug.Log("el evento se esucho correctamente");
    }

    public void EventoUnity()
    {
        Debug.Log("El evento Unity se lanzo correctamente");
    }
}
