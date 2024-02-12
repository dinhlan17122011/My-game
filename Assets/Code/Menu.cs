using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Choi()
    {
        SceneManager.LoadScene(1);
    }
    public void Thoai(){
        Application.Quit();
    }
    public void qiu()
    {
        SceneManager.LoadScene(0);
    }
}
