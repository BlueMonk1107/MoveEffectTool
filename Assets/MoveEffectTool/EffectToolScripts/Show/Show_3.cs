using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace MoveEffectTool
{
    public class Show_3 : BaseShow
    {

        protected override void Effect()
        {
            transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
            transform.DOScale(new Vector3(1, 1, 1), 0.5f)
                .SetEase(Ease.InOutSine)
                .SetLoops(-1, LoopType.Yoyo);
        }
    }
}
