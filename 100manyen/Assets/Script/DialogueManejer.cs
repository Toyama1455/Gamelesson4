using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManejer : MonoBehaviour
{
    //“­‚¢‚½‚ÉƒZƒbƒg‚·‚é
    public Text Messege;//“­‚¢‚½‚ÌƒeƒLƒXƒg
    /*
    public Text Eat = null;//“­‚¢‚½‚ÌƒeƒLƒXƒg
    public Text Sleep = null;//“­‚¢‚½‚ÌƒeƒLƒXƒg
    public Text Park = null;//“­‚¢‚½‚ÌƒeƒLƒXƒg
    public Text Aquarium = null;//“­‚¢‚½‚ÌƒeƒLƒXƒg
    public Text Shopping = null;//“­‚¢‚½‚ÌƒeƒLƒXƒg
    public Text PachinAndSlot = null;//“­‚¢‚½‚ÌƒeƒLƒXƒg
    public Text Bortrace = null;//“­‚¢‚½‚ÌƒeƒLƒXƒg
    public Text Bicyclerace = null;//“­‚¢‚½‚ÌƒeƒLƒXƒg
    public Text Horserace = null;//“­‚¢‚½‚ÌƒeƒLƒXƒg
    public Text Lottery = null;//“­‚¢‚½‚ÌƒeƒLƒXƒg
    public Text Pettycrime = null;//“­‚¢‚½‚ÌƒeƒLƒXƒg
    public Text Mediumcrime = null;//“­‚¢‚½‚ÌƒeƒLƒXƒg
    public Text Hevycrime = null;//“­‚¢‚½‚ÌƒeƒLƒXƒg
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
    
    //ƒ[ƒN‚ÌƒZƒŠƒt‚Ìˆ—‚ğs‚¢‚Ü‚·
    void WorkMessege()
    {
        switch (PlayerState.WorkMoney)
        {
            case int i when i <= 10000:
                Messege.text = ("‚ª‚Á‚Â‚èƒTƒ{‚Á‚Ä" + PlayerState.WorkMoney + "‰~‚µ‚©‰Ò‚°‚Ü‚¹‚ñ‚Å‚µ‚½B" + 
                    "\n ”æ‚ê‚Ü‚µ‚½B@‘Ì—Í[‚P‚O ¸_—Í[‚P‚O‚µ‚Ü‚µ‚½B");
                
                break;

            case int i when i <= 20000:
                Messege.text = ("‚¿‚å‚Á‚ÆƒTƒ{‚Á‚Ä" + PlayerState.WorkMoney + "‰~‚µ‚©‰Ò‚°‚Ü‚¹‚ñ‚Å‚µ‚½B" +
                    "\n ”æ‚ê‚Ü‚µ‚½B@‘Ì—Í[‚P‚O ¸_—Í[‚P‚O‚µ‚Ü‚µ‚½B");
                break;

            case int i when i <= 30000:
                Messege.text = ("^–Ê–Ú‚É“­‚¢‚Ä" + PlayerState.WorkMoney + "‰~‚à‰Ò‚°‚Ü‚µ‚½" +
                    "\n ”æ‚ê‚Ü‚µ‚½B@‘Ì—Í[‚P‚O ¸_—Í[‚P‚O‚µ‚Ü‚µ‚½B");
                break;

            case int i when i <= 40000:
                Messege.text = ("’´Šæ’£‚Á‚Ä“­‚¢‚Ä" + PlayerState.WorkMoney + "‰~‚µ‚©‰Ò‚°‚Ü‚µ‚½" +
                    "\n ”æ‚ê‚Ü‚µ‚½B@‘Ì—Í[‚P‚O ¸_—Í[‚P‚O‚µ‚Ü‚µ‚½B");
                break;
                
            default:
                Messege.text = ("ƒoƒOƒŒƒxƒ‹" + PlayerState.WorkMoney + "‰~‰Ò‚¬‚Ü‚µ‚½B");
                break;
        }
        
    }
    void EatMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1:
                /*
                PlayerState.Physical += 50; //‘Ì—Í‚Ì•ÏX
                PlayerState.Mind += 50; //¸_—Í‚Ì•ÏX
                PlayerState.Money -= 15000;//‚¨‹à‚Ì•ÏX
                Debug.Log("‚‹‰‚ÈH–‚ğ‚µ‚Ü‚µ‚½B");
                */
                Messege.text = ("¡“ú‚Í•±”­‚µ‚Ä‚‹‰‚ÈH–‚ğ‚µ‚Ü‚µ‚½" + 
                    "\n ‚Æ‚Ä‚à‚¨‚¢‚µ‚©‚Á‚½‚Å‚·B@‘Ì—Í{‚T‚O@¸_—Í{‚T‚O@‹à[‚P‚T‚O‚O‚O‰~");

                break;

            case 2:
                /*
                PlayerState.Physical += 30; //‘Ì—Í‚Ì•ÏX
                PlayerState.Mind += 20; //¸_—Í‚Ì•ÏX
                PlayerState.Money -= 3000;//‚¨‹à‚Ì•ÏX
                Debug.Log("•’Ê‚ÌH–‚ğ‚µ‚Ü‚µ‚½B");
                */                
                Messege.text = ("¡“ú‚Í•’Ê‚ÉH–‚ğ‚µ‚Ü‚µ‚½" +
                    "\n ‚¨‚¢‚µ‚©‚Á‚½‚Å‚·B@‘Ì—Í{‚R‚O@¸_—Í{‚Q‚O@‹à[‚P‚O‚O‚O‚O‰~");
                
                break;
            case 3:
                /*
                PlayerState.Physical += 15; //‘Ì—Í‚Ì•ÏX
                PlayerState.Mind += 10; //¸_—Í‚Ì•ÏX
                PlayerState.Money -= 1000;//‚¨‹à‚Ì•ÏX
                Debug.Log("ß–ñ“I‚ÈH–‚ğ‚µ‚Ü‚µ‚½B");
                */
                Messege.text = ("¡“ú‚Í•’Ê‚ÉH–‚ğ‚µ‚Ü‚µ‚½" +
                    "\n ‚¨‚¢‚µ‚©‚Á‚½‚Å‚·B@‘Ì—Í{‚P‚T@¸_—Í{‚P‚O@‹à[‚P‚O‚O‚O‰~");
                break;
            default:
                Debug.Log("ƒoƒO‚Á‚Ä‚¢‚Ü‚·B‘‹}‚É’¼‚µ‚Ä‚­‚¾‚³‚¢");
                break;
        }

    }
    void SleepMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1:
                /*
                PlayerState.Physical += 20; //‘Ì—Í‚Ì•ÏX
                PlayerState.Mind += 30; //¸_—Í‚Ì•ÏX
                Debug.Log("n‡‚Å‚«‚Ü‚µ‚½B");
                */

                Messege.text = ("n‡‚Å‚«‚Ü‚µ‚½" +
                    "\n ‚Æ‚Ä‚àƒXƒbƒLƒŠ‚µ‚Ä‰õ’²‚Å‚·B@‘Ì—Í{‚Q‚O@¸_—Í{‚R‚O");
                break;
            case 2:
                /*
                PlayerState.Physical += 10; //‘Ì—Í‚Ì•ÏX
                PlayerState.Mind += 15; //¸_—Í‚Ì•ÏX                
                Debug.Log("•’Ê‚É–°‚ê‚Ü‚µ‚½");
                */
                Messege.text = ("•’Ê‚ÉQ‚é‚±‚Æ‚ª‚Å‚«‚Ü‚µ‚½" +
                    "\n ƒXƒbƒLƒŠ‚µ‚Ü‚µ‚½B@‘Ì—Í{‚P‚T@¸_—Í{‚P‚O");

                break;
            case 3:
                /*
                PlayerState.Physical += 5; //‘Ì—Í‚Ì•ÏX
                PlayerState.Mind += 10; //¸_—Í‚Ì•ÏX
                Debug.Log("‚ ‚Ü‚è–°‚ê‚Ü‚¹‚ñ‚Å‚µ‚½");
                */
                Messege.text = ("‚ ‚Ü‚è–°‚é‚±‚Æ‚ª‚Å‚«‚Ü‚¹‚ñ‚Å‚µ‚½" +
                    "\n ”æ‚ê‚Í‚¿‚å‚Á‚Æ‚Æ‚ê‚Ü‚µ‚½B@‘Ì—Í{‚T@¸_—Í{‚T");

                break;
            default:
                Debug.Log("ƒoƒO‚Á‚Ä‚¢‚Ü‚·B‘‹}‚É’¼‚µ‚Ä‚­‚¾‚³‚¢");
                break;
        }
    }

    void ParkMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1:
                /*
                PlayerState.Physical -= 15; //‘Ì—Í‚Ì•ÏX
                PlayerState.Mind += 30; //¸_—Í‚Ì•ÏX
                Debug.Log("‰“‚­‚ÌãY—í‚ÈŒö‰€‚É‚¢‚«‚Ü‚µ‚½");
                */
                Messege.text = ("‰“‚­‚ÌãY—í‚ÈŒö‰€‚És‚«‚Ü‚µ‚½" +
                    "\n ãY—í‚ÅS‚ªô‚í‚ê‚Ü‚µ‚½B@‘Ì—Í[‚P‚T@¸_—Í{‚R‚O");

                break;
            case 2:
                /*
                PlayerState.Physical -= 10; //‘Ì—Í‚Ì•ÏX
                PlayerState.Mind += 20; //¸_—Í‚Ì•ÏX                
                Debug.Log("‹ßê‚ÌãY—í‚ÈŒö‰€‚É‚¢‚«‚Ü‚µ‚½");
                */
                Messege.text = ("‹ßê‚ÌãY—í‚ÈŒö‰€‚És‚«‚Ü‚µ‚½" +
                    "\n –‘«‚Å‚«‚Ü‚µ‚½B@‘Ì—Í[‚P‚O@¸_—Í{‚Q‚O");
                
                break;
            case 3:
                /*
                PlayerState.Physical -= 5; //‘Ì—Í‚Ì•ÏX
                PlayerState.Mind += 10; //¸_—Í‚Ì•ÏX
                Debug.Log("‚»‚Ì‚Ö‚ñ‚ğU•à‚µ‚Ü‚µ‚½");
                */
                Messege.text = ("Œü‚©‚¤“r’†‚Å–‘«‚µ‚Ü‚µ‚½B" +
                    "\n U•à‚¶‚á‚ñA‚à‚¤B@‘Ì—Í[‚T@¸_—Í{‚P‚O");

                break;
            default:
                Debug.Log("ƒoƒO‚Á‚Ä‚¢‚Ü‚·B‘‹}‚É’¼‚µ‚Ä‚­‚¾‚³‚¢");
                break;
        }
    }

    void AquariumMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1:
                /*
                PlayerState.Money -= 15000; //Š‹à‚©‚çŒ¸‚ç‚·
                PlayerState.Mind += 50; //¸_—Í‚Ì•ÏX
                Debug.Log("‰“‚­‚Ì’´—L–¼…‘°ŠÙ‚És‚«‚Ü‚µ‚½");
                */
                Messege.text = ("‰“‚­‚Ì’´—L–¼…‘°ŠÙ‚És‚«‚Ü‚µ‚½B" +
                    "\n ãY—í‚ÅŠ´“®‚µ‚Ü‚µ‚½B@¸_—Í{‚T‚O@‹à[‚P‚T‚O‚O‚O‰~");

                break;
            case 2:
                /*
                PlayerState.Money -= 10000; //Š‹à‚©‚çŒ¸‚ç‚·
                PlayerState.Mind += 30; //¸_—Í‚Ì•ÏX
                Debug.Log("‹ßê‚Ì—L–¼…‘°ŠÙ‚És‚«‚Ü‚µ‚½");
                */
                Messege.text = ("‹ßê‚Ì—L–¼‚È…‘°ŠÙ‚És‚«‚Ü‚µ‚½B" +
                    "\n ãY—í‚Å‚µ‚½B@¸_—Í{‚R‚O@‹à[‚P‚O‚O‚O‚O‰~");

                break;
            case 3:
                /*
                PlayerState.Money -= 5000; //Š‹à‚©‚çŒ¸‚ç‚·
                PlayerState.Mind += 15; //¸_—Í‚Ì•ÏX
                Debug.Log("‚È‚ñ‚Æ‚È‚­…‘°ŠÙ‚És‚«‚Ü‚µ‚½");
                */
                Messege.text = ("‚È‚ñ‚Æ‚È‚­…‘°ŠÙ‚És‚«‚Ü‚µ‚½B" +
                    "\n Š¬”\o—ˆ‚Ü‚µ‚½B¸_—Í{‚P‚T@‹à[‚T‚O‚O‚O‰~");

                break;
            default:
                Debug.Log("ƒoƒO‚Á‚Ä‚¢‚Ü‚·B‘‹}‚É’¼‚µ‚Ä‚­‚¾‚³‚¢");
                break;
        }
    }

    void ShoppingMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1:
                /*
                PlayerState.Money -= 50000; //Š‹à‚©‚çŒ¸‚ç‚·
                PlayerState.Ethic += 50; //—Ï—’l‚Ì•ÏX
                Debug.Log("’´”š”ƒ‚¢‚µ‚Ü‚µ‚½");
                */
                Messege.text = ("‚‹‰‚¨‰Ùq‚ğ’´”š”ƒ‚¢‚ğ‚µ‚Ü‚µ‚½B" +
                    "\n –‘«‚µ‚Ü‚µ‚½B—Ï—’l{‚T‚O@‹à[‚T‚O‚O‚O‚O‰~");

                break;
            case 2:
                /*
                PlayerState.Money -= 30000; //Š‹à‚©‚çŒ¸‚ç‚·
                PlayerState.Ethic += 30; //—Ï—’l‚Ì•ÏX
                Debug.Log("”š”ƒ‚¢‚µ‚Ü‚µ‚½");
                */
                Messege.text = ("‚¨‰Ùq‚ğ”š”ƒ‚¢‚µ‚Ü‚µ‚½" +
                    "\n Š¬”\o—ˆ‚Ü‚µ‚½B—Ï—’l{‚R‚O@‹à[‚R‚O‚O‚O‚O‰~");

                break;
            case 3:
                /*
                PlayerState.Money -= 10000; //Š‹à‚©‚çŒ¸‚ç‚·
                PlayerState.Ethic += 15; //—Ï—’l‚Ì•ÏX
                Debug.Log("”ƒ‚¢•¨‚ğ‚µ‚Ü‚µ‚½");
                */
                Messege.text = ("‘Ê‰Ùq‚ğ”š”ƒ‚¢‚µ‚Ü‚µ‚½" +
                    "\n Š¬”\o—ˆ‚Ü‚µ‚½B—Ï—’l{‚P‚T@‹à[‚P‚O‚O‚O‚O‰~");

                break;
            default:
                Debug.Log("ƒoƒO‚Á‚Ä‚¢‚Ü‚·B‘‹}‚É’¼‚µ‚Ä‚­‚¾‚³‚¢");
                break;
        }
    }

    void PachinAndSlotMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1://‘åŸ
                /*
                PlayerState.Addiction += 10;
                PlayerState.Money += 80000;
                Debug.Log("ƒpƒ`ƒ“ƒR‚Å‘åŸ‚¿‚µ‚Ü‚µ‚½");
                */
                Messege.text = ("‚Æ‚ ‚é‰ÈŠw‚Ì’´“d¥–C‚Ìƒpƒ`ƒ“ƒR‚Å‘åŸ‚¿‚µ‚Ü‚µ‚½" +
                    "\n ‚Æ‚Ä‚àŠy‚µ‚©‚Á‚½‚Å‚·B’†“Å’l{‚P‚T@‹à{‚W‚O‚O‚O‚O‰~");
                break;

            case 2://Ÿ‚¿
                /*
                PlayerState.Addiction += 5;
                PlayerState.Money += 40000;
                Debug.Log("ƒpƒ`ƒ“ƒR‚ÅŸ‚¿‚µ‚Ü‚µ‚½");
                */
                Messege.text = ("ƒKƒ“ƒ_ƒ€‚t‚b‚ÅŸ‚¿‚Ü‚µ‚½" +
                    "\n Š¬”\o—ˆ‚Ü‚µ‚½B’†“Å’l{‚P‚O@‹à{‚S‚O‚O‚O‚O‰~");

                break;

            case 3://ƒgƒ“ƒgƒ“
                /*
                PlayerState.Addiction += 3;
                Debug.Log("ƒpƒ`ƒ“ƒR‚Åƒgƒ“ƒgƒ“‚Å‚µ‚½");
                */
                Messege.text = ("µ‚Â‚Ì‘åß‚Q‚Åƒgƒ“ƒgƒ“‚Å‚µ‚½" +
                    "\n ‚Ü‚½Ÿ•‰‚µ‚Ü‚·B’†“Å’l{‚P‚O");

                break;
            case 4://•‰‚¯
                   /*
                   PlayerState.Addiction += 2;
                   PlayerState.Money -= 40000;
                   Debug.Log("ƒpƒ`ƒ“ƒR‚Å•‰‚¯‚Ü‚µ‚½");
                   */
                Messege.text = ("‹S‚ª‚©‚èƒŠƒ[ƒ‚Å•‰‚¯‚Ü‚µ‚½" +
                    "\n B‰÷‚µ‚©‚Á‚½‚Ì‚ÅƒŠƒxƒ“ƒW‚µ‚Ü‚·B’†“Å’l{2@‹à[‚S‚O‚O‚O‚O‰~");

                break;
            case 5://‘å•‰‚¯
                   /*
                   PlayerState.Addiction += 1;
                   PlayerState.Money -= 80000;
                   Debug.Log("ƒpƒ`ƒ“ƒR‚Å‘å•‰‚¯‚Ü‚µ‚½");
                   */
                Messege.text = ("‘åH‚ÌŒ´‚³‚ñ‚Å‘å•‰‚µ‚Ü‚µ‚½B" +
                    "\n “ñ“x‚Æ‚¤‚¿‚Ü‚¹‚ñB’†“Å’l{‚P@‹à[‚W‚O‚O‚O‚O‰~");
                break;


        }
    }

    void BortraceMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1://‘åŸ
                /*
                PlayerState.Addiction += 10;
                PlayerState.Money += 100000;
                */
                Messege.text = ("‘åŒŠ‚É‚©‚¯‚ÄŒ©–“–‚½‚è‚Ü‚µ‚½" +
                    "\n ”’”M‚µ‚½‡‚Å‚µ‚½B’†“Å’l{‚P‚O@‹à{‚P‚O‚O‚O‚O‚O‰~");
                break;

            case 2://Ÿ‚¿
                /*
                    PlayerState.Addiction += 5;
                    PlayerState.Money += 30000;
                */
                Messege.text = ("l‹C‚Ì‚à‚Ì‚É‚©‚¯‚ÄŸ‚¿‚Ü‚µ‚½" +
                    "\n@Šy‚µ‚©‚Á‚½‚Å‚·B’†“Å’l{‚T@‹à{‚R‚O‚O‚O‚O‰~");

                break;

            case 3://ƒgƒ“ƒgƒ“
                /*
                    PlayerState.Addiction += 3;
                */
                Messege.text = ("l‹C‡‚É‚È‚è‚Ü‚µ‚½B" +
                    "\n ‚Ü‚½¡“x—ˆ‚æ‚¤...B’†“Å’l{‚R");

                break;
            case 4://•‰‚¯
                   /*
                    PlayerState.Addiction += 2;
                    PlayerState.Money -= 50000;
                   */
                Messege.text = ("l‹C‡‚ª‚¿‚å‚Á‚Æ‚¸‚ê‚Ü‚µ‚½B" +
                    "\n @‚Ü‚½¡“xA‘åŒŠ‚É‚©‚¯‚Ü‚·B’†“Å’l{2@‹à[‚T‚O‚O‚O‚O‰~");

                break;
            case 5://‘å•‰‚¯
                   /*
                   PlayerState.Addiction += 1;
                   PlayerState.Money -= 100000;
                   */
                Messege.text = ("‚©‚¯‚Ä‚È‚¢‘åŒŠ‡‚É‚È‚è‚Ü‚µ‚½B" +
                    "\n ‚©‚¯‚Ä‚¢‚½‚à‚Ì‘S•”‚ª–³‘Ê‚É‚È‚è‚Ü‚µ‚½B’†“Å’l{‚P@‹à[‚P‚O‚O‚O‚O‚O‰~");
                break;


        }
    }

    void BicycleraceMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1://‘åŸ
                /*
                 * 
                 * 
                 * 
                */
                Messege.text = ("‘åŒŠ‚É‚©‚¯‚ÄŒ©–“–‚½‚è‚Ü‚µ‚½" +
                    "\n ”’”M‚µ‚½‡‚Å‚µ‚½B’†“Å’l{‚P‚O@‹à{‚P‚O‚O‚O‚O‚O‰~");
                break;

            case 2://Ÿ‚¿
                /*
                 *
                 * 
                */
                Messege.text = ("l‹C‚Ì‚à‚Ì‚É‚©‚¯‚ÄŸ‚¿‚Ü‚µ‚½" +
                    "\n@Šy‚µ‚©‚Á‚½‚Å‚·B’†“Å’l{‚T@‹à{‚T‚O‚O‚O‚O‰~");

                break;

            case 3://ƒgƒ“ƒgƒ“
                /*
                   @
                */
                Messege.text = ("l‹C‡‚É‚È‚è‚Ü‚µ‚½B" +
                    "\n ‚Ü‚½¡“x—ˆ‚æ‚¤...B’†“Å’l{‚R");

                break;
            case 4://•‰‚¯
                   /*
                    
                   */
                Messege.text = ("l‹C‡‚ª‚¿‚å‚Á‚Æ‚¸‚ê‚Ü‚µ‚½B" +
                    "\n @‚Ü‚½¡“xA‘åŒŠ‚É‚©‚¯‚Ü‚·B’†“Å’l{2@‹à[‚W‚O‚O‚O‚O‰~");

                break;
            case 5://‘å•‰‚¯
                   /*
                   

                   */
                Messege.text = ("‚©‚¯‚Ä‚È‚¢‘åŒŠ‡‚É‚È‚è‚Ü‚µ‚½B" +
                    "\n ‚©‚¯‚Ä‚¢‚½‚à‚Ì‘S•”‚ª–³‘Ê‚É‚È‚è‚Ü‚µ‚½B’†“Å’l{‚P@‹à[‚P‚T‚O‚O‚O‚O‰~");
                break;


        }
    }

    void HorseraceMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1://‘åŸ
                /*
                PlayerState.Addiction += 10;
                PlayerState.Money += 500000;
                */
                Messege.text = ("‚©‚¯‚Ä‚¢‚½‘åŒŠ‚ªŒ©–“–‚½‚è‚Ü‚µ‚½B" +
                    "\n ‘åŸ‚µ‚Ü‚µ‚½B’†“Å’l{‚P‚O@‹à[‚T‚O‚O‚O‚O‚O‰~");
                break;

            case 2://ƒgƒ“ƒgƒ“
                /*
                PlayerState.Addiction += 5;
                */
                Messege.text = ("l‹C‡’Ê‚è‚É‚È‚è‚Ü‚µ‚½" +
                    "\n ‚¨‹à‚Í‚©‚¯‚½‹àŠz‹A‚Á‚Ä‚«‚Ü‚µ‚½B’†“Å’l{‚T");
                break;

            case 3://•‰‚¯
                /*
                PlayerState.Addiction += 3;
                PlayerState.Money -= 50000;
                */
                Messege.text = ("l‹C‡‚ª‚¿‚å‚Á‚Æ‚©‚í‚è‚Ü‚µ‚½B" +
                    "\n ­‚µ‚©‚¯‚Ä‚¢‚½‚Ì‚Å‘¹‚ğ‚µ‚Ü‚µ‚½B’†“Å’l{‚R@‹à[‚T‚O‚O‚O‚O‰~");
                break;
            case 4://‘å•‰‚¯
                /*
                PlayerState.Addiction += 2;
                PlayerState.Money -= 100000;
                */

                Messege.text = ("‡ˆÊ‚ªr‚ê‚Ä‘åŒŠ‚ÈŒ‹‰Ê‚Æ‚È‚è‚Ü‚µ‚½B" +
                    "\n ‚©‚¯‚Ä‚¢‚½‚à‚Ì‚ª–³‘Ê‚É‚È‚è‚Ü‚µ‚½B’†“Å’l{‚Q@‹à[‚P‚O‚O‚O‚O‚O‰~");
                break;
            case 5://’´•‰‚¯
                /*
                PlayerState.Addiction += 1;
                PlayerState.Money -= 200000;
                */

                Messege.text = ("‡ˆÊ‚ªr‚ê‚Ér‚êA‚©‚¯‚Ä‚È‚¢‘åŒŠ‡‚É‚È‚è‚Ü‚µ‚½B" +
                    "\n ‚©‚¯‚Ä‚¢‚½‚à‚Ì‘S•”‚ª–³‘Ê‚É‚È‚è‚Ü‚µ‚½B’†“Å’l{‚P@‹à[‚Q‚O‚O‚O‚O‚O‰~");
                break;


        }

    }

    void LotteryMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1://Ÿ‚¿
                /*
                PlayerState.Addiction += 100;
                PlayerState.Money += 100000000;
                */
                Messege.text = ("•ó‚­‚¶‚P“™‚ªŒ©–“–‘I‚µ‚Ü‚µ‚½" +
                    "\n l¶—V‚ñ‚Å•é‚ç‚¹‚é‚æ‚¤‚É‚È‚è‚Ü‚µ‚½B’†“Å’l{‚P‚O‚O@‹à{‚P‚O‚O‚O‚O‚O‚O‚O‚O‰~");
                break;

            case 2://•‰‚¯
                /*
                PlayerState.Addiction += 5;
                PlayerState.Money -= 50000;
                */
                Messege.text = ("•¡”“–‘I‚µ‚½‚½‚ßAŠy‚µ‚ß‚Ü‚µ‚½B" +
                    "\n ‚¿‚å‚Á‚Æ‘¹‚ğ‚µ‚Ü‚µ‚½B’†“Å’l{‚T@‹à[‚T‚O‚O‚O‚O‰~");
                break;

            case 3://•‰‚¯
                /*
                PlayerState.Addiction += 10;
                PlayerState.Money -= 100000;
                */
                Messege.text = ("“–‘I”‚ª­‚È‚©‚Á‚½‚Å‚·B" +
                    "\n Œ‹\A‘¹‚ğ‚µ‚Ü‚µ‚½B’†“Å’l{‚P‚O@‹à[‚P‚O‚O‚O‚O‚O‰~");
                break;
            case 4://‘å•‰‚¯
                /*
                PlayerState.Addiction += 20;
                PlayerState.Money -= 500000;
                */
                Messege.text = ("•ó‚­‚¶‚ğ”ƒ‚¢‚İ‚·‚¬‚Ü‚µ‚½B" +
                    "\n ‚ß‚¿‚á‚­‚¿‚á•‰‚¯‚Ü‚µ‚½B’†“Å’l{‚Q‚O@‹à[‚T‚O‚O‚O‚O‚O‰~");
                break;
            case 5://’´‘å•‰‚¯
                /*
                PlayerState.Addiction += 30;
                PlayerState.Money -= 1000000;
                */
                Messege.text = ("‚P‚O‚O–œ‰~•ª”ƒ‚Á‚½‚ª“–‚½‚è‚Ü‚¹‚ñ‚Å‚µ‚½B" +
                    "\n ‹ƒ‚¢‚½GGB’†“Å’l{‚R‚O@‹à[‚P‚O‚O‚O‚O‚O‚O‰~");

                break;

        }
    }

    void PettycrimeMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1://¬Œ÷
                /*
                PlayerState.Ethic -= 5;

                PlayerState.Physical += 10;

                PlayerState.Mind += 10;

                PlayerState.Money += 10000;
                */
                Messege.text = ("–œˆø‚«‚É¬Œ÷‚µ‚Ü‚µ‚½B" +
                    "\n –œˆø‚«‚µ‚½¤•i‚Å‚¨• ‚ğ–c‚ç‚Ü‚¹A“]”„‚µ‚Ä‚¨‹à‚ğ–×‚¯‚Ü‚µ‚½B" +
                    "\n —Ï—’l[‚T@‘Ì—Í{‚P‚O@¸_—Í{‚P‚O@‹à{‚P‚O‚O‚O‚O‰~");

                break;

            case 2://–¢‹
                /*
                PlayerState.Ethic -= 3;
                SceneManager.LoadScene("ResultScene");
                */
                Messege.text = ("–œˆø‚«‚ğ‚µ‚æ‚¤v‚¢‚Ü‚µ‚½‚ª‚â‚ß‚Ü‚µ‚½B" +
                    "\n ƒJƒƒ‰‚ÌˆÊ’u‚ªâ–­‚¾‚Á‚½‚©‚ç‚Å‚·B" +
                    "\n —Ï—’l[‚R");

                break;

            case 3://¸”s
                /*
                PlayerState.EndingNum = 5;

                SceneManager.LoadScene("ResultScene");
                */
                Messege.text = ("–œˆø‚«‚É¸”s‚µ‚Ü‚µ‚½B" +
                    "\n ’Ê‚è‚·‚ª‚è‚ÌŒx@‚É•ß‚Ü‚è‚Ü‚µ‚½B");

                break;


        }
    }

    void MediumcrimeMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1://¬Œ÷
                   /*
                   PlayerState.Ethic -= 10;

                   PlayerState.Money += 100000;

                   SceneManager.LoadScene("ResultScene");
                   */
                Messege.text = ("ƒŒƒW‹­“‚É¬Œ÷‚µ‚Ü‚µ‚½B" +
                     "\n ‚¿‚å‚Á‚Æ‚µ‚½‘å‹à‚ğ“¾‚ç‚ê‚Ü‚µ‚½B" +
                     "\n —Ï—’l[‚P‚O@‹à‚P‚O‚O‚O‚O‚O‰~");

                break;

            case 2://–¢‹
                /*
                PlayerState.Ethic -= 5;
                SceneManager.LoadScene("ResultScene");
                */
                Messege.text = ("Œˆs‚µ‚æ‚¤‚Æ‚µ‚½‚ÉŒx@‚ª‚¢‚Ü‚µ‚½B" +
                    "\n ¡‰ñ‚ÍŒ©‘—‚è‚Ü‚µ‚½B@—Ï—’l[‚T");

                break;

            case 3://–¢‹
                /*
                PlayerState.Ethic -= 5;
                SceneManager.LoadScene("ResultScene");
                */
                Messege.text = ("ŠÄ‹ƒJƒƒ‰‚ª‘‘å‚³‚ê‚Ä‚¨‚èAìí’Ê‚è‚És‚«‚Ü‚¹‚ñ‚Å‚µ‚½B" +
                    "\n ¡‰ñ‚ÍŒ©‘—‚è‚Ü‚µ‚½B—Ï—’l[‚T");

                break;

            case 4://¸”s
                   /*
                   PlayerState.EndingNum = 5;

                   SceneManager.LoadScene("ResultScene");
                   */
                Messege.text = ("e‚ÌˆÀ‘SƒƒbƒN‚ğŠO‚µ–Y‚ê‚Ü‚µ‚½B" +
                             "\n •ß‚Ü‚è‚Ü‚µ‚½B");
                break;

            case 5://¸”s
                /*
                PlayerState.EndingNum = 5;
                SceneManager.LoadScene("ResultScene");
                */
                Messege.text = ("“¦‘–“r’†‚Éƒpƒ“ƒN‚µ‚Ü‚µ‚½B" +
                    @@@@ "\n •ß‚Ü‚è‚Ü‚µ‚½B");
                break;
                
        }
    }

    void HevycrimeMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1://¬Œ÷
                /*
                PlayerState.Ethic -= 30;

                PlayerState.Money += 1000000;

                Debug.Log("¬Œ÷‚µ‚Ü‚µ‚½");

                SceneManager.LoadScene("ResultScene");
                */
                Messege.text = ("ƒ^[ƒQƒbƒg‚Ìn––‚É¬Œ÷‚µ‚Ü‚µ‚½B" +
                     "\n Œ_–ñ‹à‚ğ“¾‚ç‚ê‚Ü‚µ‚½B" +
                     "\n —Ï—’l[‚R‚O@‹à‚P‚O‚O‚O‚O‚O‚O‰~");
                break;

            case 2://–¢‹
                /*
                PlayerState.Ethic -= 10;

                Debug.Log("–¢‹‚ÉI‚í‚è‚Ü‚µ‚½");
                SceneManager.LoadScene("ResultScene");
                */
                Messege.text = ("ƒ^[ƒQƒbƒg‚ªŒ»‚ê‚Ü‚¹‚ñ‚Å‚µ‚½B" +
                   @@@@  "\n ¡‰ñ‚ÍŒ©‘—‚è‚Ü‚µ‚½B@—Ï—’l[‚P‚O");

                break;

            case 3://¸”s
                /*
                PlayerState.EndingNum = 5;

                Debug.Log("¸”s‚µ‚Ü‚µ‚½");

                SceneManager.LoadScene("ResultScene");
                */
                Messege.text = ("ƒ^[ƒQƒbƒg‚É•Ô‚è“¢‚¿‚É‚³‚ê‚Ü‚µ‚½B" +
                    @@@@ "\n •ß‚Ü‚è‚Ü‚µ‚½B");

                break;

            case 4://¸”s
                /*
                PlayerState.EndingNum = 5;

                Debug.Log("¸”s‚µ‚Ü‚µ‚½‚Q");
                Debug.Log(PlayerState.EndingNum);

                SceneManager.LoadScene("ResultScene");
                */
                Messege.text = ("‘_‚Á‚Ä‚¢‚é‚Ì‚ªƒoƒŒ‚Ä‚¢‚Ü‚µ‚½B" +
                             "\n •ß‚Ü‚è‚Ü‚µ‚½");


                break;

            case 5://¸”s
                /*
                PlayerState.EndingNum = 5;

                Debug.Log("¸”s‚µ‚Ü‚µ‚½‚R");
                Debug.Log(PlayerState.EndingNum);

                SceneManager.LoadScene("ResultScene");
                */
                Messege.text = ("n––‚µ‚½‚ÉŒx@‚ÉŒ©‚ç‚ê‚Ä‚¢‚Ü‚µ‚½B" +
                   @@@@  "\n •ß‚Ü‚è‚Ü‚µ‚½B");

                break;

        }
    }




}
