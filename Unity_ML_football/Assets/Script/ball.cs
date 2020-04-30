
using UnityEngine;

public class ball : MonoBehaviour
{
    /// <summary>
    /// 代表足球是否進入球門
    /// </summary>
    public static bool complate;

    /// <summary>
    /// 觸發開始次事件:碰到有勾選IS Trigger的物件會執行一次
    /// </summary>
    /// <param name="other">碰到的物件的碰撞資訊</param>
    private void OnTriggerEnter(Collider other)
    {
        //如果物件碰觸到"球門感應區"
        if(other.name== "球門感應區")
        {
            //進入球門
            complate = true;

        }
    }
}
