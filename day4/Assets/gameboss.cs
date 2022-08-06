using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameboss : MonoBehaviour
{
    public int score = 0;
    int increaser = 1;
    int score1 = 0;
    int increaser1 = 1000;
    public Text text2;
    public Text text1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }




    public void scorer()
    {
        score += increaser;
        text1.text = score.ToString();
    }
    public void Store()
    {

        if (score > 20)
        {
            text2.text = ("");
            increaser++;
            score -= 20;
            text1.text = score.ToString();
        }


        else
        {
            print("why you want to steal us ?");
            text2.text = ("why do you want to steal us ?");
        }



    }
   
            
     



    }
   
    
        
            





      






    







