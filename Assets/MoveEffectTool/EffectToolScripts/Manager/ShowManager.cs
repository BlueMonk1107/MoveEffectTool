using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MoveEffectTool
{
    public class ShowManager : BaseManager
    {
        protected override string GetKey()
        {
            return ConstValue.SHOW_KEY;
        }

        protected override string GetFilesPath()
        {
            return Path.ShowPath;
        }
    }
}
