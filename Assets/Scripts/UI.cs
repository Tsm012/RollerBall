using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI ui;
    private int count;
    
    void Awake()
    {
        GlobalEventManager.PickupMessage += HandleMessage;
    }
    
    void HandleMessage()
    {
        ui.text = "Score: " + (++count).ToString();
    }
}
