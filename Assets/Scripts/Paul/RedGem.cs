using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedGem : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (PlayerInventory.Instance.IsInInventory("REDGEM"))
            {
                SceneManager.LoadScene(1);
            }
            else
            {
                InteractionUI.Instance.ShowInteraction("Go collect the redgem");
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        InteractionUI.Instance.HideInteraction();
    }
}
