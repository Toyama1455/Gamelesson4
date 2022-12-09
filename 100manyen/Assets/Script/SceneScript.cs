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
    
    public int physical;//�̗�
    public int mind;//���_��
    public int addiction;//���Œl
    public int ethic;//�ϗ��l
    public int money;//����


    //���U���g��ʂŃG���f�B���O�������ł��邩�ǂ������s��
    void Start()
    {
        if (PlayerState.day > 30)
        {
            //�P�O�O���~�ȏ�����Ă���
            if (PlayerState.Money > 1000000)
            {
                //�G���f�B���O�P�P�̔���
                if (PlayerState.Addiction >= 75)
                {
                    if (PlayerState.Ethic <= 25)
                    {
                        PlayerState.EndingNum = 11;
                        return;
                    }
                }

                //�G���f�B���O�S�̔���
                if (PlayerState.Addiction >= 75)
                {
                    PlayerState.EndingNum = 4;
                    return;
                }

                //�G���f�B���O�U�̔���
                if (PlayerState.Ethic <= 25)
                {
                    PlayerState.EndingNum = 6;
                    return;
                }

                //�G���f�B���O�P
                PlayerState.EndingNum = 1;

            }
            //�P�O�O���~�����Ă��Ȃ�
            else
            {
                //�G���f�B���O�P�O�̔���
                if (PlayerState.Addiction > 75)
                {
                    if (PlayerState.Ethic <= 25)
                    {
                        PlayerState.EndingNum = 10;
                        return;
                    }
                }
                //�G���f�B���O�R�̔���
                if (PlayerState.Addiction >= 75)
                {
                    PlayerState.EndingNum = 3;
                    return;
                }
                //�G���f�B���O�Q
                PlayerState.EndingNum = 2;
                return;
            }   
        }
        //�̗͂��O�ɂȂ�����
        if (PlayerState.Physical < 0)
        {
            PlayerState.EndingNum = 7;
        }

        //���_�͂��O�ɂȂ�����
        if (PlayerState.Mind < 0)
        {
            PlayerState.EndingNum = 8;
        }

        //�������O�ɂȂ�����
        if (PlayerState.Money < 0)
        {
            PlayerState.EndingNum = 9;
        }
        
    }

    // Update is called once per frame
    void Update()
    {






        
    }

    public void StateInit()//�����l�̐ݒ�
    {
        PlayerState.Physical = physical;
        PlayerState.Mind = mind;
        PlayerState.Addiction = addiction;
        PlayerState.Ethic = ethic;
        PlayerState.Money = money;

    }

    //�^�C�g����ʂ��烁�C����ʂ�
    public void OnClickStart()
    {
        StateInit();
        SceneManager.LoadScene("MainScene");
        
    }

    //�^�C�g����ʂ���f�X�N�g�b�v��
    public void OnClickEnd()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }


    //���U���g��ʂ��烁�C���V�[���ɖ߂鏈��
    public void OnClickNext()
    {
        Debug.Log("�G���f�B���O�i���o�[��"+PlayerState.EndingNum);

        if (PlayerState.EndingNum�@> 0 )
        {
            switch (PlayerState.EndingNum)
            {
                //ED1 �؋��ԍ�
                case 1:
                    Debug.Log("���ꂩ��̕����ȓ��X");
                    SceneManager.LoadScene("EndScene");
                    break;
                //ED2 �؋��ԍϏo������������J����ĊC�̑���
                case 2:
                    Debug.Log("�C�̑���");
                    SceneManager.LoadScene("EndScene");
                    break;
                //ED3 �M�����u���[�A�����J����
                case 3:
                    Debug.Log("�M�����u�������̍��҂͋����J�����႟��������");
                    SceneManager.LoadScene("EndScene");
                    break;
                //ED4 �M�����u���[
                case 4:
                    Debug.Log("�ꐶ����ŐH���Ă���");
                    SceneManager.LoadScene("EndScene");
                    break;
                //ED5 �S������
                case 5:
                    Debug.Log("�č������̂͂��܂�");
                    SceneManager.LoadScene("EndScene");
                    break;
                //ED6 ��D�_
                case 6:
                    Debug.Log("�����ߘa�̑�D�_����");
                    SceneManager.LoadScene("EndScene");
                    break;
                //ED7 ���S
                case 7:
                    Debug.Log("�̗͂��Ȃ��Ȃ�܂���");
                    SceneManager.LoadScene("EndScene");
                    break;
                //ED8 �a�ݗ������E
                case 8:
                    Debug.Log("�����ɑς��؂ꂸ���E���܂���");
                    SceneManager.LoadScene("EndScene");
                    break;
                //ED9 �G���h���X�؋�
                case 9:
                    Debug.Log("�Ԃ��Ă��Ԃ��Ă�������؋�");
                    SceneManager.LoadScene("EndScene");
                    break;
                //ED10 �l�Ԃ̃N�Y
                case 10:
                    Debug.Log("���O�A�}�W�Ől�Ԃ̃N�Y����");
                    SceneManager.LoadScene("EndScene");
                    break;
                //ED11�@�l���I���g
                case 11:
                    Debug.Log("�l�Ƃ��ďI����Ă��");
                    SceneManager.LoadScene("EndScene");
                    break;
                //�o�O
                default:
                    Debug.Log("�o�O���Ă��܂�");
                    break;

            }
        }
        else
        {
            SceneManager.LoadScene("MainScene");
        }
    }

    public void OnClickEnding()
    {
        PlayerState.EndingNum = 0;
        PlayerState.Physical = physical;
        PlayerState.Mind = mind;
        PlayerState.Addiction = addiction;
        PlayerState.Ethic = ethic;
        PlayerState.Money = money;
        PlayerState.day = 0;
        PlayerState.time = 0;
        SceneManager.LoadScene("StartScene");
    }
    
    //���C����ʂ���e�I������
    public void OnClickWork() //�̗͂Ɛ��_�͂�����Ă����𑝂₷
    {
        //�w�i�̌Ăяo��
        Action = ActionBackgroundState.Work;
        //�X�e�[�^�X�ύX

        //PlayerState.Physical -= 10; //�̗͂̕ύX

        PlayerState.addPhysical(-10);

        //PlayerState.Mind -= 10; //���_�͂̕ύX

        PlayerState.addMind(-10);

        int rnd = Random.Range(1,51);

        

        PlayerState.WorkMoney = rnd * 1000;

        PlayerState.Money += PlayerState.WorkMoney;

        
        Debug.Log(PlayerState.WorkMoney + "�҂��܂���");

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickEat()�@//�������g���āA�̗͂Ɛ��_�͂��񕜂���
    {
        Action = ActionBackgroundState.Eat;

        PlayerState.Luck = Random.Range(1, 4);

        switch (PlayerState.Luck)
        {
            case 1:
                //PlayerState.Physical += 50; //�̗͂̕ύX
                //PlayerState.Mind += 50; //���_�͂̕ύX

                PlayerState.addPhysical(30);
                PlayerState.addMind(30);

                PlayerState.Money -= 15000;//�����̕ύX
                Debug.Log("�����ȐH�������܂����B");
                break;

            case 2:

                //PlayerState.Physical += 30; //�̗͂̕ύX
                //PlayerState.Mind += 20; //���_�͂̕ύX

                PlayerState.addPhysical(20);
                PlayerState.addMind(15);

                PlayerState.Money -= 3000;//�����̕ύX
                Debug.Log("���ʂ̐H�������܂����B");
                break;
            case 3:

                //PlayerState.Physical += 15; //�̗͂̕ύX
                //PlayerState.Mind += 10; //���_�͂̕ύX

                PlayerState.addPhysical(10);
                PlayerState.addMind(5);

                PlayerState.Money -= 1000;//�����̕ύX
                Debug.Log("�ߖ�I�ȐH�������܂����B");
                break;                
            default:
                Debug.Log("�o�O���Ă��܂��B���}�ɒ����Ă�������");
                break;
        }
        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickSleep() //�������g�킸�A�̗͂Ɛ��_�͂��񕜂���
    {
        Action = ActionBackgroundState.Sleep;

        PlayerState.Luck = Random.Range(1, 4);

        switch (PlayerState.Luck)
        {
            case 1:

                //PlayerState.Physical += 20; //�̗͂̕ύX
                //PlayerState.Mind += 30; //���_�͂̕ύX

                PlayerState.addPhysical(20);
                PlayerState.addMind(30);

                Debug.Log("�n���ł��܂����B");
                break;
            case 2:

                //PlayerState.Physical += 10; //�̗͂̕ύX
                //PlayerState.Mind += 15; //���_�͂̕ύX                

                PlayerState.addPhysical(10);
                PlayerState.addMind(15);

                Debug.Log("���ʂɖ���܂���");
                break;
            case 3:

                PlayerState.Physical += 5; //�̗͂̕ύX
                PlayerState.Mind += 10; //���_�͂̕ύX

                PlayerState.addPhysical(5);
                PlayerState.addMind(10);

                Debug.Log("���܂薰��܂���ł���");
                break;
            default:
                Debug.Log("�o�O���Ă��܂��B���}�ɒ����Ă�������");
                break;
        }

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickPark() //�̗͂��g���Đ��_�͂��񕜂���
    {
        Action = ActionBackgroundState.Park;

        PlayerState.Luck = Random.Range(1, 4);

        switch (PlayerState.Luck)
        {
            case 1:

                //PlayerState.Physical -= 15; //�̗͂̕ύX
                //PlayerState.Mind += 30; //���_�͂̕ύX

                PlayerState.addPhysical(-15);
                PlayerState.addMind(30);

                Debug.Log("�������Y��Ȍ����ɂ����܂���");
                break;
            case 2:

                //PlayerState.Physical -= 10; //�̗͂̕ύX
                //PlayerState.Mind += 20; //���_�͂̕ύX                

                PlayerState.addPhysical(-10);
                PlayerState.addMind(20);

                Debug.Log("�ߏ���Y��Ȍ����ɂ����܂���");
                break;
            case 3:

                PlayerState.Physical -= 5; //�̗͂̕ύX
                PlayerState.Mind += 10; //���_�͂̕ύX

                PlayerState.addPhysical(-5);
                PlayerState.addMind(10);

                Debug.Log("���̂ւ���U�����܂���");
                break;
            default:
                Debug.Log("�o�O���Ă��܂��B���}�ɒ����Ă�������");
                break;
        }
        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickAquarium()//�������g���Đ��_�͂��񕜂���
    {
        Action = ActionBackgroundState.Aquarium;

        PlayerState.Luck = Random.Range(1, 4);

        switch (PlayerState.Luck)
        {
            case 1:

                PlayerState.Money -= 15000; //���������猸�炷
                PlayerState.Mind += 50; //���_�͂̕ύX

                PlayerState.addMind(50);

                Debug.Log("�����̒��L�������قɍs���܂���");
                break;
            case 2:

                PlayerState.Money -= 10000; //���������猸�炷
                PlayerState.Mind += 30; //���_�͂̕ύX

                PlayerState.addMind(30);

                Debug.Log("�ߏ�̗L�������قɍs���܂���");
                break;
            case 3:

                //PlayerState.Money -= 5000; //���������猸�炷
                //PlayerState.Mind += 15; //���_�͂̕ύX

                PlayerState.addMind(15);

                Debug.Log("�Ȃ�ƂȂ������قɍs���܂���");
                break;
            default:
                Debug.Log("�o�O���Ă��܂��B���}�ɒ����Ă�������");
                break;
        }
        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickShopping() //�������g���ėϗ��l���񕜂���
    {
        Action = ActionBackgroundState.Shopping;

        PlayerState.Luck = Random.Range(1, 4);

        switch (PlayerState.Luck)
        {
            case 1:
                PlayerState.Money -= 50000; //���������猸�炷
                PlayerState.Ethic += 50; //�ϗ��l�̕ύX
                Debug.Log("�����������܂���");
                break;
            case 2:
                PlayerState.Money -= 30000; //���������猸�炷
                PlayerState.Ethic += 30; //�ϗ��l�̕ύX
                Debug.Log("���������܂���");
                break;
            case 3:
                PlayerState.Money -= 10000; //���������猸�炷
                PlayerState.Ethic += 15; //�ϗ��l�̕ύX
                Debug.Log("�����������܂���");
                break;
            default:
                Debug.Log("�o�O���Ă��܂��B���}�ɒ����Ă�������");
                break;
        }
        
        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickPachinkoAndSlot()�@//�������g���āA���Œl�Ƃ����𑝂₷
    {
        Action = ActionBackgroundState.PachinkoAndSlot;

        PlayerState.Luck = Random.Range(1, 6);

        switch (PlayerState.Luck)
        {
            case 1://�叟

                PlayerState.Addiction += 10;
                PlayerState.Money += 80000;

                Debug.Log("�p�`���R�ő叟�����܂���");

                break;

            case 2://����
                PlayerState.Addiction += 5;
                PlayerState.Money += 40000;

                Debug.Log("�p�`���R�ŏ������܂���");

                break;

            case 3://�g���g��
                PlayerState.Addiction += 3;

                Debug.Log("�p�`���R�Ńg���g���ł���");

                break;
            case 4://����
                PlayerState.Addiction += 2;
                PlayerState.Money -= 40000;

                Debug.Log("�p�`���R�ŕ����܂���");

                break;
            case 5://�啉��
                PlayerState.Addiction += 1;
                PlayerState.Money -= 80000;

                Debug.Log("�p�`���R�ő啉���܂���");

                break;

                
        }

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickBortRace() //�������g���āA���Œl�Ƃ����𑝂₷
    {
        Action = ActionBackgroundState.Bortrace;

        PlayerState.Luck = Random.Range(1, 6);

        switch (PlayerState.Luck)
        {
            case 1://�叟

                PlayerState.Addiction += 10;
                PlayerState.Money += 100000;
                break;

            case 2://����
                PlayerState.Addiction += 5;
                PlayerState.Money += 30000;
                break;

            case 3://�g���g��
                PlayerState.Addiction += 3;
                break;
            case 4://����
                PlayerState.Addiction += 2;
                PlayerState.Money -= 50000;
                break;
            case 5://�啉��
                PlayerState.Addiction += 1;
                PlayerState.Money -= 100000;
                break;


        }

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickBicyleRace() //�������g���āA���Œl�Ƃ����𑝂₷
    {
        Action = ActionBackgroundState.Bicyclerace;

        PlayerState.Luck = Random.Range(1, 6);

        switch (PlayerState.Luck)
        {
            case 1://�叟

                PlayerState.Addiction += 10;
                PlayerState.Money += 100000;
                break;

            case 2://����
                PlayerState.Addiction += 5;
                PlayerState.Money += 50000;
                break;

            case 3://�g���g��
                PlayerState.Addiction += 3;
                break;
            case 4://����
                PlayerState.Addiction += 2;
                PlayerState.Money -= 80000;
                break;
            case 5://�啉��
                PlayerState.Addiction += 1;
                PlayerState.Money -= 150000;
                break;


        }
        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickHorseRase() //�������g���āA���Œl�Ƃ����𑝂₷
    {
        Action = ActionBackgroundState.Horserace;

        PlayerState.Luck = Random.Range(1, 6);

        switch (PlayerState.Luck)
        {
            case 1://�叟

                PlayerState.Addiction += 10;
                PlayerState.Money += 500000;
                break;

            case 2://�g���g��
                PlayerState.Addiction += 5;
                
                break;

            case 3://����
                PlayerState.Addiction += 3;
                PlayerState.Money -= 50000;
                break;
            case 4://�啉��
                PlayerState.Addiction += 2;
                PlayerState.Money -= 100000;
                break;
            case 5://������
                PlayerState.Addiction += 1;
                PlayerState.Money -= 200000;
                break;


        }


        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickLottery() //�������g���āA���Œl�Ƃ����𑝂₷
    {
        Action = ActionBackgroundState.Lottery;

        PlayerState.Luck = Random.Range(1, 6);

        switch (PlayerState.Luck)
        {
            case 1://����

                PlayerState.Addiction += 100;
                PlayerState.Money += 100000000;
                break;

            case 2://����
                PlayerState.Addiction += 5;
                PlayerState.Money -= 50000;
                break;

            case 3://����
                PlayerState.Addiction += 10;
                PlayerState.Money -= 100000;
                break;
            case 4://�啉��
                PlayerState.Addiction += 20;
                PlayerState.Money -= 500000;
                break;
            case 5://���啉��
                PlayerState.Addiction += 30;
                PlayerState.Money -= 1000000;
                break;
                
        }

        SceneManager.LoadScene("ResultScene");
    }



    public void OnClickPettycrime() //�ϗ��l�������āA�����Ɛ��_�͂Ƒ̗͂𑝂₷
    {
        Action = ActionBackgroundState.Pettycrime;

        PlayerState.Luck = Random.Range(1, 4);

        switch (PlayerState.Luck)
        {
            case 1://����

                PlayerState.Ethic -= 5;

                //PlayerState.Physical += 10;

                PlayerState.addPhysical(10);

                //PlayerState.Mind += 10;

                PlayerState.addMind(10);

                PlayerState.Money += 10000;

                break;

            case 2://����

                PlayerState.Ethic -= 3;

                SceneManager.LoadScene("ResultScene");

                break;

            case 3://���s

                PlayerState.EndingNum = 5;

                SceneManager.LoadScene("ResultScene");

                break;


        }

    }

    public void OnClickMidiumcrime()//�ϗ��l�������āA�������Ɛ��_�͂𑝂₷
    {
        Action = ActionBackgroundState.Midiumcrime;

        PlayerState.Luck = Random.Range(1, 6);

        switch (PlayerState.Luck)
        {
            case 1://����

                PlayerState.Ethic -= 30;

                PlayerState.Money += 100000;

                SceneManager.LoadScene("ResultScene");

                break;

            case 2://����

                PlayerState.Ethic -= 20;
                SceneManager.LoadScene("ResultScene");
                break;

            case 3://����


                PlayerState.Ethic -= 15;
                SceneManager.LoadScene("ResultScene");
                break;

            case 4://���s

                PlayerState.EndingNum = 5;

                SceneManager.LoadScene("ResultScene");

                break;

            case 5://���s

                PlayerState.EndingNum = 5;

                SceneManager.LoadScene("ResultScene");

                break;


        }

        
    }

    public void OnClickHeveycrime()//�ϗ��l�������āA�����𑝂₷
    {
        Action = ActionBackgroundState.Heveycrime;//�ϗ��l��傫�������āA������傫������

        PlayerState.Luck = Random.Range(1, 6);

        switch (PlayerState.Luck)
        {
            case 1://����

                PlayerState.Ethic -= 100;

                PlayerState.Money += 1000000;

                Debug.Log("�������܂���");

                SceneManager.LoadScene("ResultScene");

                break;

            case 2://����

                PlayerState.Ethic -= 50;

                Debug.Log("�����ɏI���܂���");
                SceneManager.LoadScene("ResultScene");

                break;

            case 3://���s

                PlayerState.EndingNum = 5;

                Debug.Log("���s���܂���");

                SceneManager.LoadScene("ResultScene");

                break;

            case 4://���s

                PlayerState.EndingNum = 5;

                Debug.Log("���s���܂����Q");
                Debug.Log(PlayerState.EndingNum);

                SceneManager.LoadScene("ResultScene");

                break;

            case 5://���s

                PlayerState.EndingNum = 5;

                Debug.Log("���s���܂����R");
                Debug.Log(PlayerState.EndingNum);

                SceneManager.LoadScene("ResultScene");

                break;
                
        }

    }


}
