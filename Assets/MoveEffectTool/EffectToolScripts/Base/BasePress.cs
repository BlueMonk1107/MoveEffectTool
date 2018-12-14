using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MoveEffectTool
{
    public class BasePress : Base
    {
        protected override void Start()
        {
            var button = GetComponent<Button>();
            button.onClick.AddListener(Effect);
        }

        protected override void Effect()
        {
            Debug.LogError("未实现effect方法");
        }

        protected override string GetPathName()
        {
            return Path.PressPath;
        }
    }
}
