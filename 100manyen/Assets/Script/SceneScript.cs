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

    public PlayerState playerState;

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
    public void OnClickWork() //体力と精神力を消費してお金を増やす
    {
        //背景の呼び出し
        Action = ActionBackgroundState.Work;
        //ステータス変更
            
        playerState.Physical += 1; //体力の変更

        playerState.Mind += 1; //精神力の変更

        playerState.Money += 1;//お金の変更

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickEat()　//お金を使って、体力と精神力を回復する
    {
        Action = ActionBackgroundState.Eat;

        playerState.Physical += 1; //体力の変更

        playerState.Mind += 1; //精神力の変更

        playerState.Money += 1;//お金の変更

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickSleep() //お金を使わず、体力と精神力を回復する
    {
        Action = ActionBackgroundState.Sleep;

        playerState.Physical += 1; //体力の変更

        playerState.Mind += 1; //精神力の変更

        playerState.Money += 1;//お金の変更

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickPark() //体力を使って精神力を回復する
    {
        Action = ActionBackgroundState.Park;

        playerState.Physical -= 1;

        playerState.Mind += 1;
        
        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickAquarium()//お金を使って精神力を回復する
    {
        Action = ActionBackgroundState.Aquarium;

        playerState.Money -= 1;

        playerState.Money += 1;
        
        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickShopping() //お金を使って倫理値を回復する
    {
        Action = ActionBackgroundState.Shopping;

        playerState.Money -= 1;

        playerState.Mind += 1;
        
        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickPachinkoAndSlot()　//お金を使って、中毒値とお金を増やす
    {
        Action = ActionBackgroundState.PachinkoAndSlot;



        int rnd = Random.RandomRange(1, 6);

        switch (rnd)
        {
            case 1://大勝

                playerState.Addiction += 10;
                playerState.Money += 80000;
                break;

            case 2://勝ち
                playerState.Addiction += 5;
                playerState.Money += 40000;
                break;

            case 3://トントン
                playerState.Addiction += 3;
                break;
            case 4://負け
                playerState.Addiction += 2;
                playerState.Money -= 40000;
                break;
            case 5://大負け
                playerState.Addiction += 1;
                playerState.Money -= 80000;
                break;

                
        }

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickBortRace() //お金を使って、中毒値とお金を増やす
    {
        Action = ActionBackgroundState.Bortrace;

        int rnd = Random.RandomRange(1, 6);

        switch (rnd)
        {
            case 1://大勝

                playerState.Addiction += 10;
                playerState.Money += 100000;
                break;

            case 2://勝ち
                playerState.Addiction += 5;
                playerState.Money += 30000;
                break;

            case 3://トントン
                playerState.Addiction += 3;
                break;
            case 4://負け
                playerState.Addiction += 2;
                playerState.Money -= 50000;
                break;
            case 5://大負け
                playerState.Addiction += 1;
                playerState.Money -= 100000;
                break;


        }

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickBicyleRace() //お金を使って、中毒値とお金を増やす
    {
        Action = ActionBackgroundState.Bicyclerace;

        int rnd = Random.RandomRange(1, 6);

        switch (rnd)
        {
            case 1://大勝

                playerState.Addiction += 10;
                playerState.Money += 100000;
                break;

            case 2://勝ち
                playerState.Addiction += 5;
                playerState.Money += 50000;
                break;

            case 3://トントン
                playerState.Addiction += 3;
                break;
            case 4://負け
                playerState.Addiction += 2;
                playerState.Money -= 80000;
                break;
            case 5://大負け
                playerState.Addiction += 1;
                playerState.Money -= 150000;
                break;


        }
        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickHorseRase() //お金を使って、中毒値とお金を増やす
    {
        Action = ActionBackgroundState.Horserace;

        int rnd = Random.RandomRange(1, 6);

        switch (rnd)
        {
            case 1://大勝

                playerState.Addiction += 10;
                playerState.Money += 500000;
                break;

            case 2://トントン
                playerState.Addiction += 5;
                
                break;

            case 3://負け
                playerState.Addiction += 3;
                playerState.Money -= 50000;
                break;
            case 4://大負け
                playerState.Addiction += 2;
                playerState.Money -= 100000;
                break;
            case 5://超負け
                playerState.Addiction += 1;
                playerState.Money -= 200000;
                break;


        }


        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickLottery() //お金を使って、中毒値とお金を増やす
    {
        Action = ActionBackgroundState.Lottery;

        int rnd = Random.RandomRange(1, 6);

        switch (rnd)
        {
            case 1://勝ち

                playerState.Addiction += 10;
                playerState.Money += 100000000;
                break;

            case 2://負け
                playerState.Addiction += 5;
                playerState.Money -= 50000;
                break;

            case 3://負け
                playerState.Addiction += 3;
                playerState.Money -= 100000;
                break;
            case 4://大負け
                playerState.Addiction += 2;
                playerState.Money -= 500000;
                break;
            case 5://超大負け
                playerState.Addiction += 1;
                playerState.Money -= 1000000;
                break;
                
        }

        SceneManager.LoadScene("ResultScene");
    }



    public void OnClickPettycrime() //倫理値を下げて、お金と精神力と体力を増やす
    {
        Action = ActionBackgroundState.Pettycrime;

        int rnd = Random.RandomRange(1, 4);

        switch (rnd)
        {
            case 1://成功

                playerState.Ethic -= 5;

                playerState.Physical += 10;

                playerState.Mind += 10;

                playerState.Money += 10000;

                break;

            case 2://未遂

                playerState.Ethic -= 3;

                break;

            case 3://失敗

                SceneManager.LoadScene("EndScene");

                break;


        }

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickMidiumcrime()//倫理値を下げて、お金ちと精神力を増やす
    {
        Action = ActionBackgroundState.Midiumcrime;

        int rnd = Random.RandomRange(1, 6);

        switch (rnd)
        {
            case 1://成功

                playerState.Ethic -= 10;
                
                playerState.Money += 100000;

                break;

            case 2://未遂

                playerState.Ethic -= 5;

                break;

            case 3://未遂

                playerState.Ethic -= 5;

                break;

            case 4://失敗

                SceneManager.LoadScene("EndScene");

                break;

            case 5://失敗

                SceneManager.LoadScene("EndScene");

                break;


        }

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickHeveycrime()//倫理値を下げて、お金を増やす
    {
        Action = ActionBackgroundState.Heveycrime;//倫理値を大きく下げて、お金を大きく得る

        int rnd = Random.RandomRange(1, 6);

        switch (rnd)
        {
            case 1://成功

                playerState.Ethic -= 30;

                playerState.Money += 1000000;

                break;

            case 2://未遂

                playerState.Ethic -= 10;

                break;

            case 3://失敗

                SceneManager.LoadScene("EndScene");

                break;

            case 4://失敗

                SceneManager.LoadScene("EndScene");

                break;

            case 5://失敗

                SceneManager.LoadScene("EndScene");

                break;


        }


        SceneManager.LoadScene("ResultScene");
    }


}
