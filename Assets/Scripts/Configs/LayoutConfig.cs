using UnityEngine;

[CreateAssetMenu(menuName = "Configs/LayoutConfig", fileName = "LayoutConfig")]
public class LayoutConfig : ScriptableObject {
    [Tooltip("All board layouts for this config (easy, hard, etc.).")]
    public BoardLayout[] layouts;

    private void OnValidate() {
        if (layouts == null) return;
        foreach (var l in layouts) {
            l.Validate();
        }
    }
}