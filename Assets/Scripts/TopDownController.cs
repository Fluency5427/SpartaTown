using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent; //Action �� ������ Void �� ��ȯ�ؾ��� �ƴϸ� Func
    public event Action<Vector2> OnLookEvent;


    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);  // ? �ƴԸ���
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

}