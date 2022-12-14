using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndBackgroundManeger : MonoBehaviour
{
    [SerializeField]
    Image ErrorBackground;
    [SerializeField]
    Image ED1BackGround;
    [SerializeField]
    Image ED2BackGround;
    [SerializeField]
    Image ED3BackGround;
    [SerializeField]
    Image ED4BackGround;
    [SerializeField]
    Image ED5BackGround;
    [SerializeField]
    Image ED6BackGround;
    [SerializeField]
    Image ED7BackGround;
    [SerializeField]
    Image ED8BackGround;
    [SerializeField]
    Image ED9BackGround;
    [SerializeField]
    Image ED10BackGround;
    [SerializeField]
    Image ED11BackGround;
    
    // Start is called before the first frame update
    void Start()
    {
        switch (PlayerState.EndingNum)
        {
            //ED1 借金返済
            case 1:
                Debug.Log("ED1の背景を表示しました");
                ED1BackGround.gameObject.SetActive(true);

                break;
            //ED2 借金返済出来ず内臓売り捌かれて海の藻屑
            case 2:
                Debug.Log("ED2の背景を表示しました");
                ED2BackGround.gameObject.SetActive(true);

                break;
            //ED3 ギャンブラー、強制労働堕ち
            case 3:
                Debug.Log("ED3の背景を表示しました");
                ED3BackGround.gameObject.SetActive(true);

                break;
            //ED4 ギャンブラー
            case 4:
                Debug.Log("ED4の背景を表示しました");
                ED4BackGround.gameObject.SetActive(true);

                break;
            //ED5 牢獄入所
            case 5:
                Debug.Log("ED5の背景を表示しました");
                ED5BackGround.gameObject.SetActive(true);

                break;
            //ED6 大泥棒
            case 6:
                Debug.Log("ED6の背景を表示しました");
                ED6BackGround.gameObject.SetActive(true);

                break;
            //ED7 死亡
            case 7:
                Debug.Log("ED7の背景を表示しました");
                ED7BackGround.gameObject.SetActive(true);

                break;
            //ED8 病み落ち自殺
            case 8:
                Debug.Log("ED8の背景を表示しました");
                ED8BackGround.gameObject.SetActive(true);

                break;
            //ED9 エンドレス借金
            case 9:
                Debug.Log("ED9の背景を表示しました");
                ED9BackGround.gameObject.SetActive(true);

                break;
            //ED10 人間のクズ
            case 10:
                Debug.Log("ED10の背景を表示しました");
                ED10BackGround.gameObject.SetActive(true);

                break;
            //ED11　人生終わり組
            case 11:
                Debug.Log("ED11の背景を表示しました");
                ED11BackGround.gameObject.SetActive(true);

                break;

            case 12:
                Debug.Log("ED12の背景を表示しました");
                //ED12BackGround.gameObject.SetActive(true);

                break;
            //バグ
            default:
                Debug.Log("バグっています");
                ErrorBackground.gameObject.SetActive(true);
                break;

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
