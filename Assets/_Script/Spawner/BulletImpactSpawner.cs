using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class BulletImpactSpawner : Singleton<BulletImpactSpawner>
{
    
    private ObjectPool<BulletImpact> _pool;


    private void Start()
    {
        InitializePool();
    }

    private void InitializePool()
    {
        _pool = new ObjectPool<BulletImpact>(() =>
        {
            var bulletImpact = ResourceSystem.Instance.GetBulletImpact(BulletImpactType.Normal);
            return Instantiate(bulletImpact.Prefab);
        }, bulletImpact =>
        {
            bulletImpact.gameObject.SetActive(true);   
        }, bulletImpact =>
        {
            bulletImpact.gameObject.SetActive(false);
        }, bulletImpact => 
        {
            Destroy(bulletImpact.gameObject);
        },false,20,40);
    }

    public BulletImpact SpawnBulletImpact()
    {
        var bulletImpact = _pool.Get();
        bulletImpact.SetPool(_pool);
        bulletImpact.ResetElapsedTime();
        bulletImpact.transform.SetParent(transform);
        return bulletImpact;
    }
}
