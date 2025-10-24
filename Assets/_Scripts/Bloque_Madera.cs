using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Madera : Bloque
{

    
    // Start is called before the first frame update
    public override void Start()
    {
        resistencia = 2;
        checarDificultad();

    }
   

    private void Update()
    {
        if (resistencia <= 0)
        {
            AumentarPuntaje.Invoke();
            Destroy(this.gameObject);
        }
    }

    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
    }

  
}
