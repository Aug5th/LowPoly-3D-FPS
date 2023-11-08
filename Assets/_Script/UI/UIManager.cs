using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MyMonoBehaviour, IObserver
{
    private AmmoText _ammoText;

    [SerializeField] private Subject _playerSubject;
    public void OnNotify(ObserverEvent observerEvent, object param = null)
    {
        if(observerEvent == ObserverEvent.OnUpdateAmmoText)
        {
            UpdateAmmoText(param);
        }
    }

    protected override void LoadComponents()
    {
        _ammoText = GetComponentInChildren<AmmoText>();
        base.LoadComponents();
    }
    private void UpdateAmmoText(object param)
    {
        if (param is GunAmmo)
        {
            var gunAmmo = param as GunAmmo;
            _ammoText.UpdateAmmoText(gunAmmo.currentTapeAmmo, gunAmmo.currentAmmo);
        }
    }

    private void OnEnable()
    {
        _playerSubject.AddObserver(this);
    }

    private void OnDisable()
    {
        _playerSubject.RemoveObserver(this);
    }
}
