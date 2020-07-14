using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anilastgm : MonoBehaviour
{
    /// <summary>
    /// 解鎖進度:到下一個場景
    /// </summary>
    public void nextstage()
    {
        SceneManager.LoadScene("startgame");
    }
}
