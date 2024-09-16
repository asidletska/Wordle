using System.Collections;
using UnityEngine;

public class DelayAnimation : MonoBehaviour
{
    public float delay = 0.5f;
    public GameObject PanelInstructions;
    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(delay);
        PanelInstructions.SetActive(false);
    }
    public void OnContinueHandler()
    {
        StartCoroutine(Delay());
        Time.timeScale = 1.0f;
    }
}
