using UnityEngine;

public class Ingredient : MonoBehaviour
{
    public IngredientType type;
}

public enum IngredientType
{
    Water,
    Bone,
    Eye,
    Mushroom,
    Watermelon
}