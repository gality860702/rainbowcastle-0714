
using UnityEngine;
using UnityEngine.SceneManagement;

public class LEVEL104 : MonoBehaviour
{
    /// <summary>
    /// 解鎖進度:到下一個場景
    /// </summary>
    public void nextstage()
    {
        SceneManager.LoadScene("level1_ok");
    }
}
