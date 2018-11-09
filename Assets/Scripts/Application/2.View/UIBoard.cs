﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIBoard : View
{
    #region 常量
    #endregion

    #region 事件
    #endregion

    #region 字段
    public Text txtScore;
    public Image imgRoundInfo;
    public Text txtCurrent;
    public Text txtTotal;
    public Image imgPauseInfo;
    public Button btnSpeed1;
    public Button btnSpeed2;
    public Button btnResume;
    public Button btnPause;
    public Button btnSystem;

    bool m_IsPlaying = false;
    GameSpeed m_Speed = GameSpeed.One;
    int m_Score = 0;
    #endregion

    #region 属性
    public override string Name
    {
        get { return Consts.V_Board; }
    }

    public int Score
    {
        get { return m_Score; }
        set
        {
            m_Score = value;
            txtScore.text = value.ToString();
        }
    }

    public bool IsPlaying
    {
        get { return m_IsPlaying; }
        set
        {
            m_IsPlaying = value;

            imgRoundInfo.gameObject.SetActive(value);
            imgPauseInfo.gameObject.SetActive(!value);
            btnPause.gameObject.SetActive(value);
            btnResume.gameObject.SetActive(!value);
        }
    }

    public GameSpeed Speed
    {
        get { return m_Speed; }
        set
        {
            m_Speed = value;

            btnSpeed1.gameObject.SetActive(m_Speed == GameSpeed.One);
            btnSpeed2.gameObject.SetActive(m_Speed == GameSpeed.Two);
        }
    }
    #endregion

    #region 方法
    public void UpdateRoundInfo(int currentRound, int totalRound)
    {
        txtCurrent.text = currentRound.ToString("D2");//始终保留2位整数
        txtTotal.text = totalRound.ToString();
    }
    #endregion

    #region Unity回调
    void Awake()
    {
        this.Score = 100;
        this.IsPlaying = true;
        this.Speed = GameSpeed.One;
    }
    #endregion

    #region 事件回调
    public void OnSpeed2Click()
    {
        Speed = GameSpeed.One;
        Time.timeScale = 1;
    }

    public void OnSpeed1Click()
    {
        Speed = GameSpeed.Two;
        Time.timeScale = 2;
    }

    public void OnPauseClick()
    {
        IsPlaying = false;
    }

    public void OnResumeClick()
    {
        IsPlaying = true;
    }

    public void OnSystemClick()
    {
        //等待修改
        // UISystem.isDisplay = true;
        //SendEvent(Consts.E_ShowSystem);
    }

    public override void RegisterEvents()
    {

    }

    public override void HandleEvent(string eventName, object data)
    {

    }
    #endregion

    #region 帮助方法
    #endregion
}