using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBase : MyMonoBehaviour , IInteractable
{
    private GunStats _stats;
    public GunStats BaseStats => _stats;
    private GunType _gunType;
    public GunType GunType => _gunType;
    private GunSlot _gunSlot;
    public GunSlot GunSlot => _gunSlot;

    private Rigidbody _rigidBody;
    public Rigidbody Rigidbody => _rigidBody;
    private BoxCollider _boxCollider;
    public BoxCollider BoxCollider => _boxCollider;

    public GunAmmo gunAmmo = new GunAmmo();

    [SerializeField] private float _verticalRecoil;
    public float VerticalRecoil
    {
        get { return _verticalRecoil; }
        set { _verticalRecoil = value; }
    }

    protected override void LoadComponents()
    {
        _rigidBody = GetComponent<Rigidbody>();
        _boxCollider = GetComponent<BoxCollider>();
        base.LoadComponents();
    }

    public virtual void SetStats(GunStats stats)
    {
        _stats = stats;
        gunAmmo.currentTapeAmmo = stats.tapeAmmo;
        gunAmmo.currentAmmo = stats.maxAmmo;
        _verticalRecoil = stats.verticalRecoil;
    }

    public virtual void SetType(GunType type)
    {
        _gunType = type;
    }

    public virtual void SetSlot(GunSlot slot)
    {
        _gunSlot = slot;
    }

    public void SetCurrentAmmo(int currentTapeAmmo , int currentAmmo)
    {
        gunAmmo.currentTapeAmmo = currentTapeAmmo;
        gunAmmo.currentAmmo = currentAmmo;
    }

    public void SetColliderTrigger(bool isTrigger)
    {
        _boxCollider.isTrigger = isTrigger;
    }

    public void SetRigidbodyKinematic(bool isKinematic)
    {
        _rigidBody.isKinematic = isKinematic;
    }

    public void Interact()
    {
        PlayerManager.Instance.PickUpGun(this);
    }
}
public class GunAmmo
{
    public int currentTapeAmmo;
    public int currentAmmo;
    public GunAmmo()
    {
        this.currentTapeAmmo = 0;
        this.currentAmmo = 0;
    }

    public GunAmmo(int currentTapeAmmo, int currentAmmo)
    {
        this.currentTapeAmmo = currentTapeAmmo;
        this.currentAmmo = currentAmmo;
    }
}