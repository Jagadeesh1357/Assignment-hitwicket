using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPulpit : MonoBehaviour
{
    public float minTimer = 4f;
    public float maxTimer = 5f;
    private int pickRandomTimer;

    public bool selectTimer = false;

    // Start is called before the first frame update
    void Start()
    {
        pickRandomTimer = Random.Range(0, 2);
        if(pickRandomTimer == 0)
        {
            selectTimer = true;
        }
        else
        {
            selectTimer = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if(selectTimer)
        {
            if (minTimer <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                minTimer -= Time.deltaTime;
            }
        }
        else
        {
            if (maxTimer <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                maxTimer -= Time.deltaTime;
            }
        }
        
    }

    
}
