using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    // ���� Ÿ���� ������ ������Ʈ ���
    public Rigidbody myRigidbody;       // Rigidbody - ������Ʈ(Component : Ŭ���� Ÿ��, Ŭ������ �̷���� ����), myRigidbody - Ŭ���� Ÿ���� ����( = ���� Ÿ��)
                                        // Rigidbody ������Ʈ�� ���� Ÿ���� ���� myRigidbody �� ����Ű�� ����.

    // �� ���ؾȰ��� Point!
    // Rigidbody myRigidbody;
    // RIgidbody myRigidbody = new Rigidbody(); ó�� new Ű���带 �����ϴ� ����
    // : �� Jumper ��ũ��Ʈ�� �߰��� Cube ���� ������Ʈ�� �ν�����(Inspector)�� Rigidbody ������Ʈ�� �߰��Ǿ� �ְ�,
    // Rigidbody ������Ʈ�� Jumper ������Ʈ�� My Rigidbody �ʵ�� �巡��&����߱� ������,
    // ���� Ÿ���� ���� myRigidbody �� Cube ���� ������Ʈ�� Rigidbody ������Ʈ�� ���ϴ� ������ �Ҵ�ǰ� �� �� !
    // ����, myRigidbody.AddForce(0, 500, 0) ó�� ���� Ÿ���� ���������� ȣ�� ������ !

    void Start()
    {
        myRigidbody.AddForce(0, 500, 0);    // ��ó�� ��� '��ü' ������Ʈ�� �ڵ� �󿡼� ���� Ÿ���� ������ ����Ű�� ����� �� ����.
                                            // ���� myRigidbody �� ����ϴ� ��ó�� ��������, ��ǻ� myRigidbody�� ����Ű�� '��ü' ������Ʈ Rigidbody �� ���Ǵ°���!
                                            // ����, Rigidbody Ÿ�Կ� ����� AddForce() �޼��� ��� ����
    }
}

/* ������ ����Ͽ� ���� ������Ʈ�� ������Ʈ ����
1. �ʿ��� ������Ʈ�� ���� ������Ʈ�� �߰�
2. Script ���� ������ ������Ʈ�� ���� ���� ���� (���� - ���� Ÿ��)
3. �ش� ������ ������Ʈ �Ҵ�
4. �ڵ忡�� ������ ����ϸ� �װ��� ����Ű�� ���� ������Ʈ�� ����
*/