using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IF_statements : MonoBehaviour
{
    public int age;
    // Start is called before the first frame update
    public int score;
    void Start()
    {
        /*  if (age < 18)
          {
              Debug.Log("you are teenager");
          }
          else if(age >= 18 && age<55)
          {
              Debug.Log("you are an adult");
          }
          else
          {
              Debug.Log("you are old");
          }
      }
        */
        switch (score)
        {
            case 0:
                Debug.Log("score is not good enough");
                break;
            case 5:
                Debug.Log("score is fine");
                break;
            case 10:
                Debug.Log("score is perfect");
                break;

        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
