using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using System.Threading;

public class Game_manegerScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_Text;
    private float count = 0;
    [SerializeField] private GameObject pausePanal;
    private int start_count = 0;
    [SerializeField] private TextMeshProUGUI startCounttext;
    [SerializeField] private GameObject startcountText;
    [SerializeField] private TextMeshProUGUI finalscoreText;
    // Start is called before the first frame update
 
    void Start()
    {
    //Time.timeScale = 0f;
        m_Text.text = "0";
      // StartCoroutine(startGamecount());
        StartCoroutine(scoreCount());
    }

    // Update is called once per frame
 
    IEnumerator startGamecount()
    {while (start_count < 4)
        {
            yield return new WaitForSeconds(1);
            start_count++;
            Debug.Log(start_count.ToString());
            startCounttext.text = start_count.ToString();
        }
        Time.timeScale = 1f;
        startcountText.SetActive(false);
        
    }
    IEnumerator scoreCount()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            count++;
            m_Text.text = count.ToString();
            finalscoreText.text= count.ToString();
        }
    }
    public void newLevel (){ 
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void restartThisLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale= 1.0f;
    }
    public void pause(bool pause)
    {
        pause = true;
        Time.timeScale = 0f;
        pausePanal.SetActive(pause);
    }
    public void onApplicationQuit() {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void RePlay()
    {
        //Time.timeScale = 1.0f;
        pausePanal.SetActive(false);
    }
    public void Go()
    {
        Time.timeScale = 1.0f;
    }
    public void Home()
    {
        SceneManager.LoadScene(0);
    }
}
