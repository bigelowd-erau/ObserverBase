using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InvokerSubscriber : MonoBehaviour, ISubscriber
{
    public void Subscribe()
    {
        //subscribe to different events
        //event.eventhandler += SetCommand;
        Publisher.RaiseEvent += SetCommand;
        Debug.Log("Invoker Subscribed");
    }
    public void Unsubscribe()
    {
        //Unsubscribe to different events
    }
    public virtual void OnEnable()
    {
        Subscribe();
    }
    //allows for overiding incase more is needed OnEnable in child
    public virtual void OnDisable()
    {
        Unsubscribe();
    }
    //function will be ovveridden by child
    public virtual void SetCommand(/*Command command*/)
    {

    }
}
