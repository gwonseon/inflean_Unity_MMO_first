using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


#region // 벡터 (위치 이동)
/*
//1 위치벡터
//2 방향벡터
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
        #region // 벡터 (위치 이동)
        /*
        MyVector to = new MyVector(10.0f, 0.0f,0.0f);
        MyVector from = new MyVector(5.0f, 0.0f, 0.0f);
        MyVector dir = to - from;  //(-5.0f, 0.0f, 0.0f)

        dir = dir.normalized;

        MyVector newPos = from + dir * _speed;
        //방향 벡터에서 두 가지 정보 얻을 수 있다
        // 1. 거리(크기)    = 5
        // 2. 실제 방향     = 우측
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
        // Local -> World (위치 방향)
        // transform.TransformDirection()
        // World -> Local  (위치 방향)
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
