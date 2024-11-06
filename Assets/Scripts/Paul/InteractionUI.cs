using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteractionUI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] 
    private TextMeshProUGUI interactionText;
    [SerializeField]
    private GameObject Text2;
    
    


    public static InteractionUI Instance;

    private void Awake()
    {
        Instance = this;
    }
    public void ShowInteraction(string text)
    {
        interactionText.gameObject.SetActive(true);
        Text2.gameObject.SetActive(true);
        interactionText.text = text;
    }
    public void HideInteraction()
    {
        interactionText.gameObject.SetActive(false);
        Text2.gameObject.SetActive(false);
    }
}
