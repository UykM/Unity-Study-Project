using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    // ���� Ÿ���� ������ ������Ʈ ���
    public Rigidbody myRigidbody;       // Rigidbody - ������Ʈ(Component : Ŭ������ �̷���� ����), myRigidbody - Ŭ���� Ÿ���� ����( = ���� Ÿ��)
                                        // Rigidbody ������Ʈ�� ���� Ÿ���� myRigidbody �� ����Ű�� ����.

    void Start()
    {
        myRigidbody.AddForce(0, 500, 0);    // ��ó�� ��� '��ü' ������Ʈ�� �ڵ� �󿡼� ���� Ÿ���� ������ ����Ű�� ����� �� ����.
                                            // ���� myRigidbody �� ����ϴ� ��ó�� ��������, ��ǻ� myRigidbody�� ����Ű�� '��ü' ������Ʈ Rigidbody �� ���Ǵ°���!
                                            // ����, Rigidbody Ÿ�Կ� ����� AddForce() �޼��� ��� ����
    }
}
