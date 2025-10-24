using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bola : MonoBehaviour
{
    public bool isGameStarted = false;
    Vector3 ultimaposicion = Vector3.zero;
    Vector3 direccion = Vector3.zero;
    Rigidbody rigidbody;
    private ControlBordes control;
    public UnityEvent BolaDestruida= new UnityEvent();
    public Opciones opciones;

    private void Awake()
    {
        control = GetComponent<ControlBordes>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Vector3 posicionInicial = GameObject.FindGameObjectWithTag("Jugador").transform.position;
        posicionInicial.y += 3;
        this.transform.position = posicionInicial;
        this.transform.SetParent(GameObject.FindGameObjectWithTag("Jugador").transform);
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)||Input.GetButton("Submit")) {
            if (!isGameStarted)
            {
                isGameStarted = true;
                this.transform.SetParent(null);
                GetComponent<Rigidbody>().velocity = Vector3.up* opciones.velocidadBola;
            }
        }
        if (control.salioAbajo)
        {
            BolaDestruida.Invoke();
            Destroy(this.gameObject);
        }
        if (control.salioArriba)
        {
            direccion=transform.position - ultimaposicion;
            Debug.Log("La bola toco el borde superior");
            direccion.y *=-1;
            direccion = direccion.normalized;
            rigidbody.velocity=opciones.velocidadBola*direccion;
            control.salioArriba = false;
            control.enabled = false;
            Invoke("HabilitarControl", 0.5f);
        }

        if (control.salioDerecha)
        {
            direccion = transform.position - ultimaposicion;
            Debug.Log("La bola toco el borde derecho");
            direccion.x *= -1;
            direccion = direccion.normalized;
            rigidbody.velocity = opciones.velocidadBola * direccion;
            control.salioDerecha = false;
            control.enabled = false;
            Invoke("HabilitarControl", 0.5f);
        }

        if (control.salioIzquierda)
        {
            direccion = transform.position - ultimaposicion;
            Debug.Log("La bola toco el borde izquierdo");
            direccion.x *= -1;
            direccion = direccion.normalized;
            rigidbody.velocity = opciones.velocidadBola * direccion;
            control.salioIzquierda = false;
            control.enabled = false;
            Invoke("HabilitarControl", 0.5f);
        }

    }
    private void HabilitarControl()
    {
        control.enabled = true;
    }
    private void FixedUpdate()
    {
        ultimaposicion = transform.position;
    }

    public void LateUpdate()
    {
        if(direccion!=Vector3.zero) direccion=Vector3.zero;
    }

    public void checarVelocidad()
    {
        if (opciones.NivelDificultad == Opciones.dificultad.normal)
        {
            opciones.velocidadBola *= 2f;

        }

        if (opciones.NivelDificultad == Opciones.dificultad.facil)
        {
            opciones.velocidadBola *= 1f;

        }

        if (opciones.NivelDificultad == Opciones.dificultad.dificil)
        {
            opciones.velocidadBola *= 3f;

        }


    }
}
