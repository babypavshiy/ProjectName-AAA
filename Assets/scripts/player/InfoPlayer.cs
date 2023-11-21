using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoPlayer : MonoBehaviour
{
    public float hp = 100f;
    public float maxHP = 100f;
    public float hpDecrease = 0.005f;
    public float curExp = 0f;
    public float maxExp = 100f;
    public int curLvl = 1;
    public GameObject level;
    public bool fl = true;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (fl)
        {
            hp -= hpDecrease;
        }
    }

    public void addExp(float exp)
    {
        curExp += exp;
        if (curExp / maxExp >= 1)
        {
            curLvl += 1;
            curExp = maxExp % curExp;
            maxExp += 100 * (1 + 0.1f * curLvl);
            level.GetComponent<exp>().newLvl(curLvl);
        }
    }

    public void TakeDamage(float damage)
    {
        hp -= damage;
        if(hp < 0f)
        {
            Die();
        }
    }

    public void TakeHealth(float health)
    {
        if (hp + health <= maxHP)
        {
            hp += health;
        }
        else
        {
            hp = maxHP;
        }
    }

    private void Die()
    {
        //Time.timeScale = 0;
    }
}
