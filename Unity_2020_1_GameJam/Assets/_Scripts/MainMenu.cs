using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
   public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame ()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();//Debug.Log("Quit");
#endif
    }

    public AudioMixer audioMixer;
    public void SetVolume(float volume)
    {
        //Debug.Log(volume);
        audioMixer.SetFloat("Volume", volume);
    }
    /*not yet done for build
    Resolution[] resolutions;
    //public Dropdown resolutionDropdown;
    public void SetResolution(int qualityIndex)
    {
        resolutions = Screen.resolutions;
        //QualitySettings.SetQualityLevel(qualityIndex);
    }
    */

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullscreen(bool isFull)
    {
        Screen.fullScreen = isFull;
    }


}
