using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace MoveEffectTool
{
    public class Press_11 : BasePress
    {
        protected override void Effect()
        {
            base.Effect();
            transform.DOPunchPosition(new Vector3(0, 40, 0), 0.4f, 4, 0.5f);
            transform.DOPunchScale(new Vector3(0.4f, 0, 0), 0.3f, 4, 0.5f).SetDelay(0.1f);
        }
    }
}
