using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulpitSpawner : MonoBehaviour
{
    public GameObject pulpitPrefab;
    private float timer = 2.5f;     //Pulpit spawn time
    public Transform targetTransform;    //Reference to store previous pulpit transform
    private int randomPos;

    private static int count = -1;   //static variable to not spawn on already spawned pulpit

    // Start is called before the first frame update
    void Start()
    {
        targetTransform.position = this.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer <= 0)
        {
            randomPos = Random.Range(0, 4);

            if(randomPos == 0 && count!=1)
            {
                GameObject prefab = Instantiate(pulpitPrefab, targetTransform.position + (transform.right * 10), transform.rotation);
                targetTransform.position = prefab.transform.position;
                timer = 2f;
                count = 0;
            }
            else if(randomPos==1 && count!=0)
            {
                GameObject prefab = Instantiate(pulpitPrefab, targetTransform.position - (transform.right * 10), transform.rotation);
                targetTransform.position = prefab.transform.position;
                timer = 2f;
                count = 1;
            }
            else if(randomPos == 2 && count != 3)
            {
                GameObject prefab = Instantiate(pulpitPrefab, targetTransform.position + (transform.forward * 10), transform.rotation);
                targetTransform.position = prefab.transform.position;
                timer = 2f;
                count = 2;
            }
            else if(randomPos == 3 && count != 2)
            {
                GameObject prefab = Instantiate(pulpitPrefab, targetTransform.position - (transform.forward * 10), transform.rotation);
                targetTransform.position = prefab.transform.position;
                timer = 2f;
                count = 3;
            }
            else
            {
                if(count == 0)
                {
                    GameObject prefab = Instantiate(pulpitPrefab, targetTransform.position - (transform.forward * 10), transform.rotation);
                    targetTransform.position = prefab.transform.position;
                    timer = 2f;
                    count = 3;
                    
                }
                else if(count == 1)
                {
                    GameObject prefab = Instantiate(pulpitPrefab, targetTransform.position + (transform.forward * 10), transform.rotation);
                    targetTransform.position = prefab.transform.position;
                    timer = 2f;
                    count = 2;
                }
                else if(count == 2)
                {
                    GameObject prefab = Instantiate(pulpitPrefab, targetTransform.position - (transform.right * 10), transform.rotation);
                    targetTransform.position = prefab.transform.position;
                    timer = 2f;
                    count = 1;
                }
                else
                {
                    GameObject prefab = Instantiate(pulpitPrefab, targetTransform.position + (transform.right * 10), transform.rotation);
                    targetTransform.position = prefab.transform.position;
                    timer = 2f;
                    count = 0;
                }
            }
            Debug.Log(count);

            
        }
            
        else
        {
            timer -= Time.deltaTime;
        }
            
    }
}
