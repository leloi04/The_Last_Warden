using System.Collections;
using UnityEngine;
using UnityEngine.VFX;

public class GameFinishTrigger : MonoBehaviour
{
    public GameUI_Manager UIgm;
    public VisualEffect teleport; // Kéo VisualEffect teleport vào ô này trong Inspector

    private bool hasFinished;

    private void OnTriggerEnter(Collider other)
    {
        // Kiểm tra nếu đã hoàn thành hoặc đối tượng va chạm không phải là Player
        if (hasFinished || !other.CompareTag("Player"))
        {
            return;
        }

        if (UIgm == null)
        {
            Debug.LogError("GameFinishTrigger requires a GameUI_Manager reference.", this);
            return;
        }

        hasFinished = true;

        // Chạy hiệu ứng teleport nếu có gán VisualEffect
        if (teleport != null)
        {
            teleport.Play();
        }

        // Chạy Coroutine chờ 2 giây trước khi hiển thị màn hình kết thúc game
        StartCoroutine(FinishGameRoutine(2.0f));
    }

    private IEnumerator FinishGameRoutine(float delaySeconds)
    {
        yield return new WaitForSeconds(delaySeconds);
        UIgm.show_GameFinished();
    }
}