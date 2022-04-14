using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animal tom = new Animal();      // ���ο� Animal ������Ʈ(�ν��Ͻ�) ����
                                        // Ŭ������ ���� ������ ����(reference) Ÿ���̰�, ���� Ÿ���� ������ ��üȭ�� ������Ʈ X
                                        // ���� new Ű���带 ����� ������Ʈ�� ���������� �����ؾ� ��.
                                        // ���⼭ tom �� ������ Animal ������Ʈ�� ����Ű�� �������� �����ϴ� ���� !
                                        // Animal Ÿ���� ���� tom�� ������ Animal ������Ʈ �� ��ü�� �ƴ�.
        tom.name = "��";
        tom.sound = "�Ŀ�";


        Animal jerry = new Animal();
        jerry.name = "����";
        jerry.sound = "����";

        jerry = tom;            // ���� jerry �� ������ �������� ����Ű�� Animal ������Ʈ = ���� tom �� ������ �������� ����Ű�� Animal ������Ʈ
        jerry.name = "��Ű";    // ���� jerry �� ���� Animal ������Ʈ�� �����ϴ� ���� tom �� ���� Animal ������Ʈ�� �����ϴ� �Ͱ� ���� �ǹ̰� ��.

        tom.PlaySound();    // ��Ű : �Ŀ�!     ( �� : �Ŀ�! (X) )
                            // tom.name �� "��Ű"�� ��µǴ� ������ ���� Ÿ���� ���ۿ� ����.
        jerry.PlaySound();  // ��Ű : ����!

        // ���� Ÿ���� �߿��� ���� -> ���� Ÿ���� ������ ������Ʈ ���

        // �������� �޸� �ּҿ� �����Ǵ� �� !
        // ������Ʈ�� �ϳ����� �װ��� ���� ���� ���� ������ ���ÿ� ����Ű�� ���� ������.
        /*
         * Some a = new Some();
         * Some b = a;      // ���� Ÿ���� ���� b
         * Some c = a;      // ���� Ÿ���� ���� c
        */
        // ���� Ÿ���� ���� = ���� ������Ʈ�� ���� �н�
        // �н�(����)�� �����ϸ� �����δ� �н��� ��ü�� ������Ʈ�� ������.

        /* ��(value) Ÿ���� ����
         * int a = 0;
         * int b = 10;
         * a = b;   // a = 10, b = 10
         * b = 100; // a = 10, b = 100
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
