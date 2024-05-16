using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class StartBut : MonoBehaviour
{
    public GameObject dongfangmen;
    public GameObject xianggeli;
    // Start is called before the first frame update
    void Start()
    {
        dongfangmen.SetActive(false);
        xianggeli.SetActive(false);
    }
    public void Loadzero()
    {
        SceneManager.LoadScene(0);
    }
    public void Tuichu()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
    public void Loadone()
    {
        SceneManager.LoadScene(3);
    }
    public void Loadtwo()
    {
        SceneManager.LoadScene(2);
    }
    public void Loadfour()
    {
        SceneManager.LoadScene(4);
    }
    public void Loadthree()
    {
        SceneManager.LoadScene(1);
    }

    public void Loadfive()
    {
        SceneManager.LoadScene(5);
    }
    public void Loadsix()
    {
        SceneManager.LoadScene(6);
    }
    public void Loadseven()
    {
        SceneManager.LoadScene(7);
    }
    public void Show()
    {
        xianggeli.SetActive(true);
        dongfangmen.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
