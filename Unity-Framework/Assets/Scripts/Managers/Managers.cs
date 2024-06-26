using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers s_instance;  //���ϼ��� ����ȴ�.
    // ������ �Ŵ����� ����´�. // ������Ƽ // �б� ����
    public static Managers Instance { get { Init(); return s_instance; } }

    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {

    }

    static void Init()
    {
        if (s_instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if (go == null) // go�� ������
            {
                go = new GameObject { name = "@Manager" }; // �ڵ������ ������Ʈ�� ����� ��
                go.AddComponent<Managers>();
            }

            DontDestroyOnLoad(go);
            s_instance = go.GetComponent<Managers>();
        }
    }
}
