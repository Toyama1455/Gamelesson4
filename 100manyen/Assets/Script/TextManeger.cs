using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManeger : MonoBehaviour
{
    public Text DayTime = null;//���t�e�L�X�g�I�u�W�F�N�g
    public Text Physical = null;//�̗̓e�L�X�g�I�u�W�F�N�g
    public Text Mind = null;//���_�̓e�L�X�g�I�u�W�F�N�g
    public Text Addiction = null;//���Œl�e�L�X�g�I�u�W�F�N�g
    public Text Ethic = null;//�ϗ��l�e�L�X�g�I�u�W�F�N�g
    public Text Money = null;//�����e�L�X�g�I�u�W�F�N�g

   




    // Start is called before the first frame update
    void Start()
    {
        //���t���X�V����
        DaytimeUpdete();


    }

    // Update is called once per frame
    void Update()
    {

        //�̗͂��X�V����
        PhysicalUpdate();
        //���_�͂��X�V����
        MindUpdate();
        //���Œl���X�V����
        AddictionUpdate();
        //�ϗ��l���X�V����
        EthicUpdate();
        //�������X�V����
        MoneyUpdate();
    }

    //���t��ύX����
    void DaytimeUpdete()
    {
        switch (PlayerState.time)
        {
            case 0:
                DayTime.text = (PlayerState.day + "��" + "�@�X��");
                break;

            case 1:
                DayTime.text = (PlayerState.day + "��" + "�@�P�V��");
                break;

            case 2:
                DayTime.text = (PlayerState.day + "��" + "�@�Q�T��");
                break;
                
            default:

                Debug.Log("�o�O���Ă܂�");

                break;
        }
        
    }

    //�̗͍X�V���s���܂�
    void PhysicalUpdate()
    {
        Physical.text = PlayerState.Physical.ToString();
    }
    //���_�͍X�V���s���܂�
    void MindUpdate()
    {
        Mind.text = PlayerState.Mind.ToString();
    }
    //���Œl�X�V���s���܂�
    void AddictionUpdate()
    {
        Addiction.text = PlayerState.Addiction.ToString();
    }
    //�ϗ��l�X�V���s���܂�
    void EthicUpdate()
    {
        Ethic.text = PlayerState.Ethic.ToString();
    }
    //�������X�V���s���܂�
    void MoneyUpdate()
    {
        Money.text = ("�������@" + PlayerState.Money.ToString() + "�~");
    }






}
