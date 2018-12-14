using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace MoveEffectTool
{
    public class Show_11 : BaseShow
    {

        protected override void Effect()
        {
            transform.DOMove(transform.position + new Vector3(10, 0, 0), 0.2f)
            .SetEase(Ease.InOutSine)
            .SetLoops(-1, LoopType.Yoyo);
        }
    }
}
