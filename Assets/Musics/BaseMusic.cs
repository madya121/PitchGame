using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note
{
    public int bar;
    public int measureNumber;
    public int note;
    public float height;

    public Note(int bar, int measureNumber, int note, float height)
    {
        this.bar = bar;
        this.measureNumber = measureNumber;
        this.note = note;
        this.height = height;
    }
}

public class BaseMusic : MonoBehaviour
{
    virtual public float GetBPM() { return 0; }
    virtual public int GetBar() { return 0; }
    virtual public int GetBeatPerBar() { return 0; }
    virtual public int GetMeasurePerBeat() { return 0; }
    virtual public int GetMeasureHeight() { return 0; }

    virtual public List<Note> GetNotes() {
        List<Note> notes = new List<Note>();

        return notes;
    }
}
