using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cable : MonoBehaviour
{
    int i;
    int j;
    int k;

    [SerializeField]
    private GameObject Image,hammer,key;
    

    [SerializeField]
    private Button[] buttons ;
    

    public void unlock1()
    {
        i++;
        buttons[0].transform.Rotate(0, 0, -90);
        if(i == 3)
        {
           buttons[0].interactable = false;
        }
        print(i);
    }

    public void unlock2()
    {
        j++;
        buttons[1].transform.Rotate(0, 0, -90);
        if (j == 1)
        {
            buttons[1].interactable = false;
        }
        print(j);
    }

    public void unlock3()
    {
        k++;
        buttons[2].transform.Rotate(0, 0, -90);
        if (k == 3)
        {
            buttons[2].interactable = false;
        }
        print(k);
    }

    // 當此開關已經達到各個按鈕的點擊次數條件時,某個介面會開啟或關閉
    public  void ButtonE()
    {
        if (i == 3 && j == 1 && k == 3)
        {
            Image.SetActive(false);
            key.SetActive(true);
            hammer.SetActive(true);
        }
    }

    public void ButtonC()
    {
        i++; j++; k++;                        // 為了讓update關閉,因此在這裡加一個s++,讓ButtonE的 s == 1 的狀態解除,因此update就不會一直執行了
        key.SetActive(false);
        
    }

    void Update()
    {
        ButtonE();
    }
}
