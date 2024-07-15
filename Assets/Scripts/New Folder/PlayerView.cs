using System.Collections;
using System.Collections.Generic;
using RMC.Mini.Controller;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    public Rigidbody rb;
     public float moveSpeed;
    public GameObject bulletPrefab;
    public float bulletForce;
    public Transform firePos;
    public void MovePosition(Vector3 input)
    {
       rb.velocity = input;
    }

   public void Fire(Vector3 direction)
    {
        Quaternion bulletForce = Quaternion.LookRotation(direction);
        GameObject bullet = Instantiate(bulletPrefab,firePos.position, bulletForce);
        Destroy(bullet, 2f);
        bullet.GetComponent<Rigidbody>().AddForce(direction,ForceMode.Impulse);
    }

}
