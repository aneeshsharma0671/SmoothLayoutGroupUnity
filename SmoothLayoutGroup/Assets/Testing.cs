using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    public int a = 0;
    public int b = 0;
    public Transform Parent;

    [ContextMenu("SwapIndex")]
    public void SwapIndex()
    {
        int childCount = Parent.childCount;
        if (a < 0 || a >= childCount || b < 0 || b >= childCount)
        {
            Debug.LogError("Index out of range");
            return;
        }
        Transform childA = Parent.GetChild(a);
        Transform childB = Parent.GetChild(b);
        childA.SetSiblingIndex(b);
        childB.SetSiblingIndex(a);

    }
}
