using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level111 : MonoBehaviour
{
    /// <summary>
    /// 正確路線
    /// </summary>
    public void rightway()
    {
        SceneManager.LoadScene("startgame102rightway");
    }
    /// <summary>
    /// 錯誤路線
    /// </summary>
    public void wrongway()
    {
        SceneManager.LoadScene("startgame102wrongway");
    }
}
