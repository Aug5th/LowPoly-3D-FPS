using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MyMonoBehaviour
{
    [SerializeField] private new Camera camera;
    [SerializeField] private Transform gunHolder;
    [SerializeField] private int currentAmmo;
    [SerializeField] private int currentTapeAmmo;
    [SerializeField] private float dropForwardForce = 5f;
    [SerializeField] private float dropUpwardForce = 2f;

    [SerializeField] private AudioClip pistolSFX;
    [SerializeField] private AudioClip rifleSFX;
    [SerializeField] private AudioClip emptySFX;

    private bool _shooting;
    private bool _reloading;
    private bool _canReload = true;
    private bool _canShoot = true;

    //private Rigidbody _rigidBody;

    private GunBase _equippedGun;
    private GunType _defaultGunType;
    private GunSlot _currentGunSlot;
    private GunSlot _previousGunSlot;

    protected override void LoadComponents()
    {
        _currentGunSlot = GunSlot.SubGun;
        _previousGunSlot = GunSlot.None;
        _defaultGunType = GunType.Pistol;
        
        //_rigidBody = GetComponent<Rigidbody>();
        LoadCamera();
        base.LoadComponents();
    }

    private void Start()
    {
        InitializeDefaultGun();
    }

    private void LoadCamera()
    {
        camera = GetComponentInChildren<Camera>();
        gunHolder = transform.Find("RecoilCamera/MainCamera/GunHolder");
    }
    private void Update()
    {
        Shooting();
    }

    private void InitializeDefaultGun()
    {
        var gunScript = ResourceSystem.Instance.GetGun(_defaultGunType);
        var newGun = Instantiate(gunScript.Prefab);
        newGun.SetStats(gunScript.BaseStats);
        newGun.SetSlot(gunScript.GunSlot);
        newGun.SetType(gunScript.GunType);
        newGun.transform.SetParent(gunHolder);
        newGun.transform.SetLocalPositionAndRotation(Vector3.zero, Quaternion.Euler(Vector3.zero));
        PlayerManager.Instance.Inventory.UpdateItem(newGun.GunSlot, new KeyValuePair<GunType, GunBase>(newGun.GunType, newGun));
        LoadDefaultGun();
    }

    private void LoadDefaultGun()
    {
        if (_currentGunSlot == GunSlot.None)
        {
            return;
        }

        _equippedGun = PlayerManager.Instance.Inventory.GetItem(_currentGunSlot).Value;
        _equippedGun.gameObject.SetActive(true);
        currentTapeAmmo = _equippedGun.gunAmmo.currentTapeAmmo;
        currentAmmo = _equippedGun.gunAmmo.currentAmmo;
        UpdateAmmoText();
    }

    public void TakeGun(GunBase gun)
    {
        if(gun == null)
        {
            return;
        }

        if(gun.GunSlot == _currentGunSlot)
        {
            SwapGun(gun);
        } 
        else if (PlayerManager.Instance.Inventory.GetItem(gun.GunSlot).Key != GunType.None)
        {
            GetGun(gun.GunSlot);
            SwapGun(gun);
        }
        else
        {
            RegisterNewGun(gun);
        }
    }

    private void RegisterNewGun(GunBase gun)
    {
        // save currently gun ammo
        PlayerManager.Instance.Inventory.GetItem(_currentGunSlot).Value.SetCurrentAmmo(currentTapeAmmo, currentAmmo);
        //_gunList[_currentGunSlot].Value.SetCurrentAmmo(currentTapeAmmo, currentAmmo);
        _previousGunSlot = _currentGunSlot;
        PlayerManager.Instance.Inventory.DeactivateAllItems();
        // switch to new gun
        _currentGunSlot = gun.GunSlot;
        PlayerManager.Instance.Inventory.UpdateItem(_currentGunSlot, new KeyValuePair<GunType, GunBase>(gun.GunType, gun));
        _equippedGun = gun;
        _equippedGun.gameObject.SetActive(true);
        currentTapeAmmo = _equippedGun.gunAmmo.currentTapeAmmo;
        currentAmmo = _equippedGun.gunAmmo.currentAmmo;
        _equippedGun.transform.SetParent(gunHolder);
        _equippedGun.transform.SetLocalPositionAndRotation(Vector3.zero, Quaternion.Euler(Vector3.zero));
        _equippedGun.SetColliderTrigger(true);
        _equippedGun.SetRigidbodyKinematic(true);
        UpdateAmmoText();
    }

    private void SwapGun(GunBase gun)
    {
        // update old gun ammo
        PlayerManager.Instance.Inventory.GetItem(_currentGunSlot).Value.SetCurrentAmmo(currentTapeAmmo, currentAmmo);

        // drop old gun
        Debug.Log("Current Gun | Previous Gun = " + _currentGunSlot+ " | "+ _previousGunSlot);
        _equippedGun.transform.SetParent(null);
        _equippedGun.SetColliderTrigger(false);
        _equippedGun.SetRigidbodyKinematic(false);
        float random = Random.Range(-45f, 45f);
        _equippedGun.transform.rotation = Quaternion.Euler(new Vector3(random, random, random));
        _equippedGun.Rigidbody.AddForce(camera.transform.forward * dropForwardForce, ForceMode.Impulse);
        _equippedGun.Rigidbody.AddForce(camera.transform.up * dropUpwardForce, ForceMode.Impulse);

        // equip new gun
        PlayerManager.Instance.Inventory.GetItem(_currentGunSlot).Value.SetCurrentAmmo(currentTapeAmmo, currentAmmo);
        PlayerManager.Instance.Inventory.UpdateItem(_currentGunSlot, new KeyValuePair<GunType, GunBase>(gun.GunType, gun));
        _equippedGun = gun;
        _equippedGun.gameObject.SetActive(true);
        currentTapeAmmo = _equippedGun.gunAmmo.currentTapeAmmo;
        currentAmmo = _equippedGun.gunAmmo.currentAmmo;
        _equippedGun.transform.SetParent(gunHolder);
        _equippedGun.transform.SetLocalPositionAndRotation(Vector3.zero, Quaternion.Euler(Vector3.zero));
        _equippedGun.SetColliderTrigger(true);
        _equippedGun.SetRigidbodyKinematic(true);
        UpdateAmmoText();
    }

    public void GetGun(GunSlot gunSlot)
    {
        if (PlayerManager.Instance.Inventory.GetItem(gunSlot).Value == null)
        {
            return;
        }
        //save ammo 
        _equippedGun.SetCurrentAmmo(currentTapeAmmo, currentAmmo);
        _previousGunSlot = _currentGunSlot;

        PlayerManager.Instance.Inventory.DeactivateAllItems();
        //_currentGunSlot = gunSlot;
        _equippedGun = PlayerManager.Instance.Inventory.GetItem(gunSlot).Value;
        //if (_equippedGun == null)
        //{
        //    return;
        //}
        _currentGunSlot = gunSlot;
        _equippedGun.gameObject.SetActive(true);
        currentTapeAmmo = _equippedGun.gunAmmo.currentTapeAmmo;
        currentAmmo = _equippedGun.gunAmmo.currentAmmo;
        _equippedGun.transform.SetParent(gunHolder);
        _equippedGun.transform.SetLocalPositionAndRotation(Vector3.zero, Quaternion.Euler(Vector3.zero));
        _equippedGun.SetColliderTrigger(true);
        _equippedGun.SetRigidbodyKinematic(true);
        UpdateAmmoText();
    }
    public void SwitchGun()
    {
        if (PlayerManager.Instance.Inventory.GetItem(_previousGunSlot).Key == GunType.None || _currentGunSlot == GunSlot.None)
        {
            return;
        }
        GetGun(_previousGunSlot);
    }

    public void DropGun()
    {
        if (_equippedGun.GunSlot == GunSlot.SubGun)
        {
            Debug.Log("Pistol - Sub gun can't be dropped . xD");
            return;
        }
        Debug.Log("Drop gun : " + _equippedGun.name);
        _equippedGun.transform.SetParent(null);

        _equippedGun.SetColliderTrigger(false);
        _equippedGun.SetRigidbodyKinematic(false);

        float random = Random.Range(-45f, 45f);
        _equippedGun.transform.rotation = Quaternion.Euler(new Vector3(random, random, random));

        _equippedGun.Rigidbody.AddForce(camera.transform.forward * dropForwardForce, ForceMode.Impulse);
        _equippedGun.Rigidbody.AddForce(camera.transform.up * dropUpwardForce, ForceMode.Impulse);

        PlayerManager.Instance.Inventory.UpdateItem(_equippedGun.GunSlot, new KeyValuePair<GunType, GunBase>(GunType.None, null));

        if (PlayerManager.Instance.Inventory.GetItem(_previousGunSlot).Key != GunType.None)
        {
            GetGun(_previousGunSlot);
        }
        else
        {
            GetGun(GunSlot.SubGun);
        }  
    }

    public void StartShoot()
    {
        if(_equippedGun == null)
        {
            return;
        }
        _shooting = !_shooting;
    }
    public void Reload()
    {
        if (_equippedGun == null || !_canReload || _shooting)
        {
            return;
        }
        _reloading = !_reloading;
        if (_reloading)
        {
            _canReload = false;
            _canShoot = false;
            StartCoroutine(Reloading());
        }
    }
    private void Shoot()
    {
        if (_equippedGun == null)
        {
            return;
        }

        if (currentTapeAmmo <= 0)
        {
            //if(CanAutoReloading())
            //{
            //    _shooting = false;
            //    Reload();
            //}
            //else
            {
                Debug.Log("Out of ammo . Press R for reloading");
                AudioSystem.Instance.PlaySound(emptySFX, transform.position, 0.5f);
            }
            return;
        }

        if (_equippedGun.GunType == GunType.Pistol)
        {
            AudioSystem.Instance.PlaySound(pistolSFX, transform.position, 0.5f);
        }
        else
        {
            AudioSystem.Instance.PlaySound(rifleSFX, transform.position, 0.5f);
        }

        Ray ray = camera.ViewportPointToRay(new Vector3(.5f, .5f, 0f));
        ray.origin = camera.transform.position;

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            var bulletImpact = BulletImpactSpawner.Instance.SpawnBulletImpact();
            bulletImpact.transform.SetPositionAndRotation(hit.point + (hit.normal * .002f), Quaternion.LookRotation(hit.normal, Vector3.up));
        }

        PlayerManager.Instance.ProcessRecoil(_equippedGun.VerticalRecoil);

        currentTapeAmmo--;
        _equippedGun.SetCurrentAmmo(currentTapeAmmo, currentAmmo);
        UpdateAmmoText();
    }
    private void Shooting()
    {
        if (!_shooting || !_canShoot)
        {
            return;
        }

        Shoot();
        _canShoot = false;
        StartCoroutine(AllowToShoot());
    }
    private IEnumerator AllowToShoot()
    {
        yield return new WaitForSeconds(_equippedGun.BaseStats.shootRate);
        _canShoot = true;
    }

    private IEnumerator Reloading()
    {
        yield return new WaitForSeconds(_equippedGun.BaseStats.reloadTime);
        UpdateAmmo();
        _canReload = true;
        _canShoot = true;
    }

    private bool CanAutoReloading()
    {
        return currentAmmo != 0;
    }

    private void UpdateAmmo()
    {
        if(currentAmmo <= 0 || _equippedGun == null)
        {
            return;
        }
        if(currentAmmo >= _equippedGun.BaseStats.tapeAmmo)
        {
            currentAmmo -= (_equippedGun.BaseStats.tapeAmmo - currentTapeAmmo);
            currentTapeAmmo = _equippedGun.BaseStats.tapeAmmo;       
        }
        else
        {
            currentTapeAmmo = currentAmmo;
            currentAmmo = 0;
        }
        _equippedGun.SetCurrentAmmo(currentTapeAmmo, currentAmmo);
        UpdateAmmoText();
    }

    private void UpdateAmmoText()
    {
        PlayerManager.Instance.UpdateAmmoText(_equippedGun);
    }

    public void ZoomIn()
    {
        _equippedGun.VerticalRecoil = _equippedGun.BaseStats.verticalRecoil / 2;
    }

    public void ZoomOut()
    {
        _equippedGun.VerticalRecoil = _equippedGun.BaseStats.verticalRecoil;
    }
}
