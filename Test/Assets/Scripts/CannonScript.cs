using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonScript : MonoBehaviour
{
    float power = 1500.0f;
    float destroyTime = 2.0f;

    public GameObject bulletPrefab;     // �Ѿ� ������
    //List<GameObject> bullet;
    GameObject bullet;                  // ��ũ��Ʈ ������ �����ϱ� ���� �ʵ�
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // ���콺 ��ư�� ������ �� ����
        if (Input.GetMouseButtonDown(0))
            Fire();
    }

    void Fire()
    {
        // �Ѿ��� �����ϸ鼭 bullet�� ��� �������� power��ŭ ���� ����
        
        bullet = Instantiate(bulletPrefab, transform);
        bullet.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * power);
        Invoke("Destroy", destroyTime);
        

        /*
        bullet.Add(Instantiate(bulletPrefab, transform));

        for(int i = 0; i < bullet.Count; i++)
        {
            if(bullet[i].GetComponent<Rigidbody>().velocity.z == 0f)
                bullet[i].GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * power);
        }
        */

    }

    private void Destroy() { Destroy(bullet); }
}
