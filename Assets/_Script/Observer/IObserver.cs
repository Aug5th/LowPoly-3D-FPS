using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObserver
{
    public void OnNotify(ObserverEvent observerEvent , object param = null);
}