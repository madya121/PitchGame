using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatManager : MonoBehaviour
{
    public float BPM = 150;
    public int Bar = 8;
    public int BeatPerBar = 4;
    public int MeasurePerBeat = 1;
    public int MeasureHeight = 2;

    public float startY = 5;

    private float lastInterval = 0;

    private Dictionary<int, List<int>> groupNotes = new Dictionary<int, List<int>>();

    // Start is called before the first frame update
    void Start()
    {
        lastInterval = Time.realtimeSinceStartup;

        groupNotes.Add(1, new List<int>() { 1, 2, 3, 4, 5, 6, 7 });
        groupNotes.Add(2, new List<int>() { 2, 3, 4, 5, 6, 7 });
        groupNotes.Add(3, new List<int>() { 3, 4, 5, 6, 7});
        groupNotes.Add(4, new List<int>() { 4, 5, 6, 7});
        groupNotes.Add(5, new List<int>() { 5, 6, 7});
        groupNotes.Add(6, new List<int>() { 6, 7});
        groupNotes.Add(7, new List<int>() { 7 });
        groupNotes.Add(8, new List<int>() { 6 });

        for (int i = 1; i <= Bar; i++) {
            addBeatBar(i * BeatPerBar * MeasurePerBeat + 1);
        }

        generateNote(1, 1, 7, 1);
        generateNote(1, 3, 6, 1);
        generateNote(1, 5, 5, 2);
        
        generateNote(2, 1, 7, 1);
        generateNote(2, 3, 6, 1);
        generateNote(2, 5, 5, 2);
        
        generateNote(3, 1, 5, 0.5f);
        generateNote(3, 2, 5, 0.5f);
        generateNote(3, 3, 5, 0.5f);
        generateNote(3, 4, 5, 0.5f);
        generateNote(3, 5, 6, 0.5f);
        generateNote(3, 6, 6, 0.5f);
        generateNote(3, 7, 6, 0.5f);
        generateNote(3, 8, 6, 0.5f);
        
        generateNote(4, 1, 7, 1);
        generateNote(4, 3, 6, 1);
        generateNote(4, 5, 5, 2);
    }

    // Update is called once per frame
    void Update() {}

    void addBeatBar(int measureNumber)
    {
        GameObject g = new GameObject();
        LineRenderer l = g.AddComponent<LineRenderer>();
        Beat b = g.AddComponent<Beat>();
        b.init(measureNumber, this, 0, 0.02f);

        l.material = new Material(Shader.Find("Sprites/Default"));
        l.positionCount = 2;
    }

    void addNote(int _bar, int measureNumber, int _note, float _height)
    {
        GameObject g = new GameObject();
        LineRenderer l = g.AddComponent<LineRenderer>();
        Beat b = g.AddComponent<Beat>();
        b.init(_bar * BeatPerBar * MeasurePerBeat + measureNumber, this, _note, _height);

        l.material = new Material(Shader.Find("Sprites/Default"));
        l.positionCount = 2;
        // l.widthMultiplier = 0.1f;
    }

    void generateNote(int _bar, int measureNumber, int _note, float _height)
    {
        foreach(int n in groupNotes[_note])
        {
            addNote(_bar, measureNumber, n, _height);
        }
    }

    public float GetElapsedTime()
    {
        return Time.realtimeSinceStartup - lastInterval;
    }
}
