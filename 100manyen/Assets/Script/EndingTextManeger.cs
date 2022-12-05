using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingTextManeger : MonoBehaviour
{
    public Text Messege;
    public Text Endnum;
    // Start is called before the first frame update
    void Start()
    {
        switch (PlayerState.EndingNum)
        {
            //ED1 借金返済
            case 1:
                /*
                Debug.Log("これからの平穏な日々");
                SceneManager.LoadScene("EndScene");
                */
                End1();
                break;
            //ED2 借金返済出来ず内臓売り捌かれて海の藻屑
            case 2:
                /*
                Debug.Log("海の藻屑");
                SceneManager.LoadScene("EndScene");
                */
                End2();
                break;
            //ED3 ギャンブラー、強制労働堕ち
            case 3:
                /*
                Debug.Log("ギャンブル狂いの債務者は強制労働じゃぁぁあああ");
                SceneManager.LoadScene("EndScene");
                */
                End3();
                break;
            //ED4 ギャンブラー
            case 4:
                /*
                Debug.Log("一生これで食っていく");
                SceneManager.LoadScene("EndScene");
                */
                End4();
                break;
            //ED5 牢獄入所
            case 5:
                /*
                Debug.Log("監獄生活のはじまり");
                SceneManager.LoadScene("EndScene");
                */
                End5();
                break;
            //ED6 大泥棒
            case 6:
                /*
                Debug.Log("俺が令和の大泥棒だぜ");
                SceneManager.LoadScene("EndScene");
                */
                End6();
                break;
            //ED7 死亡
            case 7:
                /*
                Debug.Log("体力がなくなりました");
                SceneManager.LoadScene("EndScene");
                */
                End7();
                break;
            //ED8 病み落ち自殺
            case 8:
                /*
                Debug.Log("現実に耐え切れず自殺しました");
                SceneManager.LoadScene("EndScene");
                */
                End8();
                break;
            //ED9 エンドレス借金
            case 9:
                /*
                Debug.Log("返しても返しても増える借金");
                SceneManager.LoadScene("EndScene");
                */
                End9();
                break;
            //ED10 人間のクズ
            case 10:
                /*
                Debug.Log("お前、マジで人間のクズだな");
                SceneManager.LoadScene("EndScene");
                */
                End10();
                break;
            //ED11　人生終わり組
            case 11:
                /*
                Debug.Log("人として終わってんな");
                SceneManager.LoadScene("EndScene");
                */
                End11();
                break;
            //バグ
            default:
                Debug.Log("バグっています");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void End1()
    {
        //ED1 借金返済
        Messege.text = ("無事に借金を返すことができた。" +
                     "\n 親との縁はもう切れたし、これからは自由に生きていこう");

        Endnum.text = ("エンディングナンバー１　借金返済");
    }
    void End2()
    {
        //ED2 借金返済出来ず内臓売り捌かれて海の藻屑
        Messege.text = ("３０日経ったが俺は１００万円準備出来ずにいた" + 
                     "\n 「恨むなら自分の親を恨みな」" + 
                     "\n その言葉が最後に聞いた言葉だった" +
                     "\n そうして、俺は臓器をバラバラにされ" + 
                     "\n 残った体はドラム缶と共に海に還った");

        Endnum.text = ("エンディングナンバー２　バラバラ");
    }
    void End3()
    {
        //ED3 ギャンブラー、強制労働堕ち
        Messege.text = ("「お前、ギャンブルが好きなんだな」" +
                        "\n そうして、俺はこの世の終わりのような" +
                        "\n 労働施設に連れてこられた" + 
                        "\n 「お前は死ぬまでここで働くんだ,,,」");
        Endnum.text = ("エンディングナンバー３　地下労働");
    }
    void End4()
    {
        //ED4 ギャンブラー
        Messege.text = ("俺はギャンブルで成り上がった" + 
                        "\n 借金は返せたが、もう元の生活には戻れない");
        Endnum.text = ("エンディングナンバー４　これが夢のプロギャンブラー");
    }
    void End5()
    {
        //ED5 牢獄入所
        Messege.text = ("俺は罪がバレて、捕まってしまった" + 
                        "\n しかし、よかったかもしれない。" +
                        "\n 借金を返さなくて済むのだから...");
        Endnum.text = ("エンディングナンバー５　牢獄入所");
    }
    void End6()
    {
        //ED6 大泥棒
        Messege.text = ("俺はお金を稼ぐため、盗むことを続けた" +
                        "\n それで俺には異名がついた" + 
                        "\n 令和の大泥棒「コジキ」と...");
        Endnum.text = ("エンディングナンバー６　これが令和の大泥棒");
    }
    void End7()
    {
        //ED7 死亡
        Messege.text = ("朝起きると、体が言うことを聞かなかった" +
                        "\n そして、眠たくなってきたので、そのまま寝た。" +
                        "\n ''永遠''と起きることはなかった...");
        Endnum.text = ("エンディングナンバー７　死亡");
    }
    void End8()
    {
        //ED8 病み落ち自殺
        Messege.text = ("ふと、全てが嫌になった。" +
                        "\n 体が勝手に動いてある場所に向かった。" + 
                        "\n そこは自殺の名所だった。" +
                        "\n 「もうどうなってもいいや」" +
                        "\n そうして、体を投げ出した。" +
                        "\n 鈍い音とともに意識を失った...");
        Endnum.text = ("エンディングナンバー８　現実なんてどうでもいいや");
    }
    void End9()
    {
        //ED9 エンドレス借金
        Messege.text = ("あれ？いつの間にか借金が増えてる..." +
                        "\n " +
                        "\n 次の日" + 
                        "あれ？また増えてる..." +
                        "そうして、私は永遠と借金が増えていくのであった");
        Endnum.text = ("エンディングナンバー９　エンドレス借金");
    }
    void End10()
    {
        //ED10 人間のクズ
        Messege.text = ("借金が返せず、ギャンブルや犯罪まで犯した..." +
                        "\n どうすればいいんだ..." +
                        "\n もう、こうするしか..." + 
                        "\n 借金取りが来た時、咄嗟に取った行動" +
                        "\n 柔らかい嫌な感触、伝わってくる生温い液体" +
                        "\n 私は全力でその場かた逃げた...");
        Endnum.text = ("エンディングナンバー１０　逃げて、逃げて、また逃げる");
    }
    void End11()
    {
        //ED11　人生終わり組
        Messege.text = ("借金は返せた。" +
                        "\n しかし、やりすぎた" +
                        "\n 殺人に強盗、詐欺、ギャンブル..." +
                        "\n これからどうしよう..." +
                        "\n そうして、何か目的があるわけでもなくただ歩いた...");
        Endnum.text = ("エンディングナンバー１１　途方もない帰路");
    }
}
