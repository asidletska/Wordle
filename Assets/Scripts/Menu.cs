using System.Collections;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject CanvasMenu;
    public GameObject CanvasGame;
    public float delay = 0.3f;

    public void OnPlayHandler()
    {
        StartCoroutine(SwitchCanvas());
        //Time.timeScale = 0f;
    }
    private IEnumerator SwitchCanvas()
    {
        yield return new WaitForSeconds(delay);
        CanvasMenu.SetActive(false);
        CanvasGame.SetActive(true);
    }

}
