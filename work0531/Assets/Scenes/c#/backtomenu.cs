using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backtomenu : MonoBehaviour
{

    /// <summary>
    /// 回到標題
    /// </summary>
    public void backmenu()
    {
        SceneManager.LoadScene("manu");
    }
}
