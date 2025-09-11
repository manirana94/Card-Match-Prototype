using UnityEngine;

[CreateAssetMenu(menuName = "Configs/LayoutConfig", fileName = "LayoutConfig")]
public class LayoutConfig : ScriptableObject {
    [Tooltip("All board layouts for this config (easy, hard, etc.).")]
    public BoardLayout[] layouts;

    private void OnValidate() {
        foreach (var layout in layouts) {
            if (!layout.IsValid()) {
                Debug.LogWarning($"{name}: Layout {layout.rows}x{layout.cols} is invalid. Must have an even number of cells.");
            }
        }
    }
}