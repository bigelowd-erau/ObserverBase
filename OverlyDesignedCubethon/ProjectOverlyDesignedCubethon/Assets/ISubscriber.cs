using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface ISubscriber
{
    void Subscribe();
    void Unsubscribe();
    void OnEnable();
    void OnDisable();
}
