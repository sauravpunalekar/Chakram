using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
//using UnityEditor;

public class TargetSpawn : MonoBehaviour
{
    Object g;
    float[] xcoord = { 210, 220, 230, 240, 250, 260, 270, 280, 290 };
    int times = 0;
    // Use this for initialization
    void Start()
    {
        //g = AssetDatabase.LoadAssetAtPath ("Assets/Shooting target/Target.prefab", typeof(GameObject));
        g = Resources.Load("Target", typeof(GameObject));
        reshuffle(xcoord);
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreCount.score == ScoreCount.reqScore && ScoreCount.reqScore < 9)
        {
            ScoreCount.reqScore += 2;
            ScoreCount.score = 0;
            times = 0;
            ScoreCount.scoretext.text = "Targets Killed : " + ScoreCount.score + "/" + ScoreCount.reqScore;
            InvokeRepeating("spawn", 5, 2);
        }
    }

    void spawn()
    {
        if (times >= ScoreCount.reqScore)
        {
            CancelInvoke();
        }
        else
        {
            Instantiate(g, new Vector3(xcoord[times], 5, 145), Quaternion.Euler(-90, 0, -180));
            times++;
        }
    }

    void reshuffle(float[] texts)

    {
        for (int t = 0; t < texts.Length; t++)
        {
            float tmp = texts[t];
            int r = Random.Range(t, texts.Length);
            texts[t] = texts[r];
            texts[r] = tmp;
        }
    }
}