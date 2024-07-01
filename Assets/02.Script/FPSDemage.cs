using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FPSDemage : MonoBehaviour
{

    public Image HpBar;
    public Text HpTxt;
    public int Hp = 0;
    public int MaxHp = 100;
    public string attackTag = "Attack";
    public string zombieattacktag = "Zattack";
    public string Mosterattacktag = "Mattack";

    void Start()
    {
        Hp = MaxHp;
        HpBar.color = Color.yellow;
        Hpinpo();
    }

    private void Hpinpo()
    {
        HpTxt.text = $"HP: <color=#ff0000>{Hp.ToString()}</color>";
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(attackTag))
        {
            Deamge();
        }
        if(other.gameObject .CompareTag(zombieattacktag))
        {
            Deamge();
        }
        if (other.gameObject.CompareTag(Mosterattacktag))
        {
            Deamge();
        }
    }

    void Deamge()
    {
        Hp -= 15;
        HpBar.fillAmount = (float)Hp / (float)MaxHp;
        HpTxt.text = $"<color=#83FF96>hp:{Hp.ToString()}</color>";

    }

}
