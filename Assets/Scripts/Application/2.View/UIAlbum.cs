using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIAlbum : View
{
    public override string Name
    {
        get { return Consts.V_Album; }
    }

    public Button btnBack;

    public void GoBack()
    {
        Game.Instance.LoadScene(1);
    }


    public override void HandleEvent(string eventName, object data)
    {
        
    }
}