using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotifyCollection<T> : ScriptableObject
{
    private event Action<T> m_onAdd;

    public event Action<T> OnAdd
    {
        add
        {
            m_onAdd -= value;
            m_onAdd += value;
        }
        remove
        {
            m_onAdd -= value;
        }
    }

    public void Add(T _obj)
    {
        m_onAdd?.Invoke(_obj);
    }
}
