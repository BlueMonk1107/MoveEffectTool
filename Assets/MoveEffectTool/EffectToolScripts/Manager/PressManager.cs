using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace MoveEffectTool
{
    public class PressManager : BaseManager
    {
        protected override string GetKey()
        {
            return ConstValue.PRESS_KEY;
        }

        protected override string GetFilesPath()
        {
            return Path.PressPath;
        }
    }
}
