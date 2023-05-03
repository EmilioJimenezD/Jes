/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class ControlMuerte : MonoBehaviour, MMEventListener<CorgiEngineEvent>,MMEventListener<PickableItemEvent>
{
    [SerializeField]

    private List <GameObject> corazones;
    private int vidas;
    private int contador_estrellas;

    [SerializeField]

    private int total_estrellas;


    public void Start()
    {

        vidas = corazones.Count;
            
    }

    public virtual void OnMMEvent(CorgiEngineEvent e)
    {
        if(e.EventType == CorgiEngineEventTypes.PlayerDeath)
        {
            if(vidas-1>=0)
            {
                vidas--;
                contador_estrellas = 0;
                corazones[vidas].SetActive(false);

            }
            if(vidas ==0)
            {
            Debug.Log("Game Over");
            }
        }
        Debug.Log(e.EventType);
    }

    public virtual void OnMMEvent(PickableItemEvent e)
    {
        Debug.Log("Pick");
        contador_estrellas++;
        Debug.Log("contador estrellas " + contador_estrellas + " vidas " + vidas);
        if(contador_estrellas == total_estrellas && vidas+1<=corazones.Count)
        {
            corazones[vidas].SetActive(true);
            vidas++;
            contador_estrellas = 0;
        }
    }
    void OnEnable()
    {
       this.MMEventStartListening<CorgiEngineEvent>();
       this.MMEventStartListening<PickableItemEvent>();
    }

    void OnDisable()
    {
    this.MMEventStopListening<CorgiEngineEvent>();
    this.MMEventStartListening<PickableItemEvent>();
    }
}
<<<<<<< HEAD

*/ 
=======
>>>>>>> 253b64f0f8415d2e39e4c44d352ff3707f94c257
