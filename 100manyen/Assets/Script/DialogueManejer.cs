using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManejer : MonoBehaviour
{
    //働いた時にセットする
    public Text Messege;//働いた時のテキスト
    /*
    public Text Eat = null;//働いた時のテキスト
    public Text Sleep = null;//働いた時のテキスト
    public Text Park = null;//働いた時のテキスト
    public Text Aquarium = null;//働いた時のテキスト
    public Text Shopping = null;//働いた時のテキスト
    public Text PachinAndSlot = null;//働いた時のテキスト
    public Text Bortrace = null;//働いた時のテキスト
    public Text Bicyclerace = null;//働いた時のテキスト
    public Text Horserace = null;//働いた時のテキスト
    public Text Lottery = null;//働いた時のテキスト
    public Text Pettycrime = null;//働いた時のテキスト
    public Text Mediumcrime = null;//働いた時のテキスト
    public Text Hevycrime = null;//働いた時のテキスト
    */

    // Start is called before the first frame update
    void Start()
    {
        switch (SceneScript.Action)
        {
            case ActionBackgroundState.Error:
                break;

            case ActionBackgroundState.Work:
                WorkMessege();
                break;

            case ActionBackgroundState.Eat:
                EatMessege();
                break;

            case ActionBackgroundState.Sleep:
                SleepMessege();
                break;

            case ActionBackgroundState.Park:
                ParkMessege();
                break;

            case ActionBackgroundState.Aquarium:
                AquariumMessege();
                break;

            case ActionBackgroundState.Shopping:
                ShoppingMessege();
                break;

            case ActionBackgroundState.PachinkoAndSlot:
                PachinAndSlotMessege();
                break;

            case ActionBackgroundState.Bortrace:
                BortraceMessege();
                break;

            case ActionBackgroundState.Bicyclerace:
                BicycleraceMessege();
                break;

            case ActionBackgroundState.Horserace:
                HorseraceMessege();
                break;

            case ActionBackgroundState.Lottery:
                LotteryMessege();
                break;

            case ActionBackgroundState.Pettycrime:
                PettycrimeMessege();
                break;

            case ActionBackgroundState.Midiumcrime:
                MediumcrimeMessege();
                break;

            case ActionBackgroundState.Heveycrime:
                HevycrimeMessege();
                break;
            default:
                break;
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    //ワークのセリフの処理を行います
    void WorkMessege()
    {
        switch (PlayerState.WorkMoney)
        {
            case int i when i <= 10000:
                Messege.text = ("がっつりサボって" + PlayerState.WorkMoney + "円しか稼げませんでした。" + 
                    "\n 疲れました。　体力ー１０ 精神力ー１０しました。");
                
                break;

            case int i when i <= 30000:
                Messege.text = ("ちょっとサボって" + PlayerState.WorkMoney + "円しか稼げませんでした。" +
                    "\n 疲れました。　体力ー１０ 精神力ー１０しました。");
                break;

            case int i when i <= 40000:
                Messege.text = ("真面目に働いて" + PlayerState.WorkMoney + "円も稼げました" +
                    "\n 疲れました。　体力ー１０ 精神力ー１０しました。");
                break;

            case int i when i <= 50000:
                Messege.text = ("超頑張って働いて" + PlayerState.WorkMoney + "円しか稼げました" +
                    "\n 疲れました。　体力ー１０ 精神力ー１０しました。");
                break;
                
            default:
                Messege.text = ("バグレベル" + PlayerState.WorkMoney + "円稼ぎました。");
                break;
        }
        
    }
    void EatMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1:
                /*
                PlayerState.Physical += 50; //体力の変更
                PlayerState.Mind += 50; //精神力の変更
                PlayerState.Money -= 15000;//お金の変更
                Debug.Log("高級な食事をしました。");
                */
                Messege.text = ("今日は奮発して高級な食事をしました" + 
                    "\n とてもおいしかったです。　体力＋５０　精神力＋５０　金　ー１５０００円");

                break;

            case 2:
                /*
                PlayerState.Physical += 30; //体力の変更
                PlayerState.Mind += 20; //精神力の変更
                PlayerState.Money -= 3000;//お金の変更
                Debug.Log("普通の食事をしました。");
                */                
                Messege.text = ("今日は普通に食事をしました" +
                    "\n おいしかったです。　体力＋３０　精神力＋２０　金　ー１００００円");
                
                break;
            case 3:
                /*
                PlayerState.Physical += 15; //体力の変更
                PlayerState.Mind += 10; //精神力の変更
                PlayerState.Money -= 1000;//お金の変更
                Debug.Log("節約的な食事をしました。");
                */
                Messege.text = ("今日は普通に食事をしました" +
                    "\n おいしかったです。　体力＋１５　精神力＋１０　金　ー１０００円");
                break;
            default:
                Debug.Log("バグっています。早急に直してください");
                break;
        }

    }
    void SleepMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1:
                /*
                PlayerState.Physical += 20; //体力の変更
                PlayerState.Mind += 30; //精神力の変更
                Debug.Log("熟睡できました。");
                */

                Messege.text = ("熟睡できました" +
                    "\n とてもスッキリして快調です。　体力＋２０　精神力＋３０");
                break;
            case 2:
                /*
                PlayerState.Physical += 10; //体力の変更
                PlayerState.Mind += 15; //精神力の変更                
                Debug.Log("普通に眠れました");
                */
                Messege.text = ("普通に寝ることができました" +
                    "\n スッキリしました。　体力＋１５　精神力＋１０　金");

                break;
            case 3:
                /*
                PlayerState.Physical += 5; //体力の変更
                PlayerState.Mind += 10; //精神力の変更
                Debug.Log("あまり眠れませんでした");
                */
                Messege.text = ("あまり眠ることができませんでした" +
                    "\n 疲れはちょっととれました。　体力＋５　精神力＋５");

                break;
            default:
                Debug.Log("バグっています。早急に直してください");
                break;
        }
    }

    void ParkMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1:
                /*
                PlayerState.Physical -= 15; //体力の変更
                PlayerState.Mind += 30; //精神力の変更
                Debug.Log("遠くの綺麗な公園にいきました");
                */
                Messege.text = ("遠くの綺麗な公園に行きました" +
                    "\n 綺麗で心が洗われました。　体力ー１５　精神力＋３０");

                break;
            case 2:
                /*
                PlayerState.Physical -= 10; //体力の変更
                PlayerState.Mind += 20; //精神力の変更                
                Debug.Log("近場の綺麗な公園にいきました");
                */
                Messege.text = ("近場の綺麗な公園に行きました" +
                    "\n 満足できました。　体力ー１０　精神力＋２０");
                
                break;
            case 3:
                /*
                PlayerState.Physical -= 5; //体力の変更
                PlayerState.Mind += 10; //精神力の変更
                Debug.Log("そのへんを散歩しました");
                */
                Messege.text = ("向かう途中で満足しました。" +
                    "\n 散歩じゃん、もう。　体力ー５　精神力＋１０");

                break;
            default:
                Debug.Log("バグっています。早急に直してください");
                break;
        }
    }

    void AquariumMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1:
                /*
                PlayerState.Money -= 15000; //所持金から減らす
                PlayerState.Mind += 50; //精神力の変更
                Debug.Log("遠くの超有名水族館に行きました");
                */
                Messege.text = ("遠くの超有名水族館に行きました。" +
                    "\n 綺麗で感動しました。　精神力＋５０　金　ー１５０００円");

                break;
            case 2:
                /*
                PlayerState.Money -= 10000; //所持金から減らす
                PlayerState.Mind += 30; //精神力の変更
                Debug.Log("近場の有名水族館に行きました");
                */
                Messege.text = ("近場の有名な水族館に行きました。" +
                    "\n 綺麗でした。　精神力＋３０　金　ー１００００円");

                break;
            case 3:
                /*
                PlayerState.Money -= 5000; //所持金から減らす
                PlayerState.Mind += 15; //精神力の変更
                Debug.Log("なんとなく水族館に行きました");
                */
                Messege.text = ("なんとなく水族館に行きました。" +
                    "\n 堪能出来ました。精神力＋１５　金　ー５０００円");

                break;
            default:
                Debug.Log("バグっています。早急に直してください");
                break;
        }
    }

    void ShoppingMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1:
                /*
                PlayerState.Money -= 50000; //所持金から減らす
                PlayerState.Ethic += 50; //倫理値の変更
                Debug.Log("超爆買いしました");
                */
                Messege.text = ("高級お菓子を超爆買いをしました。" +
                    "\n 満足しました。倫理値＋５０　金　ー５００００円");

                break;
            case 2:
                /*
                PlayerState.Money -= 30000; //所持金から減らす
                PlayerState.Ethic += 30; //倫理値の変更
                Debug.Log("爆買いしました");
                */
                Messege.text = ("お菓子を爆買いしました" +
                    "\n 堪能出来ました。倫理値＋３０　金　ー３００００円");

                break;
            case 3:
                /*
                PlayerState.Money -= 10000; //所持金から減らす
                PlayerState.Ethic += 15; //倫理値の変更
                Debug.Log("買い物をしました");
                */
                Messege.text = ("駄菓子を爆買いしました" +
                    "\n 堪能出来ました。倫理値＋１５　金　ー１００００円");

                break;
            default:
                Debug.Log("バグっています。早急に直してください");
                break;
        }
    }

    void PachinAndSlotMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1://大勝
                /*
                PlayerState.Addiction += 10;
                PlayerState.Money += 80000;
                Debug.Log("パチンコで大勝ちしました");
                */
                Messege.text = ("とある科学の超電磁砲のパチンコで大勝ちしました" +
                    "\n とても楽しかったです。中毒値＋１５　金　＋８００００円");
                break;

            case 2://勝ち
                /*
                PlayerState.Addiction += 5;
                PlayerState.Money += 40000;
                Debug.Log("パチンコで勝ちしました");
                */
                Messege.text = ("ガンダムＵＣで勝ちました" +
                    "\n 堪能出来ました。中毒値＋１０　金　＋４００００円");

                break;

            case 3://トントン
                /*
                PlayerState.Addiction += 3;
                Debug.Log("パチンコでトントンでした");
                */
                break;
            case 4://負け
                /*
                PlayerState.Addiction += 2;
                PlayerState.Money -= 40000;
                Debug.Log("パチンコで負けました");
                */
                break;
            case 5://大負け
                /*
                PlayerState.Addiction += 1;
                PlayerState.Money -= 80000;
                Debug.Log("パチンコで大負けました");
                */

                break;


        }
    }

    void BortraceMessege()
    {
        Messege.text = ("うううううううううう");
    }

    void BicycleraceMessege()
    {
        Messege.text = ("うううううううううう");
    }

    void HorseraceMessege()
    {
        Messege.text = ("うううううううううう");
    }

    void LotteryMessege()
    {
        Messege.text = ("うううううううううう");
    }

    void PettycrimeMessege()
    {
        Messege.text = ("うううううううううう");
    }

    void MediumcrimeMessege()
    {
        Messege.text = ("うううううううううう");
    }

    void HevycrimeMessege()
    {
        Messege.text = ("うううううううううう");
    }




}
