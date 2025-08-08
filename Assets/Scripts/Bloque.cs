using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque : MonoBehaviour
{
    public int resistencia = 1;
    public int resistencia_Adamantyum = 999;
    public int velocidad = 1;
    public int NumeroDePelotas = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (resistencia <= 0)
        {
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
}
