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
    [field: SerializeField]
    public static int day { get; set; }
    
    [field: SerializeField]
    public static int time { get; set; }
    
    

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
        switch (time)
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

        if (time == 2)
        {
            time = 0;
            day =+ 1;
        }

        time += 1;
        
    }
}
