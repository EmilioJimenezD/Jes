using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

namespace MoreMountains.CorgiEngine
{
    public class AbrirVentana : PickableItem
    {
        protected override void Pick (GameObject picker)
        {
            MMEventManager.TriggerEvent(new MMGameEvent("AbrirVentanaEvent"));
        }

    }
}


