using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace MoveEffectTool
{
    public abstract class BaseManager : MonoBehaviour
    {
        protected abstract string GetKey();

        protected abstract string GetFilesPath();

        // Use this for initialization
        protected virtual void Start()
        {
            GameObject prefab = Resources.Load<GameObject>(ConstValue.PREFAB_NAME);
            Vector2 size = prefab.GetComponent<RectTransform>().sizeDelta;
            GameObject temp = null;
            int index = 0;
            Type typeTemp;
            int column = GetColumnCount();

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < ConstValue.ITEM_COUNT_ROW; j++)
                {
                    index++;
                    string name = GetKey() + "_" + index;
                    typeTemp = Type.GetType(ConstValue.NAMESPACE_NAME + "." + name);

                    if (typeTemp == null) break;

                    temp = Instantiate(prefab, transform);
                    temp.name = name;
                    temp.AddComponent(typeTemp);
                    temp.GetComponent<RectTransform>().anchoredPosition =
                        new Vector2((j + 0.5f) * size.x, -(i + 1f) * size.y);

                }
            }
        }

        private int GetColumnCount()
        {
            if (Directory.Exists(GetFilesPath()))
            {
                int count = Directory.GetFiles(GetFilesPath()).Length;
                return count / ConstValue.ITEM_COUNT_ROW + 1;
            }
            else
            {
                Debug.LogError("根目录路径错误，请在Path.cs中修改RootPath");
                return 0;
            }
        }
    }
}
