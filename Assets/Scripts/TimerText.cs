using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerText : MonoBehaviour
{
    public TextMeshProUGUI txt;
    private float timer = 4.00f;
    private static float value;
    private float minTimer = 4f;
    private float maxTimer = 5f;

    // Start is called before the first frame update
    void Start()
    {
        txt.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        minTimer -= Time.deltaTime;
        maxTimer -= Time.deltaTime;
        if(FindObjectOfType<DestroyPulpit>().selectTimer)
        {
            value = (float)System.Math.Round(minTimer, 2);
        }
        else
        {
            value = (float)System.Math.Round(maxTimer, 2);
        }
        
        txt.text = value.ToString();
    }
}
