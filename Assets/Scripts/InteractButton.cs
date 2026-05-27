using UnityEngine;

public class InteractButton : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.tag == "DoneButton")
        {
            print("есть контакт");
            FindAnyObjectByType<PotionSystem>().BrewPotion();
        }
        if (collision.gameObject.tag == "RestartButton")
        {
            print("есть контакт");
            FindAnyObjectByType<GameManager>().RestartGame();
        }
    }
}
