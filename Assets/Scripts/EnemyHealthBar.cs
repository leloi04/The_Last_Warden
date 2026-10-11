using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{
    public Canvas healthCanvas; // Canvas World Space của thanh máu
    public Slider healthSlider;
    private Camera mainCamera;

    [Header("Hiệu ứng giảm máu")]
    public float lerpSpeed = 5f;

    private float targetValue;
    private bool isInitialized = false;

    void Start()
    {
        // Tự động tìm Main Camera của Scene/Map đang chơi
        mainCamera = Camera.main;

        // Nếu Canvas chưa gắn Event Camera, code sẽ tự gán vào luôn
        if (healthCanvas != null && mainCamera != null)
        {
            healthCanvas.worldCamera = mainCamera;
        }
    }

    void LateUpdate()
    {
        // Luôn xoay thanh máu về hướng Camera chính
        if (mainCamera != null)
        {
            transform.rotation = mainCamera.transform.rotation;
        }

        if (healthSlider != null && isInitialized)
        {
            // Trượt mượt mà giá trị Slider về targetValue
            healthSlider.value = Mathf.Lerp(healthSlider.value, targetValue, Time.deltaTime * lerpSpeed);

            if (Mathf.Abs(healthSlider.value - targetValue) < 0.1f)
            {
                healthSlider.value = targetValue;
            }

            // CHỈ ẨN THANH MÁU KHI MÁU THỰC TẾ (TARGET) VỀ 0 VÀ SLIDER ĐÃ TRƯỢT VỀ 0
            if (targetValue <= 0 && healthSlider.value <= 0.5f)
            {
                if (healthCanvas != null)
                {
                    healthCanvas.gameObject.SetActive(false); // Tắt Canvas chứa thanh máu
                }
                else
                {
                    gameObject.SetActive(false);
                }
            }
        }
    }

    public void UpdateHealth(float currentHealth, float maxHealth)
    {
        if (healthSlider != null)
        {
            healthSlider.maxValue = maxHealth;
            targetValue = currentHealth; // <--- ĐÃ SỬA: Cập nhật targetValue chuẩn xác!

            // Nếu mới spawn quái ra lần đầu, cho thanh máu đầy ngay lập tức
            if (!isInitialized)
            {
                healthSlider.value = currentHealth;
                isInitialized = true;
            }

            // Nếu quái còn sống (máu > 0), đảm bảo Canvas luôn bật
            if (currentHealth > 0 && healthCanvas != null)
            {
                healthCanvas.gameObject.SetActive(true);
            }
        }
    }
}