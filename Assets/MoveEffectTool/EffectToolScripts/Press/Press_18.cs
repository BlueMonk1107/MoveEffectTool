using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace MoveEffectTool
{
    public class Press_18 : BasePress
    {
        protected override void Effect()
        {
            base.Effect();
            transform.DOPunchPosition(new Vector3(80, 0, 0), 0.4f, 4, 1f);
            transform.DOPunchRotation(new Vector3(0, 0, -30), 0.3f, 4, 0.5f).SetDelay(0.1f);
            transform.DOPunchScale(new Vector3(-0.2f, 0.2f, 0), 0.4f, 16, 0.5f);
        }
    }
}
