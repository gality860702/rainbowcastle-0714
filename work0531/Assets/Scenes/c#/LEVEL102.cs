using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LEVEL102 : MonoBehaviour
{

    /// <summary>
    /// 解鎖進度:到下一個地圖(牆壁破壞)
    /// </summary>
    public void nextstage_wall()
    {
        SceneManager.LoadScene("level1_bwall");
    }

    /// <summary>
    /// 解鎖進度:到下一個地圖(玻璃破壞)
    /// </summary>
    public void nextstage_glass()
    {
        SceneManager.LoadScene("level1_bglass");
    }
}
