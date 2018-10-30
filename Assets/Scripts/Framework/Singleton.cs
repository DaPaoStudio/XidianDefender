using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour //Singleton的泛型集合
    where T : MonoBehaviour                        //对泛型进行类型约束：必须继承于MonoBehaviour
{
    private static T m_instance = null;

    private static T Instance
    {
        get { return m_instance; }
    }

    protected virtual void Awake()
    {
        m_instance = this as T;
    }
}
