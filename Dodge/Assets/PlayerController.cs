using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;   // �̵��� ����� ������ٵ� ������Ʈ
    public float speed = 8f;    // �̵� �ӷ�

    void Start()
    {
        
    }

    /*  
        NOTE. KeyCode

        # KeyCode : Ű������ Ű �ĺ��ڸ� ���� ����Ű�� ���� Ÿ��
        - KeyCode Ÿ���� ���������� ���ڷ� ����
        - ���ڷ� �� Ű �ĺ��ڸ� ��� �ܿ�� ���� �Ұ��� -> ���� ����Ű�� �ĺ���(273) X => KeyCode.UpArrow ���


        NOTE. Input.GetKey() �迭 �޼���

        - Ű������ �ĺ��ڸ� KeyCode Ÿ������ �Է¹���.
        - bool Input.Getkey(KeyCode key);
        # Input.GetKey() �޼���     : �ش� Ű�� '������ ����' true, �� �ܿ��� false ��ȯ
        # Input.GetKeyDown() �޼��� : �ش� Ű�� '������ ����' true, �� �ܿ��� false ��ȯ
     */


    void Update()   // Update() �޼���� 1�ʿ� ���� ���� �����.
    {
        // ����Ƽ�� Input Ŭ���� - ������� �Է��� �����ϴ� �޼��带 ��Ƶ� ����
        if(Input.GetKey(KeyCode.UpArrow) == true)
        {   // ���� ����Ű �Է��� ������ ��� z �������� �� �ֱ�
            playerRigidbody.AddForce(0f, 0f, speed);
        }

        if(Input.GetKey(KeyCode.DownArrow) == true)
        {
            playerRigidbody.AddForce(0f, 0f, -speed);
        }

        if(Input.GetKey(KeyCode.RightArrow) == true)
        {
            playerRigidbody.AddForce(speed, 0f, 0f);
        }

        if(Input.GetKey(KeyCode.LeftArrow) == true)
        {
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }
    }

    // CATUTION. gameObject�� GameObject
    // gameObject - ����, GameObject - Ÿ��
    
    // ��� ���� ������Ʈ�� �����θ� ���� �Ѵ� ����� ���� ����.
    /*
        NOTE. SetActive()

        - ���� ������Ʈ�� ��Ÿ���� GameObject Ÿ�Կ� ����Ǿ� �ִ� �޼���
        - void SetActive(bool value);
    */
    public void Die()
    {
        // 1) gameObject�� ����� �ڽ��� ���� ������Ʈ�� ����
        // 2) ������ ���� ������Ʈ�� SetActive(false); �� ����
        gameObject.SetActive(false);
    }
}
