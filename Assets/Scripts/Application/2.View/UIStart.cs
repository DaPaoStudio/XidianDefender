using UnityEngine;
using System.Collections;

public class UIStart : View
{
    public override string Name
    {
        get { return Consts.V_Start; }
    }

    public void GotoSelect()
    {
        Game.Instance.LoadScene(2);
        //Sound.Instance.StopBg;
    }

    public void GotoAlbum()
    {
        Game.Instance.LoadScene(5);
        //Sound.Instance.StopBg;
    }

    public override void HandleEvent(string eventName, object data)
    {

    }
}