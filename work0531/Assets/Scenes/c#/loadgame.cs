using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadgame : MonoBehaviour
{
    /// <summary>
    /// 載入遊戲
    /// </summary>
    public void startgame()
    {
        SceneManager.LoadScene("startgame");
    }
}
