using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject CanvasMenu;
    public GameObject CanvasGame;
    public GameObject PanelInstructions;

    public void OnPlayHandler()
    {
        CanvasMenu.SetActive(false);
        CanvasGame.SetActive(true);
        Time.timeScale = 0f;
    }

    public void OnContinueHandler()
    {
        PanelInstructions.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
