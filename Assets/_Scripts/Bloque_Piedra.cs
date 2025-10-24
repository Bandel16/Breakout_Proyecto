using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Piedra : Bloque
{

  
    // Start is called before the first frame update
    public  override void Start()
    {
        resistencia = 3;
        checarDificultad();
    }
   

    private void Update()
    {
        if (resistencia<= 0)
        {
            AumentarPuntaje.Invoke();
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
    }

   
}
