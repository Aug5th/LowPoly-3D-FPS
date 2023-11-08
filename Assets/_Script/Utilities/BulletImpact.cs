using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class BulletImpact : MyMonoBehaviour
{
    [SerializeField] private float timeToLive = 2f;
    private float _elapsedTime;
    private ObjectPool<BulletImpact> _pool;

    public void SetPool(ObjectPool<BulletImpact> pool)
    {
        _pool = pool;
    }

    public void ResetElapsedTime()
    {
        _elapsedTime = 0f;
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;
        if(_elapsedTime >= timeToLive)
        {
            _pool.Release(this);
        }
    }
}
