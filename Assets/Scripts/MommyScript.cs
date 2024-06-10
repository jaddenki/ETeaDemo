using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
public class MommyScript : MonoBehaviour
{
public Clock clock;
public int dayCount = 1;
public TextMeshProUGUI dayText;

public void Start()
{
    dayText.text = dayCount.ToString();
}
public void Update()
{
        if (clock.isDay)
        {
            // since its day. u can do stuff
        }
        else
        {
            // it's night time. so we wanna reset everythign then restart?
        }
}


}
