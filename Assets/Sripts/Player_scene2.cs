using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_scene2 : MonoBehaviour
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

    void Shot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Bullet bulletClone = Instantiate(bulletPrefab, bulletPoint.position, Quaternion.identity);
            bulletClone.gameObject.transform.Rotate(bulletPoint.rotation.eulerAngles, Space.World);
            bulletClone.GetComponent<Rigidbody>().velocity = bulletPoint.right * 100;
        }
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -speed * Time.deltaTime);
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
