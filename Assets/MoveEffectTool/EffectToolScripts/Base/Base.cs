using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MoveEffectTool
{
    public abstract class Base : MonoBehaviour,IPointerClickHandler
    {

        // Use this for initialization
        protected virtual void Start()
        {
           
        }

        protected abstract void Effect();

        protected abstract string GetPathName();

        public virtual void OnPointerClick(PointerEventData eventData)
        {
            if (eventData.button == PointerEventData.InputButton.Right)
                MouseButtonRightClick();
        }

        private void MouseButtonRightClick()
        {
            if (Directory.Exists(GetPathName()))
            {
                string filePath = GetPathName() + transform.name + ".cs";
                if (File.Exists(filePath))
                {
                    string context = File.ReadAllText(filePath);
                    string[] list = context.Split('{', '}');
                    int index = 0;
                    for (int i = 0; i < list.Length; i++)
                    {
                        if (list[i].Contains("void Effect()"))
                        {
                            index = i + 1;
                            break;
                        }
                    }

                    if (index == 0)
                    {
                        Debug.Log("未找到Effect方法，复制代码失败");
                    }
                    else
                    {
                        GUIUtility.systemCopyBuffer = list[index];
                        Debug.Log("复制代码成功");
                    }
                   
                }
            }
            else
            {
                Debug.LogError("根目录路径错误，请在Path.cs中修改RootPath");
            }
        }
    }
}
