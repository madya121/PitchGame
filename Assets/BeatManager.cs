using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatManager : MonoBehaviour
{
    public float BPM = 150;
    public float startY = 5;

    private float lastInterval = 0;
    public int beatNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        lastInterval = Time.realtimeSinceStartup;
    }

    // Update is called once per frame
    void Update()
    {
        calculateBPM();
    }

    void calculateBPM()
    {
        float nextBeatTime = (float)beatNumber * (1.0f / BPM) * 60.0f * 1000.0f;
        float currentTime = GetElapsedTime() * 1000.0f

        Debug.Log(beatNumber + " " + nextBeatTime + " " + currentTime);

        if (currentTime >= nextBeatTime)
        {
            beatNumber++;

            addBpmBarTop();
            addBpmBarDown();
        }
    }

    void addBpmBarDown()
    {
        GameObject g = new GameObject();
        LineRenderer l = g.AddComponent<LineRenderer>();
        Beat b = g.AddComponent<Beat>();

        int bn = beatNumber + 10;

        b.init(bn, (float)bn * (1.0f / BPM) * 60.0f * 1000.0f, this, -1, startY);

        l.material = new Material(Shader.Find("Sprites/Default"));
        l.positionCount = 2;
        l.widthMultiplier = 0.01f;
        l.SetPosition(0, new Vector3(-15, -startY, 0));
        l.SetPosition(1, new Vector3(15, -startY, 0));
    }

    void addBpmBarTop()
    {
        GameObject g = new GameObject();
        LineRenderer l = g.AddComponent<LineRenderer>();
        Beat b = g.AddComponent<Beat>();

        int bn = beatNumber + 10;

        b.init(bn, (float)bn * (1.0f / BPM) * 60.0f * 1000.0f, this, 1, startY);

        l.material = new Material(Shader.Find("Sprites/Default"));
        l.positionCount = 2;
        l.widthMultiplier = 0.01f;
        l.SetPosition(0, new Vector3(-15, startY, 0));
        l.SetPosition(1, new Vector3(15, startY, 0));
    }

    public float GetElapsedTime()
    {
        return Time.realtimeSinceStartup - lastInterval;
    }
}
