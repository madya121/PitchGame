using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beat : MonoBehaviour
{
    public float lastInterval = 0;

    public int noteBeat;
    public float nextTimeForNote;
    LineRenderer l;

    public int direction;
    public float startY;

    private int note = 0;
    private float noteDivider = 0;
    private float height;

    public void init(int measureNumber, BeatManager beatManager, int note, float height)
    {
        nextTimeForNote = (1f / (beatManager.BPM * beatManager.MeasurePerBeat)) * measureNumber * 60f * 1000f;
        this.startY = measureNumber * beatManager.MeasureHeight;
        this.l = GetComponent<LineRenderer>();
        this.note = note;
        this.height = height;
    }

    // Start is called before the first frame update
    void Start()
    {
        lastInterval = Time.realtimeSinceStartup * 1000f;

        float sc = getScreenWidth() * 2;
        float numberNotes = 8f;
        noteDivider = sc / numberNotes;
    }

    // Update is called once per frame
    void Update()
    {
        float t = GetElapsedTime() / this.nextTimeForNote;
        float y = Mathf.Lerp(startY, 0f, t);

        if (direction == -1)
        {
            y = Mathf.Lerp(-startY, 0f, t);
        }

        if (note == 0)
        {
            l.SetPosition(0, new Vector3(-15, y, 0));
            l.SetPosition(1, new Vector3(15, y, 0));
            l.widthMultiplier = this.height;
            this.transform.position = new Vector3(0, y, 0);
        } else
        {
            float pos = noteDivider * (float)(8 - note) - getScreenWidth();

            if (note == 1 || note == 7)
            {
                l.startColor = Color.white;
                l.endColor = Color.white;
            }

            if (note == 2 || note == 6)
            {
                l.startColor = new Color(0.62f, 0.87f, 1);
                l.endColor = new Color(0.62f, 0.87f, 1);
            }

            if (note == 3 || note == 5)
            {
                l.startColor = Color.white;
                l.endColor = Color.white;
            }

            if (note == 4)
            {
                l.startColor = Color.yellow;
                l.endColor = Color.yellow;
            }

            // l.SetPosition(0, new Vector3(pos - 0.75f, y, 0));
            // l.SetPosition(1, new Vector3(pos + 0.75f, y, 0));

            l.SetPosition(0, new Vector3(pos, y, 0));
            l.SetPosition(1, new Vector3(pos, y + 0.1f, 0));
            l.widthMultiplier = 1.5f;
            this.transform.position = new Vector3(0, y, 0);
        }

        if (y == 0) Destroy(gameObject);
    }

    public float getScreenWidth()
    {
        return 5f * 16f / 9f;
    }

    public float GetElapsedTime()
    {
        return Time.realtimeSinceStartup * 1000f - lastInterval;
    }
}
