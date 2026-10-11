using System.Collections;
using UnityEngine;

public class RisingGate : MonoBehaviour
{
    [Header("Cấu hình đối tượng")]
    public GameObject gateVisual;       // Chọn Gate_Group hoặc Model cổng 3D
    private Collider[] _gateColliders;   // Mảng chứa các Collider của cổng (bao gồm cả các con)

    [Header("Cấu hình chuyển động")]
    public float riseDuration = 2.2f;    // Thời gian nâng cổng lên hoàn toàn (giây)
    public float loweredOffsetY = -3.5f; // Độ sâu hạ xuống ban đầu (mặc định chìm xuống dưới đất)

    private Vector3 _raisedPos;          // Vị trí cao ban đầu (khi dựng đầy đủ)
    private Vector3 _loweredPos;         // Vị trí chìm dưới đất

    private void Awake()
    {
        // Tự động tìm tất cả Collider trên Object này và cả các Object con bên trong
        _gateColliders = GetComponentsInChildren<Collider>();

        if (gateVisual == null)
        {
            gateVisual = gameObject;
        }

        // Lưu lại vị trí khi dựng cổng hoàn chỉnh
        _raisedPos = gateVisual.transform.position;

        // Tính toán vị trí chìm bên dưới mặt đất
        _loweredPos = _raisedPos + Vector3.up * loweredOffsetY;

        // Bắt đầu game: Hạ cổng xuống dưới đất và tắt Collider để đi qua được
        gateVisual.transform.position = _loweredPos;
        SetCollidersEnabled(false);
    }

    // Coroutine thực hiện hiệu ứng nhô cổng từ dưới đất lên
    private IEnumerator RaiseGateAnimation()
    {
        float currentDuration = 0f;
        Vector3 startPos = gateVisual.transform.position;

        while (currentDuration < riseDuration)
        {
            currentDuration += Time.deltaTime;
            gateVisual.transform.position = Vector3.Lerp(startPos, _raisedPos, currentDuration / riseDuration);
            yield return null;
        }

        // Sau khi nhô lên hoàn toàn, đảm bảo đặt đúng vị trí và bật Collider để chặn Player
        gateVisual.transform.position = _raisedPos;
        SetCollidersEnabled(true);
    }

    // Hàm kích hoạt nâng cổng (Gắn vào Trigger Event hoặc gọi từ Script khác)
    public void Raise()
    {
        StartCoroutine(RaiseGateAnimation());
    }

    // Bật/Tắt đồng loạt tất cả Collider của cổng
    private void SetCollidersEnabled(bool isEnabled)
    {
        if (_gateColliders != null)
        {
            foreach (Collider col in _gateColliders)
            {
                col.enabled = isEnabled;
            }
        }
    }

    // Thêm đoạn này vào trong RisingGate.cs để test nhanh bằng bàn phím
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Bấm phím Space để nâng cổng lên
        {
            Raise();
        }
    }
}