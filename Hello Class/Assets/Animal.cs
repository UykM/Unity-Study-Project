using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{   
    // Animal Ŭ������ �ʵ� : Ŭ������ ��� �߿��� ������ Ŭ������ �ʵ��� ��.
    public string name;
    public string sound;

    // �����Ҹ��� ����ϴ� �޼���
    public void PlaySound()
    {
        Debug.Log(name + " : " + sound);
    }
}

// public : Ŭ���� �ܺο��� ����� ���� ����
// private : Ŭ���� ���ο����� ����� ���� ����
// protected : Ŭ���� ���ο� �Ļ� Ŭ���������� ����� ���� ����
