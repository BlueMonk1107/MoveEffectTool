using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace MoveEffectTool
{
    public class Press_2 : BasePress
    {
        protected override void Effect()
        {
            base.Effect();
            transform.DOPunchScale(new Vector3(0, -0.2f, 0), 0.4f, 12, 0.5f);
        }
    }
}