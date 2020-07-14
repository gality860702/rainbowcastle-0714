using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Reflection;

public class LEVEL1 : MonoBehaviour
{
    
    /// <summary>
    /// 解鎖進度:到下一個地圖
    /// </summary>
    public void nextstage()
    {
        SceneManager.LoadScene("startgame_2");
    }




}
