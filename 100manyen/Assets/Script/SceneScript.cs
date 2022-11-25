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

    

    //���U���g��ʂŃG���f�B���O�������ł��邩�ǂ������s��
    void Start()
    {
        if (MainBackgroundManeger.day > 30)
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

    //�^�C�g����ʂ��烁�C����ʂ�
    public void OnClickStart()
    {
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
        if (PlayerState.EndingNum�@> 0 )
        {
            switch (PlayerState.EndingNum)
            {
                //ED1 �؋��ԍ�
                case 1:
                    break;
                //ED2 �؋��ԍϏo������������J����ĊC�̑���
                case 2:
                    break;
                //ED3 �M�����u���[�A�����J����
                case 3:
                    break;
                //ED4 �M�����u���[
                case 4:
                    break;
                //ED5 �S������
                case 5:
                    break;
                //ED6 ��D�_
                case 6:
                    break;
                //ED7 ���S
                case 7:
                    break;
                //ED8 �a�ݗ������E
                case 8:
                    break;
                //ED9 �G���h���X�؋�
                case 9:
                    break;
                //ED10 �l�Ԃ̃N�Y
                case 10:
                    break;
                //ED11�@�l���I���g
                case 11:
                    break;
                //�o�O
                default:
                    Debug.Log("�o�O���Ă��܂�");

                    break;






            }




        }







        SceneManager.LoadScene("MainScene");
    }
    
    //���C����ʂ���e�I������
    public void OnClickWork() //�̗͂Ɛ��_�͂�����Ă����𑝂₷
    {
        //�w�i�̌Ăяo��
        Action = ActionBackgroundState.Work;
        //�X�e�[�^�X�ύX

        PlayerState.Physical += 1; //�̗͂̕ύX

        PlayerState.Mind += 1; //���_�͂̕ύX

        PlayerState.Money += 1;//�����̕ύX

        Debug.Log("�����܂���");

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickEat()�@//�������g���āA�̗͂Ɛ��_�͂��񕜂���
    {
        Action = ActionBackgroundState.Eat;

        PlayerState.Physical += 1; //�̗͂̕ύX

        PlayerState.Mind += 1; //���_�͂̕ύX

        PlayerState.Money += 1;//�����̕ύX

        Debug.Log("�H�ׂ܂���");

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickSleep() //�������g�킸�A�̗͂Ɛ��_�͂��񕜂���
    {
        Action = ActionBackgroundState.Sleep;

        PlayerState.Physical += 1; //�̗͂̕ύX

        PlayerState.Mind += 1; //���_�͂̕ύX

        PlayerState.Money += 1;//�����̕ύX

        Debug.Log("�Q�܂���");

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickPark() //�̗͂��g���Đ��_�͂��񕜂���
    {
        Action = ActionBackgroundState.Park;

        PlayerState.Physical -= 1;

        PlayerState.Mind += 1;

        Debug.Log("�����ɍs���܂���");

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickAquarium()//�������g���Đ��_�͂��񕜂���
    {
        Action = ActionBackgroundState.Aquarium;

        PlayerState.Money -= 1;

        PlayerState.Money += 1;

        Debug.Log("�����قɍs���܂���");

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickShopping() //�������g���ėϗ��l���񕜂���
    {
        Action = ActionBackgroundState.Shopping;

        PlayerState.Money -= 1;

        PlayerState.Mind += 1;

        Debug.Log("�������ɍs���܂���");

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickPachinkoAndSlot()�@//�������g���āA���Œl�Ƃ����𑝂₷
    {
        Action = ActionBackgroundState.PachinkoAndSlot;



        int rnd = Random.Range(1, 6);

        switch (rnd)
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

        int rnd = Random.Range(1, 6);

        switch (rnd)
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

        int rnd = Random.Range(1, 6);

        switch (rnd)
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

        int rnd = Random.Range(1, 6);

        switch (rnd)
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

        int rnd = Random.Range(1, 6);

        switch (rnd)
        {
            case 1://����

                PlayerState.Addiction += 10;
                PlayerState.Money += 100000000;
                break;

            case 2://����
                PlayerState.Addiction += 5;
                PlayerState.Money -= 50000;
                break;

            case 3://����
                PlayerState.Addiction += 3;
                PlayerState.Money -= 100000;
                break;
            case 4://�啉��
                PlayerState.Addiction += 2;
                PlayerState.Money -= 500000;
                break;
            case 5://���啉��
                PlayerState.Addiction += 1;
                PlayerState.Money -= 1000000;
                break;
                
        }

        SceneManager.LoadScene("ResultScene");
    }



    public void OnClickPettycrime() //�ϗ��l�������āA�����Ɛ��_�͂Ƒ̗͂𑝂₷
    {
        Action = ActionBackgroundState.Pettycrime;

        int rnd = Random.Range(1, 4);

        switch (rnd)
        {
            case 1://����

                PlayerState.Ethic -= 5;

                PlayerState.Physical += 10;

                PlayerState.Mind += 10;

                PlayerState.Money += 10000;

                break;

            case 2://����

                PlayerState.Ethic -= 3;

                break;

            case 3://���s

                PlayerState.EndingNum = 5;

                break;


        }
    }

    public void OnClickMidiumcrime()//�ϗ��l�������āA�������Ɛ��_�͂𑝂₷
    {
        Action = ActionBackgroundState.Midiumcrime;

        int rnd = Random.Range(1, 6);

        switch (rnd)
        {
            case 1://����

                PlayerState.Ethic -= 10;

                PlayerState.Money += 100000;

                SceneManager.LoadScene("ResultScene");

                break;

            case 2://����

                PlayerState.Ethic -= 5;
                SceneManager.LoadScene("ResultScene");
                break;

            case 3://����


                PlayerState.Ethic -= 5;
                SceneManager.LoadScene("ResultScene");
                break;

            case 4://���s

                PlayerState.EndingNum = 5;

                break;

            case 5://���s

                PlayerState.EndingNum = 5;

                break;


        }

        
    }

    public void OnClickHeveycrime()//�ϗ��l�������āA�����𑝂₷
    {
        Action = ActionBackgroundState.Heveycrime;//�ϗ��l��傫�������āA������傫������

        int rnd = Random.Range(1, 6);

        switch (rnd)
        {
            case 1://����

                PlayerState.Ethic -= 30;

                PlayerState.Money += 1000000;

                Debug.Log("�������܂���");

                SceneManager.LoadScene("ResultScene");

                break;

            case 2://����

                PlayerState.Ethic -= 10;

                Debug.Log("�����ɏI���܂���");
                SceneManager.LoadScene("ResultScene");

                break;

            case 3://���s

                PlayerState.EndingNum = 5;

                Debug.Log("���s���܂���");

                break;

            case 4://���s

                PlayerState.EndingNum = 5;

                Debug.Log("���s���܂����Q");

                break;

            case 5://���s

                PlayerState.EndingNum = 5;

                Debug.Log("���s���܂����R");

                break;
                
        }

    }


}
