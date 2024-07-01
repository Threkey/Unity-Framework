using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonScript : MonoBehaviour
{
    float power = 1500.0f;
    float destroyTime = 2.0f;

    public GameObject bulletPrefab;     // 총알 프리팹
    //List<GameObject> bullet;
    GameObject bullet;                  // 스크립트 내에서 제어하기 위한 필드
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 마우스 버튼이 눌렸을 시 발포
        if (Input.GetMouseButtonDown(0))
            Fire();
    }

    void Fire()
    {
        // 총알을 생성하면서 bullet에 담고 전방으로 power만큼 힘을 가함
        
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
