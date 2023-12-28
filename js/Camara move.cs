using System.Collections;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float moveDistance = 170f; // 移动距离
    public float moveTime = 3f; // 移动所需时间

    void Start()
    {
        StartCoroutine(MoveCameraAfterDelay());
    }

    IEnumerator MoveCameraAfterDelay()
    {
        // 等待3秒
        yield return new WaitForSeconds(3f);

        // 计算目标位置
        Vector3 targetPosition = transform.position - new Vector3(0, moveDistance, 0);

        // 计算每一帧移动的距离
        Vector3 movePerStep = (targetPosition - transform.position) / (60 * moveTime);

        // 往下移动摄像机
        while (Vector3.Distance(transform.position, targetPosition) > 0.01f)
        {
            transform.position += movePerStep;
            yield return null; // 等待下一帧
        }

        // 确保精确到达目标位置
        transform.position = targetPosition;
    }
}