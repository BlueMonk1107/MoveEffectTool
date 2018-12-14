using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace MoveEffectTool
{
    public class Show_2 : BaseShow
    {

        protected override void Effect()
        {
            Image image = GetComponent<Image>();
            image.DOFade(0.4f, 0.5f)
                .SetEase(Ease.Linear)
                .SetLoops(-1, LoopType.Yoyo);
        }
    }
}
