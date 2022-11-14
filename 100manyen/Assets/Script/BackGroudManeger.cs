using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class BackGroudManeger : MonoBehaviour
{
    [SerializeField]
    Image ErrorBackground;
    [SerializeField]
    Image WorkBackground;
    [SerializeField]
    Image EatBackground;
    [SerializeField]
    Image SleepBackground;
    [SerializeField]
    Image ParkBackground;
    [SerializeField]
    Image AquariumBackground;
    [SerializeField]
    Image ShoppingBackground;
    [SerializeField]
    Image PachinkoAndSlotBackground;
    [SerializeField]
    Image BortraceBackground;
    [SerializeField]
    Image BicyceraceBackground;
    [SerializeField]
    Image HorseBackground;
    [SerializeField]
    Image LotteryBackground;
    [SerializeField]
    Image PettycrimeBackground;
    [SerializeField]
    Image MediumcrimeBackground;
    [SerializeField]
    Image HeveyBackground;

    // Start is called before the first frame update
    void Start()
    {
        
        ActionBackgroundPop();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //リザルト画面の背景をメイン画面から参照して表示させる
    public void ActionBackgroundPop()
    {
        switch (SceneScript.Action)
        {
            case ActionBackgroundState.Error:
                ErrorBackground.gameObject.SetActive(true);
                break;

            case ActionBackgroundState.Work:
                WorkBackground.gameObject.SetActive(true);
                break;

            case ActionBackgroundState.Eat:
                EatBackground.gameObject.SetActive(true);
                break;

            case ActionBackgroundState.Sleep:
                SleepBackground.gameObject.SetActive(true);
                break;

            case ActionBackgroundState.Park:
                ParkBackground.gameObject.SetActive(true);
                break;

            case ActionBackgroundState.Aquarium:
                AquariumBackground.gameObject.SetActive(true);
                break;

            case ActionBackgroundState.Shopping:
                ShoppingBackground.gameObject.SetActive(true);
                break;

            case ActionBackgroundState.PachinkoAndSlot:
                PachinkoAndSlotBackground.gameObject.SetActive(true);
                break;

            case ActionBackgroundState.Bortrace:
                BortraceBackground.gameObject.SetActive(true);
                break;

            case ActionBackgroundState.Bicyclerace:
                BicyceraceBackground.gameObject.SetActive(true);
                break;

            case ActionBackgroundState.Horserace:
                HorseBackground.gameObject.SetActive(true);
                break;

            case ActionBackgroundState.Lottery:
                LotteryBackground.gameObject.SetActive(true);
                break;

            case ActionBackgroundState.Pettycrime:
                PettycrimeBackground.gameObject.SetActive(true);
                break;

            case ActionBackgroundState.Midiumcrime:
                MediumcrimeBackground.gameObject.SetActive(true);
                break;

            case ActionBackgroundState.Heveycrime:
                HeveyBackground.gameObject.SetActive(true);
                break;
        }

    }

}
