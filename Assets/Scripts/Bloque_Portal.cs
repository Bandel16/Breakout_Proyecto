using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Portal : Bloque
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
        velocidad = 5;
        NumeroDePelotas++;
    }
}
