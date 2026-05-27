using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class PotionSystem : MonoBehaviour
{
    public Cauldron cauldron;

    public GameManager gameManager;

    public List<IngredientType> currentRecipe = new List<IngredientType>();

    public TMP_Text recipeText;

    int recipeIndex;

    public ParticleSystem sparkEffect;

    public Transform effectPoint;

    void Start()
    {
        SetRandomRecipe();
    }


    public void BrewPotion()
    {
        List<IngredientType> ingredients = cauldron.currentIngredients;

        // зелье зрения
        if (ingredients.Contains(IngredientType.Mushroom) &&
            ingredients.Contains(IngredientType.Water) &&
            ingredients.Count == 2)
        {
            Debug.Log("Зелье зрения получилось!");
            SetRandomRecipe();
            gameManager.AddScore();
            Instantiate(sparkEffect, effectPoint.position, Quaternion.identity);
        }

        // зелье невероятной силы
        else if (ingredients.Contains(IngredientType.Eye) &&
                 ingredients.Contains(IngredientType.Watermelon) &&
                 ingredients.Count == 2)
        {
            Debug.Log("Зелье невероятной силы получилось!");
            SetRandomRecipe();
            gameManager.AddScore();
            Instantiate(sparkEffect, effectPoint.position, Quaternion.identity);
        }

        // зелье супер-лени
        else if (ingredients.Contains(IngredientType.Bone) &&
                 ingredients.Contains(IngredientType.Watermelon) &&
                 ingredients.Contains(IngredientType.Water) &&
                 ingredients.Count == 3)
        {
            Debug.Log("Зелье супер-лени получилось!");
            SetRandomRecipe();
            gameManager.AddScore();
            Instantiate(sparkEffect, effectPoint.position, Quaternion.identity);
        }

        else
        {
            Debug.Log("Ошибка! Неверный рецепт.");
            gameManager.RemoveScore();
        }

        cauldron.ClearCauldron();
    }

    void SetRandomRecipe()
    {
        currentRecipe.Clear();

        recipeIndex = Random.Range(0, 3);

        if (recipeIndex == 0)
        {
            currentRecipe.Add(IngredientType.Mushroom);
            currentRecipe.Add(IngredientType.Water);

            recipeText.text = "Для зелья понадобятся:\n\nгрибочек\nвода";
        }

        else if (recipeIndex == 1)
        {
            currentRecipe.Add(IngredientType.Eye);
            currentRecipe.Add(IngredientType.Watermelon);

            recipeText.text = "Для зелья понадобятся:\n\nглаз\nарбуз";
        }

        else if (recipeIndex == 2)
        {
            currentRecipe.Add(IngredientType.Bone);
            currentRecipe.Add(IngredientType.Watermelon);
            currentRecipe.Add(IngredientType.Water);

            recipeText.text = "Для зелья понадобятся:\n\nкость\nарбуз\nвода";
        }
    }
}