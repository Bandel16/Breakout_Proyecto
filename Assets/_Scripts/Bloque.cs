using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bloque : MonoBehaviour
{
    public int resistencia = 1;
    public int resistencia_Adamantyum = 999;
    public int velocidad=1;
    public int NumeroDePelotas = 1;
    public UnityEvent AumentarPuntaje;
    public Opciones opciones;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bola")
        {
            RebotarBola(collision);
        }
    }

    public virtual void RebotarBola(Collision collision)
    {
        Vector3 direccion = collision.contacts[0].point - transform.position;
        direccion = direccion.normalized;
        collision.rigidbody.velocity = collision.gameObject.GetComponent<Bola>().opciones.velocidadBola * direccion;
        resistencia--;
    }

    // Start is called before the first frame update
    public virtual void Start()
    {
        velocidad = 1;
        checarDificultad();
    }

    // Update is called once per frame
    void Update()
    {
        if (resistencia <= 0)
        {
            AumentarPuntaje.Invoke();
            Destroy(this.gameObject);
        }
        if (resistencia_Adamantyum <= 0)
        {
            Destroy(gameObject);//Se supone que destruye todos los objetos hijos
            Debug.Log("Felcidades, Logan estaria orgulloso");
        }
    }

    public virtual void RebotarBola()
    {

    }
    public void checarDificultad()
    {
        if (opciones.NivelDificultad == Opciones.dificultad.normal)
        {
            velocidad *= 2;
            resistencia *= 2;
        }

        if (opciones.NivelDificultad == Opciones.dificultad.facil)
        {
            velocidad *= 1;
            resistencia *= 1;
        }

        if (opciones.NivelDificultad == Opciones.dificultad.dificil)
        {
            velocidad *= 3;
            resistencia *= 3;
        }
    }
}
