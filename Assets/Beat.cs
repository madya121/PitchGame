using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beat : MonoBehaviour
{
    public float lastInterval = 0;

    public int noteBeat;
    public float nextTimeForNote;
    BeatManager beatManager;
    LineRenderer l;

    public int direction;
    public float startY;

    public void init (int noteBeat, float nextTimeForNote, BeatManager beatManager, int direction, float startY)
    {
        this.noteBeat = noteBeat;
        this.nextTimeForNote = nextTimeForNote;
        this.beatManager = beatManager;
        this.l = GetComponent<LineRenderer>();
        this.direction = direction;
        this.startY = startY;
    }

    // Start is called before the first frame update
    void Start()
    {
        lastInterval = Time.realtimeSinceStartup * 1000f;
    }

    // Update is called once per frame
    void Update()
    {
        float t = GetElapsedTime() / (this.nextTimeForNote - lastInterval);
        float y = Mathf.Lerp(startY, 0f, t);

        if (direction == -1)
        {
            y = Mathf.Lerp(-startY, 0f, t);
        }

        l.SetPosition(0, new Vector3(-15, y, 0));
        l.SetPosition(1, new Vector3(15, y, 0));
        this.transform.position = new Vector3(0, y, 0);

        if (y == 0) Destroy(gameObject);
    }

    public float GetElapsedTime()
    {
        return Time.realtimeSinceStartup * 1000f - lastInterval;
    }
}
