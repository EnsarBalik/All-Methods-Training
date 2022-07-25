using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinderHealth : Health, IDamageable<int>
{
    public Material myMat;

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);

        hitFeedBack();

        if (CheckifWeDead())
        {
            OnDeath();
        }
    }

    protected override void hitFeedBack()
    {
        base.hitFeedBack();

        this.gameObject.transform.DOShakeScale(0.2f, 0.1f, 15, 90, false);
        Tween colorTween = myMat.DOBlendableColor(Color.grey, 0.1f);
        colorTween.OnComplete(() => myMat.DOBlendableColor(Color.green, 0.05f));
    }

    protected override void OnDeath()
    {
        base.OnDeath();

        this.gameObject.transform.DOShakeScale(0.2f, 0.1f, 15, 90, false);
        Tween colorTween = myMat.DOBlendableColor(Color.red, 0.1f);
        colorTween.OnComplete(() => Destroy(gameObject));
    }

}
