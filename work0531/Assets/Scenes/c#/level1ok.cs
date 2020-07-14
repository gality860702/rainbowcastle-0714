using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level1ok : MonoBehaviour
{
    /// <summary>
    /// 解鎖進度:到下一個場景
    /// </summary>
    public void backtom()
    {
        SceneManager.LoadScene("manu");
    }
}
