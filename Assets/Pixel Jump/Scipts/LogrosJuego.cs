
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

public class LogrosJuego : MMAchievementRules, MMEventListener<PickableItemEvent> 

{
    public virtual void OnMMEvent(PickableItemEvent pickableItemEvent) 
    {
        Debug.Log("Recogio algo");

        if (pickableItemEvent.PickedItem!= null)
        {
            if(pickableItemEvent.PickedItem.GetComponent<Coin>() != null)
            {
                MMAchievementManager.AddProgress("Mas cerca de la princesa", 1);
            }
            if (pickableItemEvent.PickedItem.GetComponent<Stimpack>() != null)
            {
                MMAchievementManager.UnlockAchievement("Cura");
            }
        }
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        //this.MMEventStartlistening<PickableItemEvent>();
    }
    protected override void OnDisable()
    {
        base.OnDisable();
        //this.MMEventStoplistening<PickableItemEvent>();
    }
}
