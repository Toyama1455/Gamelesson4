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
            //ED1 �؋��ԍ�
            case 1:
                Debug.Log("ED1�̔w�i��\�����܂���");
                ED1BackGround.gameObject.SetActive(true);

                break;
            //ED2 �؋��ԍϏo������������J����ĊC�̑���
            case 2:
                Debug.Log("ED2�̔w�i��\�����܂���");
                ED2BackGround.gameObject.SetActive(true);

                break;
            //ED3 �M�����u���[�A�����J����
            case 3:
                Debug.Log("ED3�̔w�i��\�����܂���");
                ED3BackGround.gameObject.SetActive(true);

                break;
            //ED4 �M�����u���[
            case 4:
                Debug.Log("ED4�̔w�i��\�����܂���");
                ED4BackGround.gameObject.SetActive(true);

                break;
            //ED5 �S������
            case 5:
                Debug.Log("ED5�̔w�i��\�����܂���");
                ED5BackGround.gameObject.SetActive(true);

                break;
            //ED6 ��D�_
            case 6:
                Debug.Log("ED6�̔w�i��\�����܂���");
                ED6BackGround.gameObject.SetActive(true);

                break;
            //ED7 ���S
            case 7:
                Debug.Log("ED7�̔w�i��\�����܂���");
                ED7BackGround.gameObject.SetActive(true);

                break;
            //ED8 �a�ݗ������E
            case 8:
                Debug.Log("ED8�̔w�i��\�����܂���");
                ED8BackGround.gameObject.SetActive(true);

                break;
            //ED9 �G���h���X�؋�
            case 9:
                Debug.Log("ED9�̔w�i��\�����܂���");
                ED9BackGround.gameObject.SetActive(true);

                break;
            //ED10 �l�Ԃ̃N�Y
            case 10:
                Debug.Log("ED10�̔w�i��\�����܂���");
                ED10BackGround.gameObject.SetActive(true);

                break;
            //ED11�@�l���I���g
            case 11:
                Debug.Log("ED11�̔w�i��\�����܂���");
                ED11BackGround.gameObject.SetActive(true);

                break;
            //�o�O
            default:
                Debug.Log("�o�O���Ă��܂�");
                ErrorBackground.gameObject.SetActive(true);
                break;

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
