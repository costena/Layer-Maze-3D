using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtSmooth : MonoBehaviour
{
    public Transform player_Transform;      // 旋转的物体参数
    public Transform target_Transform;      // 目标目标参数
    // Use this for initialization
    void Start()
    {
        // 初始化旋转数据
        Init_LookAtRotate(player_Transform, target_Transform);
    }
    // Update is called once per frame
    void Update()
    {
        // 开始旋转
        Rotate_Func(player_Transform);
    }
    /// <summary>
    /// 使用LookAt获得角度，并计算出旋转速度
    /// </summary>
    /// <param name="raw_Transform">需要转的物体</param>
    /// <param name="target_Transform">转向面对的物体</param>
    void Init_LookAtRotate(Transform raw_Transform, Transform target_Transform)
    {
        // 保存转身前的角度    
        raw_rotation = raw_Transform.rotation;
        // 获得并保存目标角度    
        raw_Transform.LookAt(target_Transform.position);
        lookat_rotation = raw_Transform.rotation;
        // 恢复到原来的角度   
        raw_Transform.rotation = raw_rotation;
        // 计算出需要的旋转角度    
        float rotate_angle = Quaternion.Angle(raw_rotation, lookat_rotation);
        // 获得lerp速度   
        lerp_speed = per_second_rotate / rotate_angle;
        lerp_tm = 0.0f;
    }
    /// <summary>
    /// 使用 Quaternion.Lerp 进行旋转
    /// </summary>
    /// <param name="raw_Transform">需要转的物体</param>
    void Rotate_Func(Transform raw_Transform)
    {
        // 旋转完成
        if (lerp_tm >= 1)
        {
            raw_Transform.rotation = lookat_rotation;
            return;
        }
        // 使用 Quaternion.Lerp 进行旋转
        lerp_tm += Time.deltaTime * lerp_speed;
        raw_Transform.rotation = Quaternion.Lerp(raw_rotation, lookat_rotation, lerp_tm);
    }
    private Quaternion raw_rotation;                // 保存转身前的角度   
    private Quaternion lookat_rotation;             // 准备面向的角度    
    private float per_second_rotate = 120.0f;       // 转身速度(每秒能转多少度)     
    float lerp_speed = 0.0f;                        // 旋转角度越大, lerp变化速度就应该越慢    
    float lerp_tm = 0.0f;                           // lerp的动态参数
}
