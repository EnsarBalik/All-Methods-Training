using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Health : MonoBehaviour
{
    public int health;

    public virtual void TakeDamage(int damage)
    {
        health -= damage;
    }

    protected virtual void hitFeedBack()
    {
        Debug.Log("Hit feedback");
    }

    protected virtual void OnDeath()
    {
        Debug.Log("You dead my friend");
    }

    protected bool CheckifWeDead()
    {
        if (health <= 0)
        {
            health = 0;
            return true;
        }
        return false;
    }
}
