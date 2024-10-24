using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 8f;                    //ź�� �̵� �ӷ�
    private Rigidbody bulletRigidbody;          //�̵��� ����� ������ٵ� ������Ʈ


    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.velocity = transform.forward * speed;
        Destroy(gameObject, 3f);
    }

    void OnTriggerEnter(Collider other)         //Ʈ���� �浹 �� �ڵ����� ����Ǵ� �ż���
    {
        if (other.tag == "Target")
        {
            Target_Move Target_Move = other.GetComponent<Target_Move>();
            //���� ���� ������Ʈ���� playerController ������Ʈ ��������

            if (Target_Move != null)       //�������� ���� PlayerController ������Ʈ�� �������� �� �����ߴٸ�
            {
                Target_Move.Die();         //���� PlayerController ������Ʈ Die() �ż������
            }
        }
    }
}