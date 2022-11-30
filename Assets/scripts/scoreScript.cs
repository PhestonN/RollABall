using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour
{
    public Text MyScoreText;

    private int scoreNum;
    public Canvas end;
  
    
  
    
    
    // Start is called before the first frame update
    void Start()
    {
        scoreNum = 0;
        MyScoreText.text = "Score : " + scoreNum;    
    }

    private void OnTriggerEnter(Collider Wrench)
    {
        if (Wrench.tag == "pickUp")
        {
            scoreNum += 1;
            MyScoreText.text = "Score : " + scoreNum;
             if (scoreNum == 9)
            {
                end.gameObject.SetActive(true);
            }
        }
        
    }

    
       
    }
    

    
    
    

