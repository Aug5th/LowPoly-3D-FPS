using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SpawnGun(GunType.Rifle , new Vector3(0,0,0));
        SpawnGun(GunType.Sniper , new Vector3(5f, 0, 0));
        SpawnGun(GunType.SMG, new Vector3(10f, 0, 0));
    }

    private void SpawnGun(GunType gunType , Vector3 position)
    {
        var gunScript = ResourceSystem.Instance.GetGun(gunType);
        var gun = Instantiate(gunScript.Prefab , position , Quaternion.Euler(new Vector3(5f,0,0)));

        gun.SetStats(gunScript.BaseStats);
        gun.SetSlot(gunScript.GunSlot);
        gun.SetType(gunScript.GunType);
        gun.SetCurrentAmmo(gun.BaseStats.tapeAmmo, gun.BaseStats.maxAmmo);
        gun.transform.SetLocalPositionAndRotation(Vector3.zero, Quaternion.Euler(Vector3.zero));

        gun.SetColliderTrigger(true);
        gun.SetRigidbodyKinematic(true);
    }
}
