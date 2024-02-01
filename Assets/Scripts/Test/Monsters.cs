using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monsters : MonoBehaviour, IDamagable
{
    public Condition health;

    private void Start()
    {
        health.curValue = health.startValue;
    }

    public void TakePhysicalDamage(int damageAmount)
    {
        Debug.Log("몬스터 데미지 입는중");
        health.Subtract(damageAmount);
    }
}
