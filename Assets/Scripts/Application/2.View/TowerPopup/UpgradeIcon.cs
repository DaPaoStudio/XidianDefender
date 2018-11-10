using UnityEngine;
using System.Collections;

public class UpgradeIcon : MonoBehaviour
{
    SpriteRenderer m_Render;
    Tower m_Tower;

    void Awake()
    {
        m_Render = GetComponent<SpriteRenderer>();
    }

    public void Load(GameModel gm, Tower tower)
    {
        m_Tower = tower;

        //图标
        TowerInfo info = Game.Instance.StaticData.GetTowerInfo(tower.ID);
        //string path = "Res/Roles/" + (tower.IsTopLevel ? info.DisabledIcon : info.NormalIcon);
        string path = "StreamingAssets/Resources/UI/HUD/" + (tower.IsTopLevel ? "upgradecan.png" : "upgradecant.png");
        //m_Render.sprite = Resources.Load<Sprite>(path);
    }

    void OnMouseDown()
    {
        if (m_Tower.IsTopLevel)
            return;
        GameModel gm = MVC.GetModel<GameModel>();
        if (gm.Gold >= m_Tower.Level * m_Tower.BasePrice)
        {
            UpgradeTowerArgs e = new UpgradeTowerArgs()
            {
                tower = m_Tower
            };
            SendMessageUpwards("UpgradeTower", e, SendMessageOptions.DontRequireReceiver);
        }
    }
}