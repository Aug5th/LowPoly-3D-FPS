using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class InputManager : MonoBehaviour
{

    private PlayerInput _input;
    private PlayerInput.OnFootActions _onFoot;
    private PlayerInput.OnHandActions _onHand;

    private void Awake()
    {
        _input = new PlayerInput();
        InitializeOnFootEvents();
        InitializeOnHandEvents();
    }

    private void InitializeOnFootEvents()
    {
        _onFoot = _input.OnFoot;
        _onFoot.Jump.performed += ctx => PlayerManager.Instance.ProcessJump();
        _onFoot.Sprint.performed += ctx => PlayerManager.Instance.ProcessSprint();
        _onFoot.Crouch.performed += ctx => PlayerManager.Instance.ProcessCrouch();
    }

    private void InitializeOnHandEvents()
    {
        _onHand = _input.OnHand;
        _onHand.Shoot.performed += ctx => PlayerManager.Instance.ProcessShoot();
        _onHand.Reload.performed += ctx => PlayerManager.Instance.ProcessReload();
        _onHand.GetFirstWeapon.performed += ctx => PlayerManager.Instance.ProcessGetGun(GunSlot.MainGun);
        _onHand.GetSecondWeapon.performed += ctx => PlayerManager.Instance.ProcessGetGun(GunSlot.SpecialGun);
        _onHand.GetThirdWeapon.performed += ctx => PlayerManager.Instance.ProcessGetGun(GunSlot.SubGun);
        _onHand.SwitchWeapon.performed += ctx => PlayerManager.Instance.ProcessSwitchGun();
        _onHand.DropWeapon.performed += ctx => PlayerManager.Instance.ProcessDropGun();
        _onHand.Interact.performed += ctx => PlayerManager.Instance.ProcessInteract();
        _onHand.Aim.started += ctx => PlayerManager.Instance.ProcessZoom();
        _onHand.Aim.canceled += ctx => PlayerManager.Instance.ProcessZoom();
    }

    private void FixedUpdate()
    {
        PlayerManager.Instance.ProcessMove(_onFoot.Movement.ReadValue<Vector2>());
    }

    private void LateUpdate()
    {
        PlayerManager.Instance.ProcessLook(_onFoot.Look.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        _onFoot.Enable();
        _onHand.Enable();
    }

    private void OnDisable()
    {
        _onFoot.Disable();
        _onHand.Disable();
    }
}
