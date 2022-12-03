using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject settingsMenu;
    private AudioSource audioSource;

    void Start()
    {
        pauseMenu.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown("escape") && Time.timeScale == 1.0f || Input.GetKeyDown(KeyCode.P) && Time.timeScale == 1.0f) {
            Time.timeScale = 0.0f;
            pauseMenu.SetActive(true);
            // audioSource.Play();
        }
    }

    public void ContinueGame() {
        Time.timeScale = 1.0f;
        pauseMenu.SetActive(false);
        // audioSource.Pause();
    }

    public void ExitGame() {
        Debug.Log("Toimii exit");
        Application.Quit();
    }

    public void OpenSettings() {
        settingsMenu.SetActive(true);
        pauseMenu.SetActive(false);
    }

    public void CloseSettings() {
        settingsMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }
}
