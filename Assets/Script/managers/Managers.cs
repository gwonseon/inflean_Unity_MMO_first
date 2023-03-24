using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers s_instance;  //���ϼ��� ����ȴ�
    public static Managers Instance { get { Init(); return s_instance; } }  //������ �Ŵ����� ����´�



    InputManagers _input = new InputManagers();
    ResourceManager _resource = new ResourceManager();
    public static InputManagers Input { get {  return Instance._input; } }
    public static ResourceManager Resource { get { return Instance._resource; } }
    
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        _input.OnUpdate();
    }

    static void Init()
    {
        if (s_instance == null)
        {
            //�ʱ�ȭ
            GameObject go = GameObject.Find("@Managers");
            if (go == null)
            {
                go = new GameObject { name = "@Managers" };
                go.AddComponent<Managers>();
            }

            DontDestroyOnLoad(go);
            s_instance = go.GetComponent<Managers>();

        }
    }


}
