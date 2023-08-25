using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform shootpoint;
    public GameObject bullet;
    public int force;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            GameObject bulletprefab = Instantiate(bullet, shootpoint, shootpoint);
            bulletprefab.GetComponent<Rigidbody>().AddForce(-Vector3.forward * force, ForceMode.Impulse);
        }
    }
}
