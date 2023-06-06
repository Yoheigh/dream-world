﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Random = UnityEngine.Random;

public static class MethodExtensions
{
    // List에서 랜덤한 아이템 가져오기
    public static T RandomItem<T>(this List<T> list)
    {
        if (list.Count == 0)
            throw new IndexOutOfRangeException("List is Empty!");

        var randomIndex = Random.Range(0, list.Count);

        return list[randomIndex];
    }

    // Vector3 값을 int로 반올림 (RoundToInt)
    public static Vector3 GetXYZRound(this Vector3 vector3)
    {
        int x, y, z;

        x = Mathf.RoundToInt(vector3.x);
        y = Mathf.RoundToInt(vector3.y);
        z = Mathf.RoundToInt(vector3.z);

        return new Vector3(x, y, z);
    }

    // Vector3 배열 중에 인수로 받은 Vector3와 가장 가까운 Vector3를 반환
    public static Vector3 ClosestVector3(this Vector3 vector3, Vector3[] vector3s)
    {
        float closest = Mathf.Infinity;
        Vector3 closestVec = Vector3.positiveInfinity;

        for (int i = 0;  i < vector3s.Length; i++)
        {
            float temp = Vector3.Distance(vector3, vector3s[i]);

            if (closest > temp)
            {
                closest = temp;
                closestVec = vector3s[i];
            }
        }
        return closestVec;
    }
}
