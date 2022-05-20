using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 8f;
    public int score = 0;
    private bool scored = false;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Game over");
        }


        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        

        if(direction.magnitude > 0.01f)
        {
            transform.position += direction * speed * Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Pulpit")
        {
            score += 1;
            //scored = true;
        }
    }

}
