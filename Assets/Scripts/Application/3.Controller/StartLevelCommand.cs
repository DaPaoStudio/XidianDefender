﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class StartLevelCommand : Controller
{
    public override void Execute(object data)
    {
        StartLevelArgs e = data as StartLevelArgs;

        //第一步
        GameModel gModel = GetModel<GameModel>();
        gModel.Gold = 80;
        gModel.StartLevel(e.LevelIndex);

        //第二步
        RoundModel rModel = GetModel<RoundModel>();
        rModel.LoadLevel(gModel.PlayLevel);

        //进入游戏
        Game.Instance.LoadScene(3);
    }
}