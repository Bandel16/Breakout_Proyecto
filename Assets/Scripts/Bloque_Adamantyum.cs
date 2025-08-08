using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Adamantyum : Bloque
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void RebotarBola()
    {
        base.RebotarBola();
        resistencia_Adamantyum -= 1;
        velocidad = 3;
    }
}
