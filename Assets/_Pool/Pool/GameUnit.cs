using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Dùng để xác định loại object này thuộc pool nào (ví dụ Level1, Level2...).
public class GameUnit : MonoBehaviour
{
    private Transform tf;
    public Transform TF
    {
        get
        {
            //tf = tf ?? gameObject.transform;
            if (tf == null)
            {
                tf = transform;
            }
            return tf;
        }
    }

    public PoolType poolType;
}