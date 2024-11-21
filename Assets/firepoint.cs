using UnityEngine;

public class FirepointFollower : MonoBehaviour
{
    void Update()
    {
        // Get the mouse position in the 2D screen space (X, Y)
        Vector3 mousePosition = Input.mousePosition;

        // Convert the screen position to world position (assuming camera is orthographic and the game is top-down)
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // Set the firepoint's Z position to 0 (assuming it's a top-down 2D game and you don't want it to move along the Z axis)
        worldPosition.z = 0f;

        // Move the firepoint to the calculated world position
        transform.position = worldPosition;
    }
}