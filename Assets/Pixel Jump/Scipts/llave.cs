using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class llave: PickableItem
{
    [SerializeField]
    private int valor_llave;

    protected override void Pick(GameObject picker)
    { 

        ControlPuntaje.Instance.ActualizarPuntaje(valor_llave);    
    }
}
