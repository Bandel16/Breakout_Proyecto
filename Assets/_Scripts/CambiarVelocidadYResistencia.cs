using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarVelocidadYResistencia : MonoBehaviour
{
    public Opciones opciones; 

    public Bloque bloque;

    public void Start()
    {
        checarDificultad();
    }
    public void checarDificultad()
    {
        if (opciones.NivelDificultad == Opciones.dificultad.normal)
        {
            bloque.velocidad *= 2;
            bloque.resistencia *= 2;
        }
    }
}
