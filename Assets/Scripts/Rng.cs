using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Rng : MonoBehaviour
{
    
    public GameObject[] Candies;
   static int totalCandies = 1;
    static int totalscore = 0;

    public TextMeshProUGUI ScoreUI;
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(Timer());
        
        if (totalCandies <=15)
        {
        StopCoroutine(Timer());
            ScoreUI.text = "Total Score:" + totalscore.ToString();
        }



    }
    IEnumerator Timer()
    {
        while (totalCandies <= 3)
        {
            float SpawnSpeed = Random.Range(1f, 3f);
            int RandCandy = Random.Range(0, Candies.Length);
            Vector2 RandomSpawnPostion = new Vector2(Random.Range((float)-5.2, (float)5.1), (float)5.91);
            Instantiate(Candies[RandCandy], RandomSpawnPostion, Quaternion.identity);
            totalCandies++;
            yield return new WaitForSeconds(SpawnSpeed);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
