using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jump_Scenes : MonoBehaviour
{
    public void tz(int i)
    {
        SceneManager.LoadScene(i);
    }

    public void quitgame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void Res()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
