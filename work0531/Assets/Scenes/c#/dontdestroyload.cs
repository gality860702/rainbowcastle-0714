using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontdestroyload : MonoBehaviour
{
    private void Awake()
    {
        // DontDestroyOnLoad切換場景時候不要把括弧內的物件刪除
        // gameObject代表物件自己
        DontDestroyOnLoad(gameObject);
    }

}
