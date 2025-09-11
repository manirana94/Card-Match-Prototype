using UnityEngine;

[System.Serializable]
public class BoardLayout {
    [Min(1)] public int rows = 2;
    [Min(1)] public int cols = 2;

    [Header("Visuals")]
    public float padding = 16f;
    public float spacing = 8f;
    [Tooltip("Height/Width ratio for cards")] 
    public float cardAspect = 1.4f;

    /// <summary>
    /// Must allow pairs, so total cells must be even.
    /// </summary>
    public bool IsValid() => (rows * cols) % 2 == 0;
}