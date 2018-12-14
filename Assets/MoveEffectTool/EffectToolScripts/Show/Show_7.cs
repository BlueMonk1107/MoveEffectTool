using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace MoveEffectTool
{
    public class Show_7 : BaseShow
    {

        protected override void Effect()
        {
            transform.DOMove(transform.position + new Vector3(0, 10, 0), 1f)
            .SetEase(Ease.InOutElastic)
            .SetLoops(-1, LoopType.Yoyo);
        }
    }
}
