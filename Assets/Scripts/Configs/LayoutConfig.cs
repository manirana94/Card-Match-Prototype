using UnityEngine;

[CreateAssetMenu(menuName = "Configs/LayoutConfig")]
public class LayoutConfig : ScriptableObject {
    [Tooltip("List of possible board layouts (rows x cols).")]
    public Vector2Int[] layouts = {
        new Vector2Int(2, 2),
        new Vector2Int(3, 3),
        new Vector2Int(4, 4),
        new Vector2Int(5, 6),
        new Vector2Int(6, 6)
    };
}
