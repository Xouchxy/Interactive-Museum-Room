using System.Timers;
using TMPro;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class UIManager : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject infoPanel;

    public TextMeshProUGUI titleText;
    public TextMeshProUGUI descriptionText;

    void Start()
    {
        startPanel.SetActive(true);
        infoPanel.SetActive(false);
        Time.timeScale = 0f; // Pause at start
    }

    public void StartExperience()
    {
        startPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ShowInfo(string title, string description)
    {
        infoPanel.SetActive(true);
        titleText.text = title;
        descriptionText.text = description;
    }

    public void CloseInfo()
    {
        infoPanel.SetActive(false);
    }

    public void RestartScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void ExitApp()
    {
        Application.Quit();
    }
}