using UnityEngine;
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
    public Image uiSystem;

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
        txtTotal.text = totalRound.ToString("D2");
    }

    public void UpdateScore(int score)
    {
        txtScore.text = score.ToString("D3");
    }
    #endregion

    #region Unity回调
    void Awake()
    {
        this.Score = 80;
        this.IsPlaying = true;
        this.Speed = GameSpeed.One;
    }

    void Update()
    {
        RoundModel rm = GetModel<RoundModel>();
        GameModel gm = GetModel<GameModel>();
        UpdateRoundInfo(rm.RoundIndex + 1, rm.RoundTotal);
        UpdateScore(gm.Gold);
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
        Time.timeScale = 0;
    }

    public void OnResumeClick()
    {
        IsPlaying = true;
        if(Speed==GameSpeed.Two)
            Time.timeScale = 2;
        else
            Time.timeScale = 1;
    }

    public void OnSystemClick()
    {
        IsPlaying = false;
        uiSystem.gameObject.SetActive(true);
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