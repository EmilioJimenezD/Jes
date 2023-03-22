using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class Muro : MonoBehaviour
{
    [SerializeField]
    private GameObject muro;
    private ControlLlaves control_llaves;

    public void Start()
    {
        control_llaves = this.transform.parent.GetComponent<ControlLlaves>();
    }

    public void Update()
    {
        if(control_llaves.ContadorLlaves()==2)
        {
            CambiarEstado(false);
        }
        if (control_llaves.ContadorLlaves() == 3)
        {
            MMSceneLoadingManager.LoadScene("Nivel 2");
        }
    }

    public void CambiarEstado(bool estado)
    {
        muro.SetActive(estado);
    }
}
