using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Publisher : MonoBehaviour
{
    public delegate void CustomEventHandler();
    public static event CustomEventHandler RaiseEvent;

    void FixedUpdate()
    {
        RaiseEvent?.Invoke();
    }
}
