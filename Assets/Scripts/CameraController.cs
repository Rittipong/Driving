using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform topViewPoint;
    public Transform driverViewPoint;
    public Transform carTransform; // อ้างอิงรถหลัก

    private bool isDriverView = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            isDriverView = !isDriverView;
        }

        if (isDriverView)
        {
            // ให้กล้องตามตำแหน่งและหมุนตาม driverViewPoint ที่อยู่บนรถ
            transform.position = carTransform.TransformPoint(driverViewPoint.localPosition);
            transform.rotation = carTransform.rotation * driverViewPoint.localRotation;
        }
        else
        {
            // มุมมองด้านบนหลังรถ (ตำแหน่งคงที่)
            transform.position = topViewPoint.position;
            transform.rotation = topViewPoint.rotation;
        }
    }
}
