using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject[] MissionButton;
    /// <summary>
    /// 進行遊戲
    /// </summary>
    public void startgame()
    {
        SceneManager.LoadScene("ani");
    }
    ///<summary>
    ///離開遊戲
    /// </summary>
    public void Quit()
    {
        Application.Quit();  //應用程式,離開()
    }
    ///<summary>
    ///讀取遊戲
    /// </summary>
    public void loadgame()
    {
        SceneManager.LoadScene
            ("loadgame"); 
    }
}
