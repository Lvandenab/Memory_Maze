using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 3.0f;
    public int health = 3;
    public GameObject win;
    public GameObject lose;
    public GameObject blood;
    public Transform player;
    public GameObject Heart1,Heart2,Heart3;

    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            lose.SetActive(true);
            Time.timeScale = 0.0f;

        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Destoyable"))
        {
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("damage");
            Instantiate(blood, player.position, player.rotation);
            health--;
            if (health == 2)
            {
                Destroy(Heart1);
            }
            else if (health == 1)
            {
                Destroy(Heart2);
            }
            else if (health == 0)
            {
                Destroy(Heart3);
            }

        }
        else if (other.gameObject.CompareTag("End"))
        {
            win.SetActive(true);
            Time.timeScale = 0.0f;
        }
    }
}
