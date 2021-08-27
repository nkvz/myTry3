using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    [Header("Set In Inspector")]
    public float speed = 10f;
    public GameObject collar;
    public Renderer collarRend;

    [Header("Set In Inspector for Cube")]
    public GameObject spawnPrefab;
    [Header("Set In Inspector for Sphere")]
    public Rigidbody rb;
    public bool inGround;
    public float jumpPower = 300f;

    public void Awake()
    {
        collarRend = GetComponent<Renderer>();
    }

    public void GetInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += -transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += -transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += transform.right * speed * Time.deltaTime;
        }
    }

    public void Attack()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("damage hit");
        }
    }

    public void ChangeColor()
    { 
        if (Input.GetKeyDown(KeyCode.E))
        {
            Color randColor = new Color(Random.value, Random.value, Random.value, 1);
            collarRend.material.color = randColor;
        }
    }

    public void UltimateCube()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject spawn = Instantiate<GameObject>(spawnPrefab);
            spawn.transform.position = this.transform.position;
        }
    }

    public void UltimateSphere()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (inGround == true)
            {
                rb.AddForce(transform.up * jumpPower);
            }
        }
    }

    public void UltimateCylinder()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(this.gameObject, 2f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            inGround = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            inGround = false;
        }
    }


}
