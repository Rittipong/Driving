using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform topViewPoint;
    public Transform driverViewPoint;
    public Transform carTransform; // ��ҧ�ԧö��ѡ

    private bool isDriverView = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            isDriverView = !isDriverView;
        }

        if (isDriverView)
        {
            // �����ͧ������˹������ع��� driverViewPoint ������躹ö
            transform.position = carTransform.TransformPoint(driverViewPoint.localPosition);
            transform.rotation = carTransform.rotation * driverViewPoint.localRotation;
        }
        else
        {
            // ����ͧ��ҹ����ѧö (���˹觤����)
            transform.position = topViewPoint.position;
            transform.rotation = topViewPoint.rotation;
        }
    }
}
