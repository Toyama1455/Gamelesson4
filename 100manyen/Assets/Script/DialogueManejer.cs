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

            case int i when i <= 30000:
                Messege.text = ("������ƃT�{����" + PlayerState.WorkMoney + "�~�����҂��܂���ł����B" +
                    "\n ���܂����B�@�̗́[�P�O ���_�́[�P�O���܂����B");
                break;

            case int i when i <= 40000:
                Messege.text = ("�^�ʖڂɓ�����" + PlayerState.WorkMoney + "�~���҂��܂���" +
                    "\n ���܂����B�@�̗́[�P�O ���_�́[�P�O���܂����B");
                break;

            case int i when i <= 50000:
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
                    "\n �ƂĂ��������������ł��B�@�̗́{�T�O�@���_�́{�T�O�@���@�[�P�T�O�O�O�~");

                break;

            case 2:
                /*
                PlayerState.Physical += 30; //�̗͂̕ύX
                PlayerState.Mind += 20; //���_�͂̕ύX
                PlayerState.Money -= 3000;//�����̕ύX
                Debug.Log("���ʂ̐H�������܂����B");
                */                
                Messege.text = ("�����͕��ʂɐH�������܂���" +
                    "\n �������������ł��B�@�̗́{�R�O�@���_�́{�Q�O�@���@�[�P�O�O�O�O�~");
                
                break;
            case 3:
                /*
                PlayerState.Physical += 15; //�̗͂̕ύX
                PlayerState.Mind += 10; //���_�͂̕ύX
                PlayerState.Money -= 1000;//�����̕ύX
                Debug.Log("�ߖ�I�ȐH�������܂����B");
                */
                Messege.text = ("�����͕��ʂɐH�������܂���" +
                    "\n �������������ł��B�@�̗́{�P�T�@���_�́{�P�O�@���@�[�P�O�O�O�~");
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
                    "\n �X�b�L�����܂����B�@�̗́{�P�T�@���_�́{�P�O�@��");

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
                    "\n �Y��Ŋ������܂����B�@���_�́{�T�O�@���@�[�P�T�O�O�O�~");

                break;
            case 2:
                /*
                PlayerState.Money -= 10000; //���������猸�炷
                PlayerState.Mind += 30; //���_�͂̕ύX
                Debug.Log("�ߏ�̗L�������قɍs���܂���");
                */
                Messege.text = ("�ߏ�̗L���Ȑ����قɍs���܂����B" +
                    "\n �Y��ł����B�@���_�́{�R�O�@���@�[�P�O�O�O�O�~");

                break;
            case 3:
                /*
                PlayerState.Money -= 5000; //���������猸�炷
                PlayerState.Mind += 15; //���_�͂̕ύX
                Debug.Log("�Ȃ�ƂȂ������قɍs���܂���");
                */
                Messege.text = ("�Ȃ�ƂȂ������قɍs���܂����B" +
                    "\n ���\�o���܂����B���_�́{�P�T�@���@�[�T�O�O�O�~");

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
                    "\n �������܂����B�ϗ��l�{�T�O�@���@�[�T�O�O�O�O�~");

                break;
            case 2:
                /*
                PlayerState.Money -= 30000; //���������猸�炷
                PlayerState.Ethic += 30; //�ϗ��l�̕ύX
                Debug.Log("���������܂���");
                */
                Messege.text = ("���َq�𔚔������܂���" +
                    "\n ���\�o���܂����B�ϗ��l�{�R�O�@���@�[�R�O�O�O�O�~");

                break;
            case 3:
                /*
                PlayerState.Money -= 10000; //���������猸�炷
                PlayerState.Ethic += 15; //�ϗ��l�̕ύX
                Debug.Log("�����������܂���");
                */
                Messege.text = ("�ʉَq�𔚔������܂���" +
                    "\n ���\�o���܂����B�ϗ��l�{�P�T�@���@�[�P�O�O�O�O�~");

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
                    "\n �ƂĂ��y���������ł��B���Œl�{�P�T�@���@�{�W�O�O�O�O�~");
                break;

            case 2://����
                /*
                PlayerState.Addiction += 5;
                PlayerState.Money += 40000;
                Debug.Log("�p�`���R�ŏ������܂���");
                */
                Messege.text = ("�K���_���t�b�ŏ����܂���" +
                    "\n ���\�o���܂����B���Œl�{�P�O�@���@�{�S�O�O�O�O�~");

                break;

            case 3://�g���g��
                /*
                PlayerState.Addiction += 3;
                Debug.Log("�p�`���R�Ńg���g���ł���");
                */
                break;
            case 4://����
                /*
                PlayerState.Addiction += 2;
                PlayerState.Money -= 40000;
                Debug.Log("�p�`���R�ŕ����܂���");
                */
                break;
            case 5://�啉��
                /*
                PlayerState.Addiction += 1;
                PlayerState.Money -= 80000;
                Debug.Log("�p�`���R�ő啉���܂���");
                */

                break;


        }
    }

    void BortraceMessege()
    {
        Messege.text = ("��������������������");
    }

    void BicycleraceMessege()
    {
        Messege.text = ("��������������������");
    }

    void HorseraceMessege()
    {
        Messege.text = ("��������������������");
    }

    void LotteryMessege()
    {
        Messege.text = ("��������������������");
    }

    void PettycrimeMessege()
    {
        Messege.text = ("��������������������");
    }

    void MediumcrimeMessege()
    {
        Messege.text = ("��������������������");
    }

    void HevycrimeMessege()
    {
        Messege.text = ("��������������������");
    }




}
