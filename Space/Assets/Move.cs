using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform childTransform;    // ������ �ڽ� ���� ������Ʈ�� Ʈ������

    /*
        NOTE. ������ �ӱ�
    
        �� Vector3�� �ӱ� (ũ�Ⱑ 1�� ���⺤��)
        # Vector3.forward : new Vector3(0, 0, 1)
        # Vector3.back    : new Vector3(0, 0, -1)
        # Vector3.right   : new Vector3(1, 0, 0)
        # Vector3.left    : new Vector3(-1, 0, 0)
        # Vector3.up      : new Vector3(0, 1, 0)
        # Vector3.down    : new Vector3(0, -1, 0)
    
    
        NOTE. Ʈ�������� ����
    
        �� Transform Ÿ���� ����
        # transform.forward : �ڽ��� ������ ����Ű�� ���⺤��
        # transform.right   : �ڽ��� �������� ����Ű�� ���⺤��
        # transform.up      : �ڽ��� ������ ����Ű�� ���⺤��
        �� -1�� �����ָ� �ݴ� ���⵵ ǥ�� ����
    */

    void Start()
    {
        // �ڽ��� ���� ��ġ�� (0, -1, 0)���� ����
        transform.position = new Vector3(0, -1, 0); // transform.position = transform.position + (-1 * transform.up);
        // �ڽ��� ���� ��ġ�� (0, 2, 0)���� ����
        childTransform.localPosition = new Vector3(0, 2, 0);

        // �ڽ��� ���� ȸ���� (0, 0, 30)���� ����
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 30));
        // �ڽ��� ���� ȸ���� (0, 60, 0)���� ����
        childTransform.localRotation = Quaternion.Euler(new Vector3(0, 60, 0));
    }

    // Update is called once per frame
    void Update()
    {
        /*
            NOTE. Space Ÿ��
            
            # Space.World : ���� ������ �������� ��
            # Space.Self  : ���� ����(�ڱ� �ڽ�)�� �������� ��

            ex) 
            // �ڽ��� Y�� ����� ������� ���� ������ �������� �� Y�� �������� �ʴ� 1��ŭ ���� �̵�
            Transform.Translate(new Vector(0, 1, 0) * Time.deltaTime, Space.World)

            // ���� ������ Z�� ����� ������� �ڽ��� Z���� �������� �ʴ� 180�� ȸ��
            Transform.Rotate(new Vector(0, 0, 180) * Time.deltaTime, Space.Self)
        */
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // ���� ����Ű�� ������ �ʴ� (0, 1, 0) �ӵ��� �����̵�
            transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            // �Ʒ��� ����Ű�� ������ �ʴ� (0, -1, 0)�� �ӵ��� �����̵�
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // ���� ����Ű�� ������
            // �ڽ��� �ʴ� (0, 0, 180) ȸ��
            transform.Rotate(new Vector3(0, 0, 180) * Time.deltaTime);
            // �ڽ��� �ʴ� (0, 180, 0) ȸ��
            childTransform.Rotate(new Vector3(0, 180, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            // ������ ����Ű�� ������
            // �ڽ��� �ʴ� (0, 0, -180) ȸ��
            transform.Rotate(new Vector3(0, 0, -180) * Time.deltaTime);
            // �ڽ��� �ʴ� (0, -180, 0) ȸ��
            childTransform.Rotate(new Vector3(0, -180, 0) * Time.deltaTime);
        }
    }
}


