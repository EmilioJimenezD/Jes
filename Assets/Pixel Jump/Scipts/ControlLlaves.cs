using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlLlaves : MonoBehaviour
{
    [SerializeField]
    private TMP_Text txt_contador_llaves;
    private int contador_llaves;

    public void Start()
    {

    }

    public int ContadorLlaves()
    {
        return contador_llaves;
    }

    public void ActualizarPuntaje(int valor)
    {
        contador_llaves += valor;
        ActualizarValorUI();
    }

    public void ResetearPuntaje()
    {
        contador_llaves = 0;
    }

    public void ActualizarValorUI()
    {
        txt_contador_llaves.text = "" + contador_llaves;
    }
}
