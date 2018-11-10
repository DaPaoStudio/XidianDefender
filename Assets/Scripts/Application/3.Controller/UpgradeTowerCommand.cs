using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class UpgradeTowerCommand : Controller
{
    public override void Execute(object data)
    {
        UpgradeTowerArgs e = data as UpgradeTowerArgs;
        Tower tower = e.tower;
        GameModel gm = GetModel<GameModel>();
        gm.Gold -= tower.Level * tower.BasePrice;
        tower.Level++;
    }
}