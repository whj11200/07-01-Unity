using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//클래스  < 기능적 성격 
  //       < Control 클래스
  //       < 자료적 클래스 
  // 1. 적프리팹 2. 태어날 위치들 3. 시간간격 5. 몇마리 생성할지
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
        // 하이라키에서 sqawn points 라는 오브젝트 명을 찾는다.
        SpanePoints = GameObject.Find("Spean").GetComponentsInChildren<Transform>();
        timer = Time.time;
      

    }

    
    void Update()
    {
        if (Time.time - timer >= timer)
        {
            // 하이라키에서  ZOMBIE 태그를 가진 오브젝트들의 갯수를 카운트해서 넘김
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

