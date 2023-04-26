using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;

public class EscucharVictoria : MonoBehaviour
{
    [SerializeField]
    private GameObject muro;

    public virtual void OnMMEvent(MMGameEvent evento)
    {
        Debug.Log("Auxilioo");
        if (evento.EventName == "victoria")
        {
            Debug.Log("Funciona");
            muro.SetActive(true);
        }
    }
}
