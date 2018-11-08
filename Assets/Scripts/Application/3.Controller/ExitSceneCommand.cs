using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ExitSceneCommand : Controller
{
    public override void Execute(object data)
    {
        //离开场景前回收所有可回收对象
        Game.Instance.ObjectPool.UnspawnAll();
    }
}
