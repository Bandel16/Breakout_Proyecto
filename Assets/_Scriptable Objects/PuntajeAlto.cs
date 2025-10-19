using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PuntajeAlto",menuName = "Herramientas/PuntajeAlto", order =0)]
public class PuntajeAlto : PuntajePersistente
{
    // Start is called before the first frame update
    public int puntaje = 0;
    public int puntuajeAlto = 1000;
}
