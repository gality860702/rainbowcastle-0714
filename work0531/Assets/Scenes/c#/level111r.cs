using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level111r : MonoBehaviour
{
    /// <summary>
    /// 正確選擇
    /// </summary>
    public void rightclick()
    {
        SceneManager.LoadScene("manu");
    }

    /// <summary>
    /// 錯誤選擇
    /// </summary>
    public void wrongclick()
    {
        SceneManager.LoadScene("startgame");
    }
}
