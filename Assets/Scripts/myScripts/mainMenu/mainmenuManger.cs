using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class mainmenuManger : MonoBehaviour
{

    [SerializeField] private AudioMixer audioMixer;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
    public void SEtvolume(float volume)
    {
        audioMixer.SetFloat("Volume",volume);
    }
    public void setQulity(int qulityIndex)
    {
        QualitySettings.SetQualityLevel(qulityIndex);
    }
}
