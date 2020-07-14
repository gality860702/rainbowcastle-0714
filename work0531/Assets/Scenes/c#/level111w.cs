using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level111w : MonoBehaviour
{
    /// <summary>
    /// 錯誤路線
    /// </summary>
    public void wrongclick()
    {
        SceneManager.LoadScene("startgame");
    }
}
