using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum ActionBackgroundState
{
    Error,
    Work,
    Eat,
    Sleep,
    Park,
    Aquarium,
    Shopping,
    PachinkoAndSlot,
    Bortrace,
    Bicyclerace,
    Horserace,
    Lottery,
    Pettycrime,
    Midiumcrime,
    Heveycrime

}

public class SceneScript : MonoBehaviour
{
    

    
    public static ActionBackgroundState Action { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }




    //タイトル画面からメイン画面へ
    public void OnClickStart()
    {
        SceneManager.LoadScene("MainScene");
    }


    //タイトル画面からデスクトップへ
    public void OnClickEnd()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    //メイン画面から各選択肢へ
    public void OnClickWork()
    {
        Action = ActionBackgroundState.Work;
        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickEat()
    {
        Action = ActionBackgroundState.Eat;
        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickSleep()
    {
        Action = ActionBackgroundState.Sleep;
        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickPark()
    {
        Action = ActionBackgroundState.Park;
        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickAquarium()
    {
        Action = ActionBackgroundState.Aquarium;
        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickShopping()
    {
        Action = ActionBackgroundState.Shopping;
        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickPachinkoAndSlot()
    {
        Action = ActionBackgroundState.PachinkoAndSlot;
        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickBortRace()
    {
        Action = ActionBackgroundState.Bortrace;
        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickBicyleRace()
    {
        Action = ActionBackgroundState.Bicyclerace;
        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickLottery()
    {
        Action = ActionBackgroundState.Lottery;
        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickHorseRase()
    {
        Action = ActionBackgroundState.Horserace;
        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickPettycrime()
    {
        Action = ActionBackgroundState.Pettycrime;
        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickMidiumcrime()
    {
        Action = ActionBackgroundState.Midiumcrime;
        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickHeveycrime()
    {
        Action = ActionBackgroundState.Heveycrime;
        SceneManager.LoadScene("ResultScene");
    }


}
