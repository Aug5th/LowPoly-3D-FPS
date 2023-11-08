using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Subject : MyMonoBehaviour
{
    private List<IObserver> _observers = new List<IObserver>();

    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    protected void NotifyObservers(ObserverEvent observerEvent , object param = null)
    {
        _observers.ForEach((_observers) =>
        {
            _observers.OnNotify(observerEvent, param);
        });
    }
}
