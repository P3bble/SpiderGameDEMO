using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public Transform player;
    public float rotationSpeed = 700f;

    void Update()
    {
        // this fixed the bottom code
        RotateTowardsMouse();
    }

    void RotateTowardsMouse()
    {
        // Draws a vector from mouse pos to camera
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;

        // Gets direction of mouse
        Vector3 direction = (mousePosition - transform.position).normalized;

        // Mouse direction
        Quaternion targetRotation = Quaternion.LookRotation(Vector3.forward, direction);

        // Rotate towards the targeted rotation
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }

    void LateUpdate()
    {
        // Gets player position
        transform.position = player.position;
    }
}