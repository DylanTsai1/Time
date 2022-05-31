using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour {

    public Text txt_Timetime;
    public Text txt_TimeFloored;
    public Text txt_customTime;

    float customTime;
    bool isCounting;
    // Use this for initialization
	void Start ()
    {
        customTime = 0;
        isCounting = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        float time = Time.time;
        txt_Timetime.text = time.ToString();
        txt_TimeFloored.text = Mathf.Floor(time).ToString();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isCounting = true;
        }
        if (isCounting)
        {
            customTime += Time.deltaTime;
        }
        txt_customTime.text = customTime.ToString();
    }
}
