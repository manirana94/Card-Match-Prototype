using UnityEngine;

[CreateAssetMenu(menuName = "Configs/CardSet", fileName = "CardSet_Generic")]
public class CardSet : ScriptableObject {
    [Tooltip("Card face sprites (each will automatically be paired).")]
    public Sprite[] faceSprites;

    [Tooltip("Single back sprite shared by all cards.")]
    public Sprite backSprite;
}