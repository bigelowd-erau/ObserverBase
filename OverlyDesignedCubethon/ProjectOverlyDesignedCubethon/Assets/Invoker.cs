using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Invoker : InvokerSubscriber
{
    //string _command;

    //if needed
    /*public override void OnEnable()
    {
        base.OnEnable();
        //do more child things
    }*/

    public override void SetCommand(/*Command command*/)
    {
        //_command = command;
        Debug.Log("Command executed");
    }
    
    public void Execute()
    {

    }
}
