using UnityEngine;

public class CursorObject : MonoBehaviour
{
    [SerializeField] private CursorManager.CursorType cursorType;

    private void OnMouseEnter()
    {
        CursorManager.Instance.SetCursor(cursorType);
    }

    private void OnMouseExit()
    {
        CursorManager.Instance.SetCursor(CursorManager.CursorType.Normal);
    }
}