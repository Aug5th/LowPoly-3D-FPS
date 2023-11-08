using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Bullet Impact", menuName = "Scriptable Object/Bullet Impact")]
public class BulletImpactScriptableObject : ScriptableObject
{  
    public BulletImpact Prefab;
    public BulletImpactType BulletImpactType;
}


[Serializable]
public enum BulletImpactType
{
    Normal = 0,
}