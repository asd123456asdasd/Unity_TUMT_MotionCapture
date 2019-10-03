﻿using UnityEngine;

public class LearnCSharp : MonoBehaviour
{
    // 欄位 Field
    // 修飾詞 欄位類型 欄位名稱 (指定 值)；
    [Header("分數")]
    [Range(0, 100)]
    public int score = 80;         // 整數
    [Header("速度"), Range(1.5f, 10f)]
    public float speed = 1.5f;     // 浮點數
    [Header("道具"), Tooltip("可以放紅色藥水與藍色藥水")]
    public string prop = "藥水";   // 字串
    [Header("任務")]
    public bool mission = false;   // 布林值 true/false

    // Unity 常用欄位類型
    public Vector2 v2 = new Vector2(7, 77);
    public Vector3 v3 = new Vector3(1, 2, 3);
    public Vector3 zero = Vector3.zero;

    public Color blue = Color.blue;
    public Color red = new Color(0.7f, 0.1f, 0.2f);
}
