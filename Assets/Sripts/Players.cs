using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Players : MonoBehaviour
{
    float speed = 10.1f;
    public float rotSpeed = 100f;
    [SerializeField] float MouseSpeed = 2;

    [SerializeField] Bullet bulletPrefab;
    [SerializeField] Transform bulletPoint;

    void Start()
    {
         
    }


    void Update()
    {
        Move();
        Shot();
    }

    void Shot() {
        if (Input.GetKey(KeyCode.Space))
        {
            Bullet bulletClone = Instantiate(bulletPrefab);
            bulletClone.transform.position = bulletPoint.position;
        }
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S)) {
            transform.Translate(0,0,-speed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(Vector3.up * Time.deltaTime * -rotSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(Vector3.up * Time.deltaTime * rotSpeed);
        }
    }

  





}
