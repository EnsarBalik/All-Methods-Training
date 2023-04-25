using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObejctHealth : Health, IDamageable<int>
{
    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);

        hitFeedBack();

        if (CheckifWeDead())
        {
            OnDeath();
        }
    }
}
