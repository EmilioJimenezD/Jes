using MoreMountains.CorgiEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonCerrarVentana : MonoBehaviour
{
    public void OnCerrarVentana()
    {
        VentanaSingleton.Instance.Ventana.SetActive(false);
        GameManager.Instance.UnPause();
    }

}
