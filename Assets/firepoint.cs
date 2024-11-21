using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public Transform player;  // The player's transform to follow
    public float rotationSpeed = 700f;  // Optional: Speed of rotation

    void Update()
    {
        RotateTowardsMouse();
    }

    void RotateTowardsMouse()
    {
        // Get the mouse position in world space
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;  // Ensure the mouse position is in the 2D plane (no Z rotation)

        // Get the direction from the child object to the mouse
        Vector3 direction = (mousePosition - transform.position).normalized;

        // Calculate the rotation to face the mouse direction
        Quaternion targetRotation = Quaternion.LookRotation(Vector3.forward, direction);

        // Smoothly rotate towards the target rotation
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }

    void LateUpdate()
    {
        transform.position = player.position;
    }
}