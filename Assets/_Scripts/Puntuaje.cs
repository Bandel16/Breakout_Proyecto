using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntuaje : MonoBehaviour
{
    public Transform transformPuntuajeAlto;
    public Transform transformPuntuajeActual;
    public TMP_Text textoPuntuajeAlto;
    public TMP_Text textoActual;
    public PuntajeAlto PuntajeAltoSO;
   
    
    // Start is called before the first frame update
    void Start()
    {
       transformPuntuajeActual=GameObject.Find("PuntuajeActual").transform;
        transformPuntuajeAlto = GameObject.Find("PuntuajeAlto").transform;
        textoActual=transformPuntuajeActual.GetComponent<TMP_Text>();
        textoPuntuajeAlto=transformPuntuajeAlto.GetComponent<TMP_Text>();
        //if (PlayerPrefs.HasKey("PuntuajeAlto"))
        //{
        //puntuajeAlto = PlayerPrefs.GetInt("PuntuajeAlto"); 

        PuntajeAltoSO.Cargar();
        textoPuntuajeAlto.text = $"PuntuajeAlto{PuntajeAltoSO.puntuajeAlto}";
        PuntajeAltoSO.puntaje = 0;
    }

    private void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        textoActual.text = $"PuntuajeActual: {PuntajeAltoSO.puntaje}";
        if (PuntajeAltoSO.puntaje> PuntajeAltoSO.puntuajeAlto) {
            PuntajeAltoSO.puntuajeAlto = PuntajeAltoSO.puntaje;
            textoPuntuajeAlto.text = $"PuntuajeAlto: {PuntajeAltoSO.puntuajeAlto}";
            PuntajeAltoSO.Guardar();
           // PlayerPrefs.SetInt("PuntuajeAlto", puntos);

        }
    }

    public void AumentarPuntaje(int puntos)
    {
        PuntajeAltoSO.puntaje += puntos;
    }
}
