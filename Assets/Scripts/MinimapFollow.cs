using UnityEngine;

public class MinimapFollow : MonoBehaviour
{
    public Transform target; // Dẫn chiếu tới Player
    public float height = 20f; // Độ cao camera nhìn xuống

    void LateUpdate()
    {
        if (target != null)
        {
            // Cập nhật vị trí Camera theo Player nhưng giữ nguyên độ cao Y
            Vector3 newPosition = target.position;
            newPosition.y += height;
            transform.position = newPosition;

            // Giữ góc xoay cố định nhìn từ trên xuống (X = 90)
            transform.rotation = Quaternion.Euler(90f, 0f, 0f);
        }
    }
}