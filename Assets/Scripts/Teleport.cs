using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.VFX;

public class Teleport : MonoBehaviour
{
    public GameUI_Manager UIgm;
    public VisualEffect teleport;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && UIgm.currentState == GameUI_Manager.GameUI_State.GameLevelUp)
        {
            if (teleport != null) teleport.Play();
            StartCoroutine(Delayed(0.7f));
        }
    }

    private IEnumerator Delayed(float seconds)
    {
        yield return new WaitForSeconds(seconds);

        // Tự động lấy chỉ số Scene hiện tại và nạp Scene kế tiếp trong Build Settings
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

        // Kiểm tra xem có Scene tiếp theo không trước khi Load
        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            Debug.Log("Đã hết màn chơi hoặc chưa add Map tiếp theo vào Build Settings!");
        }
    }
}