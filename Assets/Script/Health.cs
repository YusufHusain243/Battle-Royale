using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Health : MonoBehaviour
{
    public event Action Dead;
    [SerializeField] private float hp;
    public bool isDead;

    public float Hp{
        get{
            return hp;
        }
        set{
            hp = value;

            if (hp <= 0)
            {
                isDead = true;
                Dead?.Invoke();
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void TakeDamage(float dmgAmount){
        if (isDead) return;
        Hp -= dmgAmount;
    }
}
