using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    void Start()
    {
        // ĳ������ �������� ������ �����
        string characterName = "���";
        char bloodType = 'A';
        int age = 17;
        float height = 168.3f;
        bool isFemale = true;

        // ������ ������ �ֿܼ� ���
        Debug.Log("ĳ���� �̸� : " + characterName);
        Debug.Log("������ : " + bloodType);
        Debug.Log("���� : " + age);
        Debug.Log("Ű : " + height);
        Debug.Log("�����ΰ�? : " + isFemale);


        // �޼ҵ� �̿�
        float distance = GetDistance(2, 2, 5, 6);
        Debug.Log("(2, 2)���� (5, 6)������ �Ÿ� : " + distance);


        // ���
        int love = 80;

        if (love > 90)
        {
            Debug.Log("Ʈ�翣��: �����ΰ� ��ȥ�ߴ�!");
        }
        else if (love > 70)
        {
            Debug.Log("�¿���: �����ΰ� ��Ͱ� �Ǿ���!");
        }
        else
        {
            Debug.Log("��忣��: �����ο��� ������.");
        }

        /* ��������
        int age = 11;
        
        if(age > 7 && age < 18)
        {
            Debug.Log("�ǹ� ������ �ް� �ֽ��ϴ�.");
        }
        if(age < 13 || age > 70)
        {
            Debug.Log("���� �� �� ���� �����Դϴ�.");
        }
        */


        // for ��
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i + " ��° �����Դϴ�.");
        }

        // while ��
        bool isDead = false;
        int hp = 100;

        while (!isDead)
        {
            Debug.Log("���� ü�� : " + hp);

            hp -= 33;

            if (hp <= 0)
            {
                isDead = true;
                Debug.Log("�÷��̾�� �׾����ϴ�.");
            }
        }


        // �迭
        int[] students = new int[3];

        students[0] = 100;
        students[1] = 90;
        students[2] = 80;
        
        for(int i = 0; i < students.Length; i++)
        { 
            Debug.Log((i+1) + " �� �л��� ����: " + students[i]);
        }
    }

    float GetDistance(float x1, float y1, float x2, float y2)
    {
        float width = x2 - x1;
        float height = y2 - y1;

        float distance = width * width + height * height;
        distance = Mathf.Sqrt(distance);

        return distance;
    }

    void Update()
    {
        
    }
}
