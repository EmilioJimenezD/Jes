using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class ControlShuffle : MonoBehaviour, MMEventListener<PickableItemEvent>
{
    public enum ControlShuffleTypes { Victoria}

    private int puntaje;
    [SerializeField]
    private int[] indices = { 0, 1, 2, 3}; 
    // Start is called before the first frame update
    void Start()
    {
        

    }

    public virtual void OnMMEvent(PickableItemEvent e)
    {
        Debug.Log("Pick");
        puntaje++;

        if (puntaje == 3)
        {
            MMEventManager.TriggerEvent(new MMGameEvent("Victoria"));
        }
    } 

    void OnEnable()
    {
        this.MMEventStartListening<PickableItemEvent>();
    }
    void OnDisable()
    {
        this.MMEventStopListening<PickableItemEvent>();
    }
}
