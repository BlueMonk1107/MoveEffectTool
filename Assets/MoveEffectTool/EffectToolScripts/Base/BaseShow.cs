using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MoveEffectTool
{
    public class BaseShow : Base
    {
        protected override void Start()
        {
            Effect();
        }

        protected override void Effect()
        {
            Debug.LogError("未实现effect方法");
        }

        protected override string GetPathName()
        {
            return Path.ShowPath;
        }
    }
}
