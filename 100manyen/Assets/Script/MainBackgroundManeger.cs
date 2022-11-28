using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainBackgroundManeger : MonoBehaviour
{
    [SerializeField]
    Image ErrorBackground;
    [SerializeField]
    Image MornigBackground;
    [SerializeField]
    Image NoonBackground;
    [SerializeField]
    Image NightBackground;
    
    
    

    // Start is called before the first frame update
    void Start()
    {
        MainBackgroundpup();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainBackgroundpup()
    {
        switch (PlayerState.time)
        {
            case 0:
                MornigBackground.gameObject.SetActive(true);
                break;


            case 1:
                NoonBackground.gameObject.SetActive(true);
                break;

            case 2:
                NightBackground.gameObject.SetActive(true);
                break;
                
        }

        if (PlayerState.time == 2)
        {
            PlayerState.time = 0;
            PlayerState.day += 1;
        }
        else
        {
            PlayerState.time += 1;
        }

        
        
    }
}
