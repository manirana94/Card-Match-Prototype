using UnityEngine;

[System.Serializable]
public class BoardLayout {
    [Min(1)] public int rows = 2;
    [Min(1)] public int cols = 2;

    public float padding = 16f;
    public float spacing = 8f;
    public float cardAspect = 1.4f;

    public bool IsValid() => (rows * cols) % 2 == 0;

    public void Validate() {
        if ((rows * cols) % 2 != 0) {
            // Force next valid value (make cols even)
            cols += 1;
            Debug.LogWarning($"Adjusted layout to {rows}x{cols} because total must be even.");
        }
    }
}
