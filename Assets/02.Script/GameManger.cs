using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ŭ����  < ����� ���� 
  //       < Control Ŭ����
  //       < �ڷ��� Ŭ���� 
  // 1. �������� 2. �¾ ��ġ�� 3. �ð����� 5. ��� ��������
public class GameManger : MonoBehaviour
{
    public GameObject monster;
    public GameObject Monster2;
    public GameObject Skeleton;
   
    public Transform[] SpanePoints;
    private float timer = 3.0f;
    private float timer2;
    private float timer3;
    private int MaxCount = 10;
    private int MaxCount2 = 10; 
  
    void Start()
    {
        // ���̶�Ű���� sqawn points ��� ������Ʈ ���� ã�´�.
        SpanePoints = GameObject.Find("Spean").GetComponentsInChildren<Transform>();
        timer = Time.time;
      

    }

    
    void Update()
    {
        if (Time.time - timer >= timer)
        {
            // ���̶�Ű����  ZOMBIE �±׸� ���� ������Ʈ���� ������ ī��Ʈ�ؼ� �ѱ�
            ZombieSpwean();
            

        }
        if (Time.time - timer2 > 8.0f)
        {
            timer2 = Time.time;
            int MonserCount = GameObject.FindGameObjectsWithTag("Monster").Length;

            if (MonserCount < MaxCount2)
            {

                int randPos = Random.Range(1, SpanePoints.Length);
                Instantiate(Monster2, SpanePoints[randPos].position, SpanePoints[randPos].rotation);
                timer = Time.time;
            }
        }
        if(Time.time - timer3 > 5.0f)
        {
            timer3 = Time.time;
            int SkeletonCount = GameObject.FindGameObjectsWithTag("Skeleton").Length;

            if (SkeletonCount < MaxCount)
            {

                int randPos = Random.Range(1, SpanePoints.Length);
                Instantiate(Skeleton, SpanePoints[randPos].position, SpanePoints[randPos].rotation);
                timer = Time.time;
            }
        }

    }

    private void ZombieSpwean()
    {
        int ZombieCount = GameObject.FindGameObjectsWithTag("Zombie").Length;

        if (ZombieCount < MaxCount)
        {

            int randPos = Random.Range(1, SpanePoints.Length);
            Instantiate(monster, SpanePoints[randPos].position, SpanePoints[randPos].rotation);
            timer = Time.time;
        }
    }
}

