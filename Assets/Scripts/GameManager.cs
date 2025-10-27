using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Transform player;
    [SerializeField] GameObject FinishPanel;
    [SerializeField] GameObject TapToStartText;
    public void gameover()
    {
        SceneManager.LoadScene(0);
    }

    private void Start()
    { 
        Time.timeScale = 0f;
    }

    private void Update()
    {
        TapToStart();
        if(player.position.y < -0.5)
        {
            gameover();
        }
    }

    private void TapToStart()
    {
        if (Input.anyKeyDown)
        {
            TapToStartText.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    public void finishLevel()
    {
        FinishPanel.SetActive(true);
        StartCoroutine(Delay());
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(1);
    }
}
