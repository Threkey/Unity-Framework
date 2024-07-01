using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMove : MonoBehaviour
{
    public float moveSpeed;
    public float rotateSpeed;
    public GameObject TankHead;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ����
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

            // ���� �� �¿� ȸ��
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(Vector3.up * rotateSpeed);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(Vector3.down * rotateSpeed);
            }
        }
        // ����
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);

            // ���� �� �¿� ȸ��
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(Vector3.up * rotateSpeed);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(Vector3.down * rotateSpeed);
            }
        }
        else
        {
            // ���� ���¿��� �ͷ� ȸ��
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                TankHead.transform.Rotate(Vector3.up * rotateSpeed);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                TankHead.transform.Rotate(Vector3.down * rotateSpeed);
            }
        }
    }
}
