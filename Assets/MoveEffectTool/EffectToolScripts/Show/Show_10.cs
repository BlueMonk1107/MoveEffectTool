using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace MoveEffectTool
{
    public class Show_10 : BaseShow
    {

        protected override void Effect()
        {
            transform.eulerAngles = new Vector3(0, 0, -10);
            transform.DORotate(new Vector3(0, 0, 10), 0.5f)
           .SetEase(Ease.InOutSine)
           .SetLoops(-1, LoopType.Yoyo);
        }
    }
}
