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

    public PlayerState playerState;

    // Start is called before the first frame update
    void Start()
    {
       
        
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

    //���C����ʂ���e�I������
    public void OnClickWork() //�̗͂Ɛ��_�͂�����Ă����𑝂₷
    {
        //�w�i�̌Ăяo��
        Action = ActionBackgroundState.Work;
        //�X�e�[�^�X�ύX
            
        playerState.Physical += 1; //�̗͂̕ύX

        playerState.Mind += 1; //���_�͂̕ύX

        playerState.Money += 1;//�����̕ύX

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickEat()�@//�������g���āA�̗͂Ɛ��_�͂��񕜂���
    {
        Action = ActionBackgroundState.Eat;

        playerState.Physical += 1; //�̗͂̕ύX

        playerState.Mind += 1; //���_�͂̕ύX

        playerState.Money += 1;//�����̕ύX

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickSleep() //�������g�킸�A�̗͂Ɛ��_�͂��񕜂���
    {
        Action = ActionBackgroundState.Sleep;

        playerState.Physical += 1; //�̗͂̕ύX

        playerState.Mind += 1; //���_�͂̕ύX

        playerState.Money += 1;//�����̕ύX

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickPark() //�̗͂��g���Đ��_�͂��񕜂���
    {
        Action = ActionBackgroundState.Park;

        playerState.Physical -= 1;

        playerState.Mind += 1;
        
        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickAquarium()//�������g���Đ��_�͂��񕜂���
    {
        Action = ActionBackgroundState.Aquarium;

        playerState.Money -= 1;

        playerState.Money += 1;
        
        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickShopping() //�������g���ėϗ��l���񕜂���
    {
        Action = ActionBackgroundState.Shopping;

        playerState.Money -= 1;

        playerState.Mind += 1;
        
        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickPachinkoAndSlot()�@//�������g���āA���Œl�Ƃ����𑝂₷
    {
        Action = ActionBackgroundState.PachinkoAndSlot;



        int rnd = Random.RandomRange(1, 6);

        switch (rnd)
        {
            case 1://�叟

                playerState.Addiction += 10;
                playerState.Money += 80000;
                break;

            case 2://����
                playerState.Addiction += 5;
                playerState.Money += 40000;
                break;

            case 3://�g���g��
                playerState.Addiction += 3;
                break;
            case 4://����
                playerState.Addiction += 2;
                playerState.Money -= 40000;
                break;
            case 5://�啉��
                playerState.Addiction += 1;
                playerState.Money -= 80000;
                break;

                
        }

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickBortRace() //�������g���āA���Œl�Ƃ����𑝂₷
    {
        Action = ActionBackgroundState.Bortrace;

        int rnd = Random.RandomRange(1, 6);

        switch (rnd)
        {
            case 1://�叟

                playerState.Addiction += 10;
                playerState.Money += 100000;
                break;

            case 2://����
                playerState.Addiction += 5;
                playerState.Money += 30000;
                break;

            case 3://�g���g��
                playerState.Addiction += 3;
                break;
            case 4://����
                playerState.Addiction += 2;
                playerState.Money -= 50000;
                break;
            case 5://�啉��
                playerState.Addiction += 1;
                playerState.Money -= 100000;
                break;


        }

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickBicyleRace() //�������g���āA���Œl�Ƃ����𑝂₷
    {
        Action = ActionBackgroundState.Bicyclerace;

        int rnd = Random.RandomRange(1, 6);

        switch (rnd)
        {
            case 1://�叟

                playerState.Addiction += 10;
                playerState.Money += 100000;
                break;

            case 2://����
                playerState.Addiction += 5;
                playerState.Money += 50000;
                break;

            case 3://�g���g��
                playerState.Addiction += 3;
                break;
            case 4://����
                playerState.Addiction += 2;
                playerState.Money -= 80000;
                break;
            case 5://�啉��
                playerState.Addiction += 1;
                playerState.Money -= 150000;
                break;


        }
        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickHorseRase() //�������g���āA���Œl�Ƃ����𑝂₷
    {
        Action = ActionBackgroundState.Horserace;

        int rnd = Random.RandomRange(1, 6);

        switch (rnd)
        {
            case 1://�叟

                playerState.Addiction += 10;
                playerState.Money += 500000;
                break;

            case 2://�g���g��
                playerState.Addiction += 5;
                
                break;

            case 3://����
                playerState.Addiction += 3;
                playerState.Money -= 50000;
                break;
            case 4://�啉��
                playerState.Addiction += 2;
                playerState.Money -= 100000;
                break;
            case 5://������
                playerState.Addiction += 1;
                playerState.Money -= 200000;
                break;


        }


        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickLottery() //�������g���āA���Œl�Ƃ����𑝂₷
    {
        Action = ActionBackgroundState.Lottery;

        int rnd = Random.RandomRange(1, 6);

        switch (rnd)
        {
            case 1://����

                playerState.Addiction += 10;
                playerState.Money += 100000000;
                break;

            case 2://����
                playerState.Addiction += 5;
                playerState.Money -= 50000;
                break;

            case 3://����
                playerState.Addiction += 3;
                playerState.Money -= 100000;
                break;
            case 4://�啉��
                playerState.Addiction += 2;
                playerState.Money -= 500000;
                break;
            case 5://���啉��
                playerState.Addiction += 1;
                playerState.Money -= 1000000;
                break;
                
        }

        SceneManager.LoadScene("ResultScene");
    }



    public void OnClickPettycrime() //�ϗ��l�������āA�����Ɛ��_�͂Ƒ̗͂𑝂₷
    {
        Action = ActionBackgroundState.Pettycrime;

        int rnd = Random.RandomRange(1, 4);

        switch (rnd)
        {
            case 1://����

                playerState.Ethic -= 5;

                playerState.Physical += 10;

                playerState.Mind += 10;

                playerState.Money += 10000;

                break;

            case 2://����

                playerState.Ethic -= 3;

                break;

            case 3://���s

                SceneManager.LoadScene("EndScene");

                break;


        }

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickMidiumcrime()//�ϗ��l�������āA�������Ɛ��_�͂𑝂₷
    {
        Action = ActionBackgroundState.Midiumcrime;

        int rnd = Random.RandomRange(1, 6);

        switch (rnd)
        {
            case 1://����

                playerState.Ethic -= 10;
                
                playerState.Money += 100000;

                break;

            case 2://����

                playerState.Ethic -= 5;

                break;

            case 3://����

                playerState.Ethic -= 5;

                break;

            case 4://���s

                SceneManager.LoadScene("EndScene");

                break;

            case 5://���s

                SceneManager.LoadScene("EndScene");

                break;


        }

        SceneManager.LoadScene("ResultScene");
    }

    public void OnClickHeveycrime()//�ϗ��l�������āA�����𑝂₷
    {
        Action = ActionBackgroundState.Heveycrime;//�ϗ��l��傫�������āA������傫������

        int rnd = Random.RandomRange(1, 6);

        switch (rnd)
        {
            case 1://����

                playerState.Ethic -= 30;

                playerState.Money += 1000000;

                break;

            case 2://����

                playerState.Ethic -= 10;

                break;

            case 3://���s

                SceneManager.LoadScene("EndScene");

                break;

            case 4://���s

                SceneManager.LoadScene("EndScene");

                break;

            case 5://���s

                SceneManager.LoadScene("EndScene");

                break;


        }


        SceneManager.LoadScene("ResultScene");
    }


}
