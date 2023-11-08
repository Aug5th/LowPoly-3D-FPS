using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : Subject
{
    private static PlayerManager _instance;
    public static PlayerManager Instance => _instance;

    private PlayerMovement _playerMovement;
    public PlayerMovement PlayerMovement => _playerMovement;

    private PlayerLook _playerLook;
    public PlayerLook PlayerLook => _playerLook;

    private PlayerShoot _playerShoot;
    public PlayerShoot PlayerShoot => _playerShoot;

    private PlayerInteract _playerInteract;
    public PlayerInteract PlayerInteract => _playerInteract;

    private PlayerInventory _inventory = new();
    public PlayerInventory Inventory => _inventory;

    private Recoil _recoil;
    public Recoil Recoil => _recoil;


    private bool _zooming = false;


    protected override void LoadComponents()
    {
        if (_instance == null)
        {
            _instance = this;
        }

        _playerMovement = GetComponent<PlayerMovement>();
        _playerLook = GetComponent<PlayerLook>();
        _playerShoot = GetComponent<PlayerShoot>();
        _playerInteract = GetComponent<PlayerInteract>();
        _recoil = transform.Find("RecoilCamera").GetComponent<Recoil>();
        base.LoadComponents();
    }

    private void Update()
    {
        if(_zooming)
        {
            CameraManager.Instance.Zoom(20, 5);
            _playerShoot.ZoomIn();
        }
        else
        {
            CameraManager.Instance.Zoom(60, 5);
            _playerShoot.ZoomOut();
        }
    }

    public void ProcessMove(Vector2 input)
    {
        _playerMovement.Move(input);
    }

    public void ProcessJump()
    {
        _playerMovement.Jump();
    }

    public void ProcessSprint()
    {
        _playerMovement.Sprint();
    }

    public void ProcessCrouch()
    {
        _playerMovement.Crouch();
    }

    public void ProcessShoot()
    {
        _playerShoot.StartShoot();
    }

    public void ProcessReload()
    {
        _playerShoot.Reload();
    }

    public void ProcessGetGun(GunSlot gunSlot)
    {
        _playerShoot.GetGun(gunSlot);
    }

    public void ProcessSwitchGun()
    {
        _playerShoot.SwitchGun();
    }
    
    public void ProcessDropGun()
    {
        _playerShoot.DropGun();
    }

    public void ProcessInteract()
    {
        _playerInteract.Interact();
    }

    public void ProcessLook(Vector2 input)
    {
        _playerLook.Look(input);
    }

    public void ProcessRecoil(float verticalRecoil)
    {
        _recoil.RecoilFire(verticalRecoil);
    }

    public void ProcessZoom()
    {
        _zooming = !_zooming;
    }

    public void UpdateAmmoText(GunBase gun)
    {
        NotifyObservers(ObserverEvent.OnUpdateAmmoText, gun.gunAmmo);
    }

    public void PickUpGun(GunBase gun)
    {
        _playerShoot.TakeGun(gun);
    }
}
