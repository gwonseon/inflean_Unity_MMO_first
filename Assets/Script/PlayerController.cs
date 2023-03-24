using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


#region // ���� (��ġ �̵�)
/*
//1 ��ġ����
//2 ���⺤��
struct MyVector
{
    public float x;
    public float y;
    public float z;


    public float magnitude {  get { return Mathf.Sqrt(x * x + y * y + z * z); } }
    public MyVector normalized {  get {  return new MyVector(x / magnitude, y / magnitude, z / magnitude); } }


    public MyVector(float x, float y, float z) { this.x = x; this.y = y; this.z = z; }

    public static MyVector operator +(MyVector a, MyVector b)
    {
        return new MyVector(a.x + b.x, a.y + b.y, a.z +b.z);
    }
    public static MyVector operator -(MyVector a, MyVector b)
    {
        return new MyVector(a.x - b.x, a.y - b.y, a.z - b.z);
    }
    public static MyVector operator *(MyVector a, float d)
    {
        return new MyVector(a.x * d, a.y * d, a.z * d);
    }

}
*/
#endregion

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float _speed = 10.0f;
    void Start()
    {
        #region // ���� (��ġ �̵�)
        /*
        MyVector to = new MyVector(10.0f, 0.0f,0.0f);
        MyVector from = new MyVector(5.0f, 0.0f, 0.0f);
        MyVector dir = to - from;  //(-5.0f, 0.0f, 0.0f)

        dir = dir.normalized;

        MyVector newPos = from + dir * _speed;
        //���� ���Ϳ��� �� ���� ���� ���� �� �ִ�
        // 1. �Ÿ�(ũ��)    = 5
        // 2. ���� ����     = ����
        */

        // GameObject (Player)
        //  Transform
        //  PlayerController (*)
        #endregion
        Managers.Input.KeyAction -= OnKeyboard;
        Managers.Input.KeyAction += OnKeyboard;

    }

    float _yAngle = 0.0f;
    void Update()
    {
        /*
        // Local -> World (��ġ ����)
        // transform.TransformDirection()
        // World -> Local  (��ġ ����)
        // InverseTransformDirection
        */
       
        // transform.eulerAngles= new Vector3(0.0f,_yAngle,0.0f);
        // transform.rotation


        //transform.Rotate(new Vector3(0.0f, Time.deltaTime * 100.0f, 0.0f));

        //transform.rotation = Quaternion.Euler(new Vector3(0.0f, _yAngle, 0.0f));


       


    }
    void OnKeyboard()
    {
        if (Input.GetKey(KeyCode.W))
        {

            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.2f);
            transform.position += (Vector3.forward * Time.deltaTime * _speed);
        }

        if (Input.GetKey(KeyCode.S))
        {

            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.2f);
            transform.position += (Vector3.back * Time.deltaTime * _speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.2f);
            transform.position += (Vector3.left * Time.deltaTime * _speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.2f);
            transform.position += (Vector3.right * Time.deltaTime * _speed);
        }

    }


}
