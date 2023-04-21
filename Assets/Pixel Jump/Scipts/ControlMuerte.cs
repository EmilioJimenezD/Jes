using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMuerte : MonoBehaviour, MMEventListener<CorgiEngineEvent>,MMEventListener<>

[SerializerField]

    private List <GameObject> corazones;
private interface vidas;

private interface contador_estrellas;
[SerializedField]

private interface total_estrellas;

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
        contador_estrellas = object;
    }
}
void OnEnable(
    {
    this.MMEventStartListening<CorgiEngineEvent>();
this.MMEventStartListening<PickableItemEvent>();
}

Void OnDisable()
{
    this.MMEventStopListening<CorgiEngineEvent>();
    this.MMEventStartListening<PickableItemEvent>();
}

