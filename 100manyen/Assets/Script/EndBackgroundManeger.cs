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
            //ED1 Ø‹à•ÔÏ
            case 1:
                Debug.Log("ED1‚Ì”wŒi‚ğ•\¦‚µ‚Ü‚µ‚½");
                ED1BackGround.gameObject.SetActive(true);

                break;
            //ED2 Ø‹à•ÔÏo—ˆ‚¸“à‘Ÿ”„‚èJ‚©‚ê‚ÄŠC‚Ì‘”‹û
            case 2:
                Debug.Log("ED2‚Ì”wŒi‚ğ•\¦‚µ‚Ü‚µ‚½");
                ED2BackGround.gameObject.SetActive(true);

                break;
            //ED3 ƒMƒƒƒ“ƒuƒ‰[A‹­§˜J“­‘Â‚¿
            case 3:
                Debug.Log("ED3‚Ì”wŒi‚ğ•\¦‚µ‚Ü‚µ‚½");
                ED3BackGround.gameObject.SetActive(true);

                break;
            //ED4 ƒMƒƒƒ“ƒuƒ‰[
            case 4:
                Debug.Log("ED4‚Ì”wŒi‚ğ•\¦‚µ‚Ü‚µ‚½");
                ED4BackGround.gameObject.SetActive(true);

                break;
            //ED5 ˜S–“üŠ
            case 5:
                Debug.Log("ED5‚Ì”wŒi‚ğ•\¦‚µ‚Ü‚µ‚½");
                ED5BackGround.gameObject.SetActive(true);

                break;
            //ED6 ‘å“D–_
            case 6:
                Debug.Log("ED6‚Ì”wŒi‚ğ•\¦‚µ‚Ü‚µ‚½");
                ED6BackGround.gameObject.SetActive(true);

                break;
            //ED7 €–S
            case 7:
                Debug.Log("ED7‚Ì”wŒi‚ğ•\¦‚µ‚Ü‚µ‚½");
                ED7BackGround.gameObject.SetActive(true);

                break;
            //ED8 •a‚İ—‚¿©E
            case 8:
                Debug.Log("ED8‚Ì”wŒi‚ğ•\¦‚µ‚Ü‚µ‚½");
                ED8BackGround.gameObject.SetActive(true);

                break;
            //ED9 ƒGƒ“ƒhƒŒƒXØ‹à
            case 9:
                Debug.Log("ED9‚Ì”wŒi‚ğ•\¦‚µ‚Ü‚µ‚½");
                ED9BackGround.gameObject.SetActive(true);

                break;
            //ED10 lŠÔ‚ÌƒNƒY
            case 10:
                Debug.Log("ED10‚Ì”wŒi‚ğ•\¦‚µ‚Ü‚µ‚½");
                ED10BackGround.gameObject.SetActive(true);

                break;
            //ED11@l¶I‚í‚è‘g
            case 11:
                Debug.Log("ED11‚Ì”wŒi‚ğ•\¦‚µ‚Ü‚µ‚½");
                ED11BackGround.gameObject.SetActive(true);

                break;
            //ƒoƒO
            default:
                Debug.Log("ƒoƒO‚Á‚Ä‚¢‚Ü‚·");
                ErrorBackground.gameObject.SetActive(true);
                break;

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
