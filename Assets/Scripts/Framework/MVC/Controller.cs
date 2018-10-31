using System;
using System.Collections.Generic;
using System.Text;

public abstract class Controller
{
    //处理系统消息
    public abstract void Execute(object data);
}