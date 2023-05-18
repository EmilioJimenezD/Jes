using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPuntaje : MonoBehaviour
{
    [SerializeField]
    private GameObject ui_puntaje;
    private ControlLlaves control_llaves;

    public static ControlPuntaje Instance { get; private set; }

    public void Start()
    {
        control_llaves = ui_puntaje.GetComponent<ControlLlaves>();
    }

    public void ActualizarPuntaje(int valor_llave)
    {
        control_llaves.ActualizarPuntaje(valor_llave);
    }

    public void ResetearPuntaje()
    {
        control_llaves.ResetearPuntaje();
    }
    public void Awake()
    {
        if(Instance != null && Instance != this) 
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }   
}
