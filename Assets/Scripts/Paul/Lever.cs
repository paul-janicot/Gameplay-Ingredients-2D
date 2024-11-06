using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    [SerializeField]
    private Sprite SwitchLeft;
    [SerializeField]
    private Sprite SwitchRight;
    private bool isE = false;
    private bool isFix = false;
    [SerializeField]
    private GameObject bridge;
    // Start is called before the first frame update
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
            isE = true;
       
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("triggerenter");
            InteractionUI.Instance.ShowInteraction("To activate lever");
            if (PlayerInventory.Instance.IsInInventory("LEVERHANDLE") && isE)
            {
                GetComponent<SpriteRenderer>().sprite = SwitchLeft;
                PlayerInventory.Instance.RemoveItemFromInventory("LEVERHANDLE");
                isFix = true;
                isE = false;
            }
            if (isFix && isE)
            {
                GetComponent<SpriteRenderer>().sprite = SwitchRight;
                bridge.GetComponent<Animator>().SetTrigger("Down");
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("triggerexit");
            InteractionUI.Instance.HideInteraction();
        }
    }
}
