using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public class ShowSystemMenuCommand : Controller
{
    public override void Execute(object data)
    {
        GetView<UISystem>().Show();
    }
}

