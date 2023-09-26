using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPausa : MonoBehaviour
{
    public GameObject pauseMenu;
    // Start is called before the first frame update
    public void pauseButton()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void playButton()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
}
