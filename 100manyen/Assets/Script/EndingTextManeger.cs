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
            //ED1 �؋��ԍ�
            case 1:
                /*
                Debug.Log("���ꂩ��̕����ȓ��X");
                SceneManager.LoadScene("EndScene");
                */
                End1();
                break;
            //ED2 �؋��ԍϏo������������J����ĊC�̑���
            case 2:
                /*
                Debug.Log("�C�̑���");
                SceneManager.LoadScene("EndScene");
                */
                End2();
                break;
            //ED3 �M�����u���[�A�����J����
            case 3:
                /*
                Debug.Log("�M�����u�������̍��҂͋����J�����႟��������");
                SceneManager.LoadScene("EndScene");
                */
                End3();
                break;
            //ED4 �M�����u���[
            case 4:
                /*
                Debug.Log("�ꐶ����ŐH���Ă���");
                SceneManager.LoadScene("EndScene");
                */
                End4();
                break;
            //ED5 �S������
            case 5:
                /*
                Debug.Log("�č������̂͂��܂�");
                SceneManager.LoadScene("EndScene");
                */
                End5();
                break;
            //ED6 ��D�_
            case 6:
                /*
                Debug.Log("�����ߘa�̑�D�_����");
                SceneManager.LoadScene("EndScene");
                */
                End6();
                break;
            //ED7 ���S
            case 7:
                /*
                Debug.Log("�̗͂��Ȃ��Ȃ�܂���");
                SceneManager.LoadScene("EndScene");
                */
                End7();
                break;
            //ED8 �a�ݗ������E
            case 8:
                /*
                Debug.Log("�����ɑς��؂ꂸ���E���܂���");
                SceneManager.LoadScene("EndScene");
                */
                End8();
                break;
            //ED9 �G���h���X�؋�
            case 9:
                /*
                Debug.Log("�Ԃ��Ă��Ԃ��Ă�������؋�");
                SceneManager.LoadScene("EndScene");
                */
                End9();
                break;
            //ED10 �l�Ԃ̃N�Y
            case 10:
                /*
                Debug.Log("���O�A�}�W�Ől�Ԃ̃N�Y����");
                SceneManager.LoadScene("EndScene");
                */
                End10();
                break;
            //ED11�@�l���I���g
            case 11:
                /*
                Debug.Log("�l�Ƃ��ďI����Ă��");
                SceneManager.LoadScene("EndScene");
                */
                End11();
                break;
            //�o�O
            default:
                Debug.Log("�o�O���Ă��܂�");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void End1()
    {
        //ED1 �؋��ԍ�
        Messege.text = ("�����Ɏ؋���Ԃ����Ƃ��ł����B" +
                     "\n �e�Ƃ̉��͂����؂ꂽ���A���ꂩ��͎��R�ɐ����Ă�����");

        Endnum.text = ("�G���f�B���O�i���o�[�P�@�؋��ԍ�");
    }
    void End2()
    {
        //ED2 �؋��ԍϏo������������J����ĊC�̑���
        Messege.text = ("�R�O���o���������͂P�O�O���~�����o�����ɂ���" + 
                     "\n �u���ނȂ玩���̐e�����݂ȁv" + 
                     "\n ���̌��t���Ō�ɕ��������t������" +
                     "\n �������āA���͑�����o���o���ɂ���" + 
                     "\n �c�����̂̓h�����ʂƋ��ɊC�Ɋ҂���");

        Endnum.text = ("�G���f�B���O�i���o�[�Q�@�o���o��");
    }
    void End3()
    {
        //ED3 �M�����u���[�A�����J����
        Messege.text = ("�u���O�A�M�����u�����D���Ȃ񂾂ȁv" +
                        "\n �������āA���͂��̐��̏I���̂悤��" +
                        "\n �J���{�݂ɘA��Ă���ꂽ" + 
                        "\n �u���O�͎��ʂ܂ł����œ�����,,,�v");
        Endnum.text = ("�G���f�B���O�i���o�[�R�@�n���J��");
    }
    void End4()
    {
        //ED4 �M�����u���[
        Messege.text = ("���̓M�����u���Ő���オ����" + 
                        "\n �؋��͕Ԃ������A�������̐����ɂ͖߂�Ȃ�");
        Endnum.text = ("�G���f�B���O�i���o�[�S�@���ꂪ���̃v���M�����u���[");
    }
    void End5()
    {
        //ED5 �S������
        Messege.text = ("���͍߂��o���āA�߂܂��Ă��܂���" + 
                        "\n �������A�悩������������Ȃ��B" +
                        "\n �؋���Ԃ��Ȃ��čςނ̂�����...");
        Endnum.text = ("�G���f�B���O�i���o�[�T�@�S������");
    }
    void End6()
    {
        //ED6 ��D�_
        Messege.text = ("���͂������҂����߁A���ނ��Ƃ𑱂���" +
                        "\n ����ŉ��ɂ͈ٖ�������" + 
                        "\n �ߘa�̑�D�_�u�R�W�L�v��...");
        Endnum.text = ("�G���f�B���O�i���o�[�U�@���ꂪ�ߘa�̑�D�_");
    }
    void End7()
    {
        //ED7 ���S
        Messege.text = ("���N����ƁA�̂��������Ƃ𕷂��Ȃ�����" +
                        "\n �����āA�������Ȃ��Ă����̂ŁA���̂܂ܐQ���B" +
                        "\n ''�i��''�ƋN���邱�Ƃ͂Ȃ�����...");
        Endnum.text = ("�G���f�B���O�i���o�[�V�@���S");
    }
    void End8()
    {
        //ED8 �a�ݗ������E
        Messege.text = ("�ӂƁA�S�Ă����ɂȂ����B" +
                        "\n �̂�����ɓ����Ă���ꏊ�Ɍ��������B" + 
                        "\n �����͎��E�̖����������B" +
                        "\n �u�����ǂ��Ȃ��Ă�������v" +
                        "\n �������āA�̂𓊂��o�����B" +
                        "\n �݂����ƂƂ��Ɉӎ���������...");
        Endnum.text = ("�G���f�B���O�i���o�[�W�@�����Ȃ�Ăǂ��ł�������");
    }
    void End9()
    {
        //ED9 �G���h���X�؋�
        Messege.text = ("����H���̊Ԃɂ��؋��������Ă�..." +
                        "\n " +
                        "\n ���̓�" + 
                        "����H�܂������Ă�..." +
                        "�������āA���͉i���Ǝ؋��������Ă����̂ł�����");
        Endnum.text = ("�G���f�B���O�i���o�[�X�@�G���h���X�؋�");
    }
    void End10()
    {
        //ED10 �l�Ԃ̃N�Y
        Messege.text = ("�؋����Ԃ����A�M�����u����ƍ߂܂ŔƂ���..." +
                        "\n �ǂ�����΂�����..." +
                        "\n �����A�������邵��..." + 
                        "\n �؋���肪�������A��l�Ɏ�����s��" +
                        "\n �_�炩�����Ȋ��G�A�`����Ă��鐶�����t��" +
                        "\n ���͑S�͂ł��̏ꂩ��������...");
        Endnum.text = ("�G���f�B���O�i���o�[�P�O�@�����āA�����āA�܂�������");
    }
    void End11()
    {
        //ED11�@�l���I���g
        Messege.text = ("�؋��͕Ԃ����B" +
                        "\n �������A��肷����" +
                        "\n �E�l�ɋ����A���\�A�M�����u��..." +
                        "\n ���ꂩ��ǂ����悤..." +
                        "\n �������āA�����ړI������킯�ł��Ȃ�����������...");
        Endnum.text = ("�G���f�B���O�i���o�[�P�P�@�r�����Ȃ��A�H");
    }
}
