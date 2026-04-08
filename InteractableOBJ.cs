using System.Drawing;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public string exhibitName;
    public string description;

    private Renderer rend;
    private Color originalColor;

    public UIManager uiManager;

    void Start()
    {
        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;
    }

    public void OnHover()
    {
        rend.material.color = Color.yellow;
    }

    public void OnExit()
    {
        rend.material.color = originalColor;
    }

    public void OnClick()
    {
        uiManager.ShowInfo(exhibitName, description);
    }
}