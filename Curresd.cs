using DG.Tweening;
using SWS;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Curresd : MonoBehaviour
{
    public splineMove first;
    public splineMove second;
    public FirstPersonController a;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        print(111);
        

    }
    public void Jie()
    {
        a.enabled = true;
        Debug.Log(222);
       
    }
    public void Daohang()
    {
        a.enabled = false;
        first.StartMove();
    }
    public void Daohang2()
    {
        a.enabled = false;
        second.StartMove();
    }
    public void Fanhui()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
    public void Load()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            first.Stop();
            second.Stop();

        }
        else
        {
            Cursor.lockState = CursorLockMode.Confined;
        }
        
    }
    
}
