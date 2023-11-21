using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class WeaponStats
{
    public int damage;
    public float timeToAttack;
}

[CreateAssetMenu]
public class WeaponDataClass : ScriptableObject
{
    public string name;
    public Sprite img;
    public string options;
    public WeaponStats stats;
    public GameObject weaponPrefab;

}
