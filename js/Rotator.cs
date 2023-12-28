using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 100f; // 每秒旋转的度数
   
       void Update()
       {
           // 绕Z轴旋转
           transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
       }
}
