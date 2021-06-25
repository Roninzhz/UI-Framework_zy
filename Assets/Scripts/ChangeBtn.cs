using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeBtn : MonoBehaviour {

    /// <summary>
    /// 单机游戏
    /// </summary>
    public GameObject DjObject;
    /// <summary>
    /// 联网游戏
    /// </summary>
    public GameObject LwObject;
    /// <summary>
    /// <summary>
    /// LoginWindow
    /// </summary>
    public GameObject loginObj;
    /// <summary>
    /// Window
    /// </summary>
    public GameObject windowObj;
    /// <summary>
    /// 开始游戏
    /// </summary>
    public Button startObj;
    /// 继续游戏
    /// </summary>
    public Button AgainObject;
    /// <summary>
    /// 开始按钮的逻辑
    /// </summary> 
    public void StartButton()
    {
        //打开LoginWindow窗口
        loginObj.SetActive(true);
        startObj.interactable = false;
        AgainObject.interactable = false;
    }
    /// <summary>
    /// 点确定则关闭上图显示下图
    /// </summary>
    public void SureButton()
    {
        loginObj.SetActive(false);
        windowObj.SetActive(true);
    }
    /// <summary>
    /// 点取消恢复图二
    /// </summary>
    public void CloseButton()
    {
        loginObj.SetActive(false);
        startObj.interactable = true;
        AgainObject.interactable = true;
    }
    /// <summary>
    ///点击确认按钮跳转场景
    /// </summary>
    public void ChangeScen()
    {
        SceneManager.LoadScene(1);
    }
    /// <summary>
    /// 关闭Window
    /// </summary>
    public void ReturnButton()
    {
        windowObj.SetActive(false);
        startObj.interactable = true;
        AgainObject.interactable = true;
    }

    public void BtnClickDL()
    {
        DjObject.SetActive(false);
        LwObject.SetActive(false);
    }
}
