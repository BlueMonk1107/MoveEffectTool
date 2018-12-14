using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace MoveEffectTool
{
    public class Show_4 : BaseShow
    {

        protected override void Effect()
        {
            transform.DOMove(transform.position + new Vector3(5, 0, 0), 0.5f)
                .SetEase(Ease.InOutCubic)
                .SetLoops(-1, LoopType.Yoyo);
            transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
            transform.DOScale(new Vector3(1, 1, 1), 0.25f)
                .SetEase(Ease.InOutCubic)
                .SetLoops(-1, LoopType.Yoyo);
        }
    }
}
