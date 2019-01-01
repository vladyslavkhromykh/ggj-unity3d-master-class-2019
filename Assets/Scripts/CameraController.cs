using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Range(1.0f, 10.0f)]
    public float LookSpeed;
    private Vector2 rotation = Vector2.zero;

    private void Update()
    {
        rotation.x += -Input.GetAxis("Mouse Y");
        rotation.y += Input.GetAxis("Mouse X");

        rotation.x = Mathf.Clamp(rotation.x, -15f, 15f);
        rotation.y = Mathf.Clamp(rotation.y, -15f, 15f);
        Camera.main.transform.localRotation = Quaternion.Euler(rotation.x * LookSpeed, rotation.y * LookSpeed, 0);
    }
}