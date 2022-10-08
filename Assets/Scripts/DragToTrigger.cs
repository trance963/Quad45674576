using UnityEngine;

public class DragToTrigger : MonoBehaviour
{
    Vector3 mousePositionOffset;
    public float Sensityvity;


    public void OnMouseDown()
    {
        mousePositionOffset = transform.position - Input.mousePosition * Sensityvity;
    }

    public void OnMouseDrag()
    {
        transform.position = Input.mousePosition * Sensityvity + mousePositionOffset;
    }
}
