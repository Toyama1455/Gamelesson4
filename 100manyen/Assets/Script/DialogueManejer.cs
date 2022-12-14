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

            case int i when i <= 20000:
                Messege.text = ("ちょっとサボって" + PlayerState.WorkMoney + "円しか稼げませんでした。" +
                    "\n 疲れました。　体力ー１０ 精神力ー１０しました。");
                break;

            case int i when i <= 30000:
                Messege.text = ("真面目に働いて" + PlayerState.WorkMoney + "円も稼げました" +
                    "\n 疲れました。　体力ー１０ 精神力ー１０しました。");
                break;

            case int i when i <= 40000:
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
                    "\n とてもおいしかったです。　体力＋５０　精神力＋５０　金ー１５０００円");

                break;

            case 2:
                /*
                PlayerState.Physical += 30; //体力の変更
                PlayerState.Mind += 20; //精神力の変更
                PlayerState.Money -= 3000;//お金の変更
                Debug.Log("普通の食事をしました。");
                */                
                Messege.text = ("今日は普通に食事をしました" +
                    "\n おいしかったです。　体力＋３０　精神力＋２０　金ー１００００円");
                
                break;
            case 3:
                /*
                PlayerState.Physical += 15; //体力の変更
                PlayerState.Mind += 10; //精神力の変更
                PlayerState.Money -= 1000;//お金の変更
                Debug.Log("節約的な食事をしました。");
                */
                Messege.text = ("今日は普通に食事をしました" +
                    "\n おいしかったです。　体力＋１５　精神力＋１０　金ー１０００円");
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
                    "\n スッキリしました。　体力＋１５　精神力＋１０");

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
                    "\n 綺麗で感動しました。　精神力＋５０　金ー１５０００円");

                break;
            case 2:
                /*
                PlayerState.Money -= 10000; //所持金から減らす
                PlayerState.Mind += 30; //精神力の変更
                Debug.Log("近場の有名水族館に行きました");
                */
                Messege.text = ("近場の有名な水族館に行きました。" +
                    "\n 綺麗でした。　精神力＋３０　金ー１００００円");

                break;
            case 3:
                /*
                PlayerState.Money -= 5000; //所持金から減らす
                PlayerState.Mind += 15; //精神力の変更
                Debug.Log("なんとなく水族館に行きました");
                */
                Messege.text = ("なんとなく水族館に行きました。" +
                    "\n 堪能出来ました。精神力＋１５　金ー５０００円");

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
                    "\n 満足しました。倫理値＋５０　金ー５００００円");

                break;
            case 2:
                /*
                PlayerState.Money -= 30000; //所持金から減らす
                PlayerState.Ethic += 30; //倫理値の変更
                Debug.Log("爆買いしました");
                */
                Messege.text = ("お菓子を爆買いしました" +
                    "\n 堪能出来ました。倫理値＋３０　金ー３００００円");

                break;
            case 3:
                /*
                PlayerState.Money -= 10000; //所持金から減らす
                PlayerState.Ethic += 15; //倫理値の変更
                Debug.Log("買い物をしました");
                */
                Messege.text = ("駄菓子を爆買いしました" +
                    "\n 堪能出来ました。倫理値＋１５　金ー１００００円");

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
                    "\n とても楽しかったです。中毒値＋１５　金＋８００００円");
                break;

            case 2://勝ち
                /*
                PlayerState.Addiction += 5;
                PlayerState.Money += 40000;
                Debug.Log("パチンコで勝ちしました");
                */
                Messege.text = ("ガンダムＵＣで勝ちました" +
                    "\n 堪能出来ました。中毒値＋１０　金＋４００００円");

                break;

            case 3://トントン
                /*
                PlayerState.Addiction += 3;
                Debug.Log("パチンコでトントンでした");
                */
                Messege.text = ("七つの大罪２でトントンでした" +
                    "\n また勝負します。中毒値＋１０");

                break;
            case 4://負け
                   /*
                   PlayerState.Addiction += 2;
                   PlayerState.Money -= 40000;
                   Debug.Log("パチンコで負けました");
                   */
                Messege.text = ("鬼がかりリゼロで負けました" +
                    "\n 。悔しかったのでリベンジします。中毒値＋2　金ー４００００円");

                break;
            case 5://大負け
                   /*
                   PlayerState.Addiction += 1;
                   PlayerState.Money -= 80000;
                   Debug.Log("パチンコで大負けました");
                   */
                Messege.text = ("大工の原さんで大負しました。" +
                    "\n 二度とうちません。中毒値＋１　金ー８００００円");
                break;


        }
    }

    void BortraceMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1://大勝
                /*
                PlayerState.Addiction += 10;
                PlayerState.Money += 100000;
                */
                Messege.text = ("大穴にかけて見事当たりました" +
                    "\n 白熱した試合でした。中毒値＋１０　金＋１０００００円");
                break;

            case 2://勝ち
                /*
                    PlayerState.Addiction += 5;
                    PlayerState.Money += 30000;
                */
                Messege.text = ("人気のものにかけて勝ちました" +
                    "\n　楽しかったです。中毒値＋５　金＋３００００円");

                break;

            case 3://トントン
                /*
                    PlayerState.Addiction += 3;
                */
                Messege.text = ("人気順になりました。" +
                    "\n また今度来よう...。中毒値＋３");

                break;
            case 4://負け
                   /*
                    PlayerState.Addiction += 2;
                    PlayerState.Money -= 50000;
                   */
                Messege.text = ("人気順がちょっとずれました。" +
                    "\n 　また今度、大穴にかけます。中毒値＋2　金ー５００００円");

                break;
            case 5://大負け
                   /*
                   PlayerState.Addiction += 1;
                   PlayerState.Money -= 100000;
                   */
                Messege.text = ("かけてない大穴順になりました。" +
                    "\n かけていたもの全部が無駄になりました。中毒値＋１　金ー１０００００円");
                break;


        }
    }

    void BicycleraceMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1://大勝
                /*
                 * 
                 * 
                 * 
                */
                Messege.text = ("大穴にかけて見事当たりました" +
                    "\n 白熱した試合でした。中毒値＋１０　金＋１０００００円");
                break;

            case 2://勝ち
                /*
                 *
                 * 
                */
                Messege.text = ("人気のものにかけて勝ちました" +
                    "\n　楽しかったです。中毒値＋５　金＋５００００円");

                break;

            case 3://トントン
                /*
                   　
                */
                Messege.text = ("人気順になりました。" +
                    "\n また今度来よう...。中毒値＋３");

                break;
            case 4://負け
                   /*
                    
                   */
                Messege.text = ("人気順がちょっとずれました。" +
                    "\n 　また今度、大穴にかけます。中毒値＋2　金ー８００００円");

                break;
            case 5://大負け
                   /*
                   

                   */
                Messege.text = ("かけてない大穴順になりました。" +
                    "\n かけていたもの全部が無駄になりました。中毒値＋１　金ー１５００００円");
                break;


        }
    }

    void HorseraceMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1://大勝
                /*
                PlayerState.Addiction += 10;
                PlayerState.Money += 500000;
                */
                Messege.text = ("かけていた大穴が見事当たりました。" +
                    "\n 大勝しました。中毒値＋１０　金ー５０００００円");
                break;

            case 2://トントン
                /*
                PlayerState.Addiction += 5;
                */
                Messege.text = ("人気順通りになりました" +
                    "\n お金はかけた金額帰ってきました。中毒値＋５");
                break;

            case 3://負け
                /*
                PlayerState.Addiction += 3;
                PlayerState.Money -= 50000;
                */
                Messege.text = ("人気順がちょっとかわりました。" +
                    "\n 少しかけていたので損をしました。中毒値＋３　金ー５００００円");
                break;
            case 4://大負け
                /*
                PlayerState.Addiction += 2;
                PlayerState.Money -= 100000;
                */

                Messege.text = ("順位が荒れて大穴な結果となりました。" +
                    "\n かけていたものが無駄になりました。中毒値＋２　金ー１０００００円");
                break;
            case 5://超負け
                /*
                PlayerState.Addiction += 1;
                PlayerState.Money -= 200000;
                */

                Messege.text = ("順位が荒れに荒れ、かけてない大穴順になりました。" +
                    "\n かけていたもの全部が無駄になりました。中毒値＋１　金ー２０００００円");
                break;


        }

    }

    void LotteryMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1://勝ち
                /*
                PlayerState.Addiction += 100;
                PlayerState.Money += 100000000;
                */
                Messege.text = ("宝くじ１等が見事当選しました" +
                    "\n 人生遊んで暮らせるようになりました。中毒値＋１００　金＋１００００００００円");
                break;

            case 2://負け
                /*
                PlayerState.Addiction += 5;
                PlayerState.Money -= 50000;
                */
                Messege.text = ("複数当選したため、楽しめました。" +
                    "\n ちょっと損をしました。中毒値＋５　金ー５００００円");
                break;

            case 3://負け
                /*
                PlayerState.Addiction += 10;
                PlayerState.Money -= 100000;
                */
                Messege.text = ("当選数が少なかったです。" +
                    "\n 結構、損をしました。中毒値＋１０　金ー１０００００円");
                break;
            case 4://大負け
                /*
                PlayerState.Addiction += 20;
                PlayerState.Money -= 500000;
                */
                Messege.text = ("宝くじを買い込みすぎました。" +
                    "\n めちゃくちゃ負けました。中毒値＋２０　金ー５０００００円");
                break;
            case 5://超大負け
                /*
                PlayerState.Addiction += 30;
                PlayerState.Money -= 1000000;
                */
                Messege.text = ("１００万円分買ったが当たりませんでした。" +
                    "\n 泣いた；；。中毒値＋３０　金ー１００００００円");

                break;

        }
    }

    void PettycrimeMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1://成功
                /*
                PlayerState.Ethic -= 5;

                PlayerState.Physical += 10;

                PlayerState.Mind += 10;

                PlayerState.Money += 10000;
                */
                Messege.text = ("万引きに成功しました。" +
                    "\n 万引きした商品でお腹を膨らませ、転売してお金を儲けました。" +
                    "\n 倫理値ー５　体力＋１０　精神力＋１０　金＋１００００円");

                break;

            case 2://未遂
                /*
                PlayerState.Ethic -= 3;
                SceneManager.LoadScene("ResultScene");
                */
                Messege.text = ("万引きをしよう思いましたがやめました。" +
                    "\n カメラの位置が絶妙だったからです。" +
                    "\n 倫理値ー３");

                break;

            case 3://失敗
                /*
                PlayerState.EndingNum = 5;

                SceneManager.LoadScene("ResultScene");
                */
                Messege.text = ("万引きに失敗しました。" +
                    "\n 通りすがりの警察に捕まりました。");

                break;


        }
    }

    void MediumcrimeMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1://成功
                   /*
                   PlayerState.Ethic -= 10;

                   PlayerState.Money += 100000;

                   SceneManager.LoadScene("ResultScene");
                   */
                Messege.text = ("レジ強盗に成功しました。" +
                     "\n ちょっとした大金を得られました。" +
                     "\n 倫理値ー１０　金１０００００円");

                break;

            case 2://未遂
                /*
                PlayerState.Ethic -= 5;
                SceneManager.LoadScene("ResultScene");
                */
                Messege.text = ("決行しようとした時に警察がいました。" +
                    "\n 今回は見送りました。　倫理値ー５");

                break;

            case 3://未遂
                /*
                PlayerState.Ethic -= 5;
                SceneManager.LoadScene("ResultScene");
                */
                Messege.text = ("監視カメラが増大されており、作戦通りに行きませんでした。" +
                    "\n 今回は見送りました。倫理値ー５");

                break;

            case 4://失敗
                   /*
                   PlayerState.EndingNum = 5;

                   SceneManager.LoadScene("ResultScene");
                   */
                Messege.text = ("銃の安全ロックを外し忘れました。" +
                             "\n 捕まりました。");
                break;

            case 5://失敗
                /*
                PlayerState.EndingNum = 5;
                SceneManager.LoadScene("ResultScene");
                */
                Messege.text = ("逃走途中にパンクしました。" +
                    　　　　 "\n 捕まりました。");
                break;
                
        }
    }

    void HevycrimeMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1://成功
                /*
                PlayerState.Ethic -= 30;

                PlayerState.Money += 1000000;

                Debug.Log("成功しました");

                SceneManager.LoadScene("ResultScene");
                */
                Messege.text = ("ターゲットの始末に成功しました。" +
                     "\n 契約金を得られました。" +
                     "\n 倫理値ー３０　金１００００００円");
                break;

            case 2://未遂
                /*
                PlayerState.Ethic -= 10;

                Debug.Log("未遂に終わりました");
                SceneManager.LoadScene("ResultScene");
                */
                Messege.text = ("ターゲットが現れませんでした。" +
                   　　　　  "\n 今回は見送りました。　倫理値ー１０");

                break;

            case 3://失敗
                /*
                PlayerState.EndingNum = 5;

                Debug.Log("失敗しました");

                SceneManager.LoadScene("ResultScene");
                */
                Messege.text = ("ターゲットに返り討ちにされました。" +
                    　　　　 "\n 捕まりました。");

                break;

            case 4://失敗
                /*
                PlayerState.EndingNum = 5;

                Debug.Log("失敗しました２");
                Debug.Log(PlayerState.EndingNum);

                SceneManager.LoadScene("ResultScene");
                */
                Messege.text = ("狙っているのがバレていました。" +
                             "\n 捕まりました");


                break;

            case 5://失敗
                /*
                PlayerState.EndingNum = 5;

                Debug.Log("失敗しました３");
                Debug.Log(PlayerState.EndingNum);

                SceneManager.LoadScene("ResultScene");
                */
                Messege.text = ("始末した時に警察に見られていました。" +
                   　　　　  "\n 捕まりました。");

                break;

        }
    }




}
