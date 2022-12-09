using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManejer : MonoBehaviour
{
    //���������ɃZ�b�g����
    public Text Messege;//���������̃e�L�X�g
    /*
    public Text Eat = null;//���������̃e�L�X�g
    public Text Sleep = null;//���������̃e�L�X�g
    public Text Park = null;//���������̃e�L�X�g
    public Text Aquarium = null;//���������̃e�L�X�g
    public Text Shopping = null;//���������̃e�L�X�g
    public Text PachinAndSlot = null;//���������̃e�L�X�g
    public Text Bortrace = null;//���������̃e�L�X�g
    public Text Bicyclerace = null;//���������̃e�L�X�g
    public Text Horserace = null;//���������̃e�L�X�g
    public Text Lottery = null;//���������̃e�L�X�g
    public Text Pettycrime = null;//���������̃e�L�X�g
    public Text Mediumcrime = null;//���������̃e�L�X�g
    public Text Hevycrime = null;//���������̃e�L�X�g
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
    
    //���[�N�̃Z���t�̏������s���܂�
    void WorkMessege()
    {
        switch (PlayerState.WorkMoney)
        {
            case int i when i <= 10000:
                Messege.text = ("������T�{����" + PlayerState.WorkMoney + "�~�����҂��܂���ł����B" + 
                    "\n ���܂����B�@�̗́[�P�O ���_�́[�P�O���܂����B");
                
                break;

            case int i when i <= 20000:
                Messege.text = ("������ƃT�{����" + PlayerState.WorkMoney + "�~�����҂��܂���ł����B" +
                    "\n ���܂����B�@�̗́[�P�O ���_�́[�P�O���܂����B");
                break;

            case int i when i <= 30000:
                Messege.text = ("�^�ʖڂɓ�����" + PlayerState.WorkMoney + "�~���҂��܂���" +
                    "\n ���܂����B�@�̗́[�P�O ���_�́[�P�O���܂����B");
                break;

            case int i when i <= 40000:
                Messege.text = ("���撣���ē�����" + PlayerState.WorkMoney + "�~�����҂��܂���" +
                    "\n ���܂����B�@�̗́[�P�O ���_�́[�P�O���܂����B");
                break;
                
            default:
                Messege.text = ("�o�O���x��" + PlayerState.WorkMoney + "�~�҂��܂����B");
                break;
        }
        
    }
    void EatMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1:
                /*
                PlayerState.Physical += 50; //�̗͂̕ύX
                PlayerState.Mind += 50; //���_�͂̕ύX
                PlayerState.Money -= 15000;//�����̕ύX
                Debug.Log("�����ȐH�������܂����B");
                */
                Messege.text = ("�����͕������č����ȐH�������܂���" + 
                    "\n �ƂĂ��������������ł��B�@�̗́{�T�O�@���_�́{�T�O�@���[�P�T�O�O�O�~");

                break;

            case 2:
                /*
                PlayerState.Physical += 30; //�̗͂̕ύX
                PlayerState.Mind += 20; //���_�͂̕ύX
                PlayerState.Money -= 3000;//�����̕ύX
                Debug.Log("���ʂ̐H�������܂����B");
                */                
                Messege.text = ("�����͕��ʂɐH�������܂���" +
                    "\n �������������ł��B�@�̗́{�R�O�@���_�́{�Q�O�@���[�P�O�O�O�O�~");
                
                break;
            case 3:
                /*
                PlayerState.Physical += 15; //�̗͂̕ύX
                PlayerState.Mind += 10; //���_�͂̕ύX
                PlayerState.Money -= 1000;//�����̕ύX
                Debug.Log("�ߖ�I�ȐH�������܂����B");
                */
                Messege.text = ("�����͕��ʂɐH�������܂���" +
                    "\n �������������ł��B�@�̗́{�P�T�@���_�́{�P�O�@���[�P�O�O�O�~");
                break;
            default:
                Debug.Log("�o�O���Ă��܂��B���}�ɒ����Ă�������");
                break;
        }

    }
    void SleepMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1:
                /*
                PlayerState.Physical += 20; //�̗͂̕ύX
                PlayerState.Mind += 30; //���_�͂̕ύX
                Debug.Log("�n���ł��܂����B");
                */

                Messege.text = ("�n���ł��܂���" +
                    "\n �ƂĂ��X�b�L�����ĉ����ł��B�@�̗́{�Q�O�@���_�́{�R�O");
                break;
            case 2:
                /*
                PlayerState.Physical += 10; //�̗͂̕ύX
                PlayerState.Mind += 15; //���_�͂̕ύX                
                Debug.Log("���ʂɖ���܂���");
                */
                Messege.text = ("���ʂɐQ�邱�Ƃ��ł��܂���" +
                    "\n �X�b�L�����܂����B�@�̗́{�P�T�@���_�́{�P�O");

                break;
            case 3:
                /*
                PlayerState.Physical += 5; //�̗͂̕ύX
                PlayerState.Mind += 10; //���_�͂̕ύX
                Debug.Log("���܂薰��܂���ł���");
                */
                Messege.text = ("���܂薰�邱�Ƃ��ł��܂���ł���" +
                    "\n ���͂�����ƂƂ�܂����B�@�̗́{�T�@���_�́{�T");

                break;
            default:
                Debug.Log("�o�O���Ă��܂��B���}�ɒ����Ă�������");
                break;
        }
    }

    void ParkMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1:
                /*
                PlayerState.Physical -= 15; //�̗͂̕ύX
                PlayerState.Mind += 30; //���_�͂̕ύX
                Debug.Log("�������Y��Ȍ����ɂ����܂���");
                */
                Messege.text = ("�������Y��Ȍ����ɍs���܂���" +
                    "\n �Y��ŐS������܂����B�@�̗́[�P�T�@���_�́{�R�O");

                break;
            case 2:
                /*
                PlayerState.Physical -= 10; //�̗͂̕ύX
                PlayerState.Mind += 20; //���_�͂̕ύX                
                Debug.Log("�ߏ���Y��Ȍ����ɂ����܂���");
                */
                Messege.text = ("�ߏ���Y��Ȍ����ɍs���܂���" +
                    "\n �����ł��܂����B�@�̗́[�P�O�@���_�́{�Q�O");
                
                break;
            case 3:
                /*
                PlayerState.Physical -= 5; //�̗͂̕ύX
                PlayerState.Mind += 10; //���_�͂̕ύX
                Debug.Log("���̂ւ���U�����܂���");
                */
                Messege.text = ("�������r���Ŗ������܂����B" +
                    "\n �U�������A�����B�@�̗́[�T�@���_�́{�P�O");

                break;
            default:
                Debug.Log("�o�O���Ă��܂��B���}�ɒ����Ă�������");
                break;
        }
    }

    void AquariumMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1:
                /*
                PlayerState.Money -= 15000; //���������猸�炷
                PlayerState.Mind += 50; //���_�͂̕ύX
                Debug.Log("�����̒��L�������قɍs���܂���");
                */
                Messege.text = ("�����̒��L�������قɍs���܂����B" +
                    "\n �Y��Ŋ������܂����B�@���_�́{�T�O�@���[�P�T�O�O�O�~");

                break;
            case 2:
                /*
                PlayerState.Money -= 10000; //���������猸�炷
                PlayerState.Mind += 30; //���_�͂̕ύX
                Debug.Log("�ߏ�̗L�������قɍs���܂���");
                */
                Messege.text = ("�ߏ�̗L���Ȑ����قɍs���܂����B" +
                    "\n �Y��ł����B�@���_�́{�R�O�@���[�P�O�O�O�O�~");

                break;
            case 3:
                /*
                PlayerState.Money -= 5000; //���������猸�炷
                PlayerState.Mind += 15; //���_�͂̕ύX
                Debug.Log("�Ȃ�ƂȂ������قɍs���܂���");
                */
                Messege.text = ("�Ȃ�ƂȂ������قɍs���܂����B" +
                    "\n ���\�o���܂����B���_�́{�P�T�@���[�T�O�O�O�~");

                break;
            default:
                Debug.Log("�o�O���Ă��܂��B���}�ɒ����Ă�������");
                break;
        }
    }

    void ShoppingMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1:
                /*
                PlayerState.Money -= 50000; //���������猸�炷
                PlayerState.Ethic += 50; //�ϗ��l�̕ύX
                Debug.Log("�����������܂���");
                */
                Messege.text = ("�������َq�𒴔����������܂����B" +
                    "\n �������܂����B�ϗ��l�{�T�O�@���[�T�O�O�O�O�~");

                break;
            case 2:
                /*
                PlayerState.Money -= 30000; //���������猸�炷
                PlayerState.Ethic += 30; //�ϗ��l�̕ύX
                Debug.Log("���������܂���");
                */
                Messege.text = ("���َq�𔚔������܂���" +
                    "\n ���\�o���܂����B�ϗ��l�{�R�O�@���[�R�O�O�O�O�~");

                break;
            case 3:
                /*
                PlayerState.Money -= 10000; //���������猸�炷
                PlayerState.Ethic += 15; //�ϗ��l�̕ύX
                Debug.Log("�����������܂���");
                */
                Messege.text = ("�ʉَq�𔚔������܂���" +
                    "\n ���\�o���܂����B�ϗ��l�{�P�T�@���[�P�O�O�O�O�~");

                break;
            default:
                Debug.Log("�o�O���Ă��܂��B���}�ɒ����Ă�������");
                break;
        }
    }

    void PachinAndSlotMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1://�叟
                /*
                PlayerState.Addiction += 10;
                PlayerState.Money += 80000;
                Debug.Log("�p�`���R�ő叟�����܂���");
                */
                Messege.text = ("�Ƃ���Ȋw�̒��d���C�̃p�`���R�ő叟�����܂���" +
                    "\n �ƂĂ��y���������ł��B���Œl�{�P�T�@���{�W�O�O�O�O�~");
                break;

            case 2://����
                /*
                PlayerState.Addiction += 5;
                PlayerState.Money += 40000;
                Debug.Log("�p�`���R�ŏ������܂���");
                */
                Messege.text = ("�K���_���t�b�ŏ����܂���" +
                    "\n ���\�o���܂����B���Œl�{�P�O�@���{�S�O�O�O�O�~");

                break;

            case 3://�g���g��
                /*
                PlayerState.Addiction += 3;
                Debug.Log("�p�`���R�Ńg���g���ł���");
                */
                Messege.text = ("���̑�߂Q�Ńg���g���ł���" +
                    "\n �܂��������܂��B���Œl�{�P�O");

                break;
            case 4://����
                   /*
                   PlayerState.Addiction += 2;
                   PlayerState.Money -= 40000;
                   Debug.Log("�p�`���R�ŕ����܂���");
                   */
                Messege.text = ("�S�����胊�[���ŕ����܂���" +
                    "\n �B�����������̂Ń��x���W���܂��B���Œl�{2�@���[�S�O�O�O�O�~");

                break;
            case 5://�啉��
                   /*
                   PlayerState.Addiction += 1;
                   PlayerState.Money -= 80000;
                   Debug.Log("�p�`���R�ő啉���܂���");
                   */
                Messege.text = ("��H�̌�����ő啉���܂����B" +
                    "\n ��x�Ƃ����܂���B���Œl�{�P�@���[�W�O�O�O�O�~");
                break;


        }
    }

    void BortraceMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1://�叟
                /*
                PlayerState.Addiction += 10;
                PlayerState.Money += 100000;
                */
                Messege.text = ("�匊�ɂ����Č���������܂���" +
                    "\n ���M���������ł����B���Œl�{�P�O�@���{�P�O�O�O�O�O�~");
                break;

            case 2://����
                /*
                    PlayerState.Addiction += 5;
                    PlayerState.Money += 30000;
                */
                Messege.text = ("�l�C�̂��̂ɂ����ď����܂���" +
                    "\n�@�y���������ł��B���Œl�{�T�@���{�R�O�O�O�O�~");

                break;

            case 3://�g���g��
                /*
                    PlayerState.Addiction += 3;
                */
                Messege.text = ("�l�C���ɂȂ�܂����B" +
                    "\n �܂����x���悤...�B���Œl�{�R");

                break;
            case 4://����
                   /*
                    PlayerState.Addiction += 2;
                    PlayerState.Money -= 50000;
                   */
                Messege.text = ("�l�C����������Ƃ���܂����B" +
                    "\n �@�܂����x�A�匊�ɂ����܂��B���Œl�{2�@���[�T�O�O�O�O�~");

                break;
            case 5://�啉��
                   /*
                   PlayerState.Addiction += 1;
                   PlayerState.Money -= 100000;
                   */
                Messege.text = ("�����ĂȂ��匊���ɂȂ�܂����B" +
                    "\n �����Ă������̑S�������ʂɂȂ�܂����B���Œl�{�P�@���[�P�O�O�O�O�O�~");
                break;


        }
    }

    void BicycleraceMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1://�叟
                /*
                 * 
                 * 
                 * 
                */
                Messege.text = ("�匊�ɂ����Č���������܂���" +
                    "\n ���M���������ł����B���Œl�{�P�O�@���{�P�O�O�O�O�O�~");
                break;

            case 2://����
                /*
                 *
                 * 
                */
                Messege.text = ("�l�C�̂��̂ɂ����ď����܂���" +
                    "\n�@�y���������ł��B���Œl�{�T�@���{�T�O�O�O�O�~");

                break;

            case 3://�g���g��
                /*
                   �@
                */
                Messege.text = ("�l�C���ɂȂ�܂����B" +
                    "\n �܂����x���悤...�B���Œl�{�R");

                break;
            case 4://����
                   /*
                    
                   */
                Messege.text = ("�l�C����������Ƃ���܂����B" +
                    "\n �@�܂����x�A�匊�ɂ����܂��B���Œl�{2�@���[�W�O�O�O�O�~");

                break;
            case 5://�啉��
                   /*
                   

                   */
                Messege.text = ("�����ĂȂ��匊���ɂȂ�܂����B" +
                    "\n �����Ă������̑S�������ʂɂȂ�܂����B���Œl�{�P�@���[�P�T�O�O�O�O�~");
                break;


        }
    }

    void HorseraceMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1://�叟
                /*
                PlayerState.Addiction += 10;
                PlayerState.Money += 500000;
                */
                Messege.text = ("�����Ă����匊������������܂����B" +
                    "\n �叟���܂����B���Œl�{�P�O�@���[�T�O�O�O�O�O�~");
                break;

            case 2://�g���g��
                /*
                PlayerState.Addiction += 5;
                */
                Messege.text = ("�l�C���ʂ�ɂȂ�܂���" +
                    "\n �����͂��������z�A���Ă��܂����B���Œl�{�T");
                break;

            case 3://����
                /*
                PlayerState.Addiction += 3;
                PlayerState.Money -= 50000;
                */
                Messege.text = ("�l�C����������Ƃ����܂����B" +
                    "\n ���������Ă����̂ő������܂����B���Œl�{�R�@���[�T�O�O�O�O�~");
                break;
            case 4://�啉��
                /*
                PlayerState.Addiction += 2;
                PlayerState.Money -= 100000;
                */

                Messege.text = ("���ʂ��r��đ匊�Ȍ��ʂƂȂ�܂����B" +
                    "\n �����Ă������̂����ʂɂȂ�܂����B���Œl�{�Q�@���[�P�O�O�O�O�O�~");
                break;
            case 5://������
                /*
                PlayerState.Addiction += 1;
                PlayerState.Money -= 200000;
                */

                Messege.text = ("���ʂ��r��ɍr��A�����ĂȂ��匊���ɂȂ�܂����B" +
                    "\n �����Ă������̑S�������ʂɂȂ�܂����B���Œl�{�P�@���[�Q�O�O�O�O�O�~");
                break;


        }

    }

    void LotteryMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1://����
                /*
                PlayerState.Addiction += 100;
                PlayerState.Money += 100000000;
                */
                Messege.text = ("�󂭂��P�����������I���܂���" +
                    "\n �l���V��ŕ�点��悤�ɂȂ�܂����B���Œl�{�P�O�O�@���{�P�O�O�O�O�O�O�O�O�~");
                break;

            case 2://����
                /*
                PlayerState.Addiction += 5;
                PlayerState.Money -= 50000;
                */
                Messege.text = ("�������I�������߁A�y���߂܂����B" +
                    "\n ������Ƒ������܂����B���Œl�{�T�@���[�T�O�O�O�O�~");
                break;

            case 3://����
                /*
                PlayerState.Addiction += 10;
                PlayerState.Money -= 100000;
                */
                Messege.text = ("���I�������Ȃ������ł��B" +
                    "\n ���\�A�������܂����B���Œl�{�P�O�@���[�P�O�O�O�O�O�~");
                break;
            case 4://�啉��
                /*
                PlayerState.Addiction += 20;
                PlayerState.Money -= 500000;
                */
                Messege.text = ("�󂭂��𔃂����݂����܂����B" +
                    "\n �߂��Ⴍ���ᕉ���܂����B���Œl�{�Q�O�@���[�T�O�O�O�O�O�~");
                break;
            case 5://���啉��
                /*
                PlayerState.Addiction += 30;
                PlayerState.Money -= 1000000;
                */
                Messege.text = ("�P�O�O���~����������������܂���ł����B" +
                    "\n �������G�G�B���Œl�{�R�O�@���[�P�O�O�O�O�O�O�~");

                break;

        }
    }

    void PettycrimeMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1://����
                /*
                PlayerState.Ethic -= 5;

                PlayerState.Physical += 10;

                PlayerState.Mind += 10;

                PlayerState.Money += 10000;
                */
                Messege.text = ("�������ɐ������܂����B" +
                    "\n �������������i�ł�����c��܂��A�]�����Ă�����ׂ��܂����B" +
                    "\n �ϗ��l�[�T�@�̗́{�P�O�@���_�́{�P�O�@���{�P�O�O�O�O�~");

                break;

            case 2://����
                /*
                PlayerState.Ethic -= 3;
                SceneManager.LoadScene("ResultScene");
                */
                Messege.text = ("�����������悤�v���܂�������߂܂����B" +
                    "\n �J�����̈ʒu���▭����������ł��B" +
                    "\n �ϗ��l�[�R");

                break;

            case 3://���s
                /*
                PlayerState.EndingNum = 5;

                SceneManager.LoadScene("ResultScene");
                */
                Messege.text = ("�������Ɏ��s���܂����B" +
                    "\n �ʂ肷����̌x�@�ɕ߂܂�܂����B");

                break;


        }
    }

    void MediumcrimeMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1://����
                   /*
                   PlayerState.Ethic -= 10;

                   PlayerState.Money += 100000;

                   SceneManager.LoadScene("ResultScene");
                   */
                Messege.text = ("���W�����ɐ������܂����B" +
                     "\n ������Ƃ�������𓾂��܂����B" +
                     "\n �ϗ��l�[�P�O�@���P�O�O�O�O�O�~");

                break;

            case 2://����
                /*
                PlayerState.Ethic -= 5;
                SceneManager.LoadScene("ResultScene");
                */
                Messege.text = ("���s���悤�Ƃ������Ɍx�@�����܂����B" +
                    "\n ����͌�����܂����B�@�ϗ��l�[�T");

                break;

            case 3://����
                /*
                PlayerState.Ethic -= 5;
                SceneManager.LoadScene("ResultScene");
                */
                Messege.text = ("�Ď��J���������傳��Ă���A���ʂ�ɍs���܂���ł����B" +
                    "\n ����͌�����܂����B�ϗ��l�[�T");

                break;

            case 4://���s
                   /*
                   PlayerState.EndingNum = 5;

                   SceneManager.LoadScene("ResultScene");
                   */
                Messege.text = ("�e�̈��S���b�N���O���Y��܂����B" +
                             "\n �߂܂�܂����B");
                break;

            case 5://���s
                /*
                PlayerState.EndingNum = 5;
                SceneManager.LoadScene("ResultScene");
                */
                Messege.text = ("�����r���Ƀp���N���܂����B" +
                    �@�@�@�@ "\n �߂܂�܂����B");
                break;
                
        }
    }

    void HevycrimeMessege()
    {
        switch (PlayerState.Luck)
        {
            case 1://����
                /*
                PlayerState.Ethic -= 30;

                PlayerState.Money += 1000000;

                Debug.Log("�������܂���");

                SceneManager.LoadScene("ResultScene");
                */
                Messege.text = ("�^�[�Q�b�g�̎n���ɐ������܂����B" +
                     "\n �_����𓾂��܂����B" +
                     "\n �ϗ��l�[�R�O�@���P�O�O�O�O�O�O�~");
                break;

            case 2://����
                /*
                PlayerState.Ethic -= 10;

                Debug.Log("�����ɏI���܂���");
                SceneManager.LoadScene("ResultScene");
                */
                Messege.text = ("�^�[�Q�b�g������܂���ł����B" +
                   �@�@�@�@  "\n ����͌�����܂����B�@�ϗ��l�[�P�O");

                break;

            case 3://���s
                /*
                PlayerState.EndingNum = 5;

                Debug.Log("���s���܂���");

                SceneManager.LoadScene("ResultScene");
                */
                Messege.text = ("�^�[�Q�b�g�ɕԂ蓢���ɂ���܂����B" +
                    �@�@�@�@ "\n �߂܂�܂����B");

                break;

            case 4://���s
                /*
                PlayerState.EndingNum = 5;

                Debug.Log("���s���܂����Q");
                Debug.Log(PlayerState.EndingNum);

                SceneManager.LoadScene("ResultScene");
                */
                Messege.text = ("�_���Ă���̂��o���Ă��܂����B" +
                             "\n �߂܂�܂���");


                break;

            case 5://���s
                /*
                PlayerState.EndingNum = 5;

                Debug.Log("���s���܂����R");
                Debug.Log(PlayerState.EndingNum);

                SceneManager.LoadScene("ResultScene");
                */
                Messege.text = ("�n���������Ɍx�@�Ɍ����Ă��܂����B" +
                   �@�@�@�@  "\n �߂܂�܂����B");

                break;

        }
    }




}
