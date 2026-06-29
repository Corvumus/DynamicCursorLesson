using AYellowpaper.SerializedCollections;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    public enum CursorType
    {
        Normal,
        Attack,
        Interact,
    }

    public static CursorManager Instance { get; private set; }
    [SerializeField] private SerializedDictionary<CursorType, CursorData> cursorTextures;

    private void Awake()
    {
        Instance = this;
    }

    public void SetCursor(CursorType type)
    {
        CursorData data = cursorTextures[type];

        if (data == null)
            return;

        Cursor.SetCursor(data.texture, data.hotspot, CursorMode.Auto);
    }
}