using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwinkleTwinkle : BaseMusic
{
    public override int GetBar()
    {
        return 14; // 12 + 2
    }

    public override int GetBeatPerBar()
    {
        return 4;
    }

    public override float GetBPM()
    {
        return 110;
    }

    public override int GetMeasureHeight()
    {
        return 2;
    }

    public override int GetMeasurePerBeat()
    {
        return 1;
    }

    public override List<Note> GetNotes()
    {
        List<Note> notes = new List<Note>();

        notes.Add(new Note(1, 1, 1, 1));
        notes.Add(new Note(1, 2, 1, 1));
        notes.Add(new Note(1, 3, 5, 1));
        notes.Add(new Note(1, 4, 5, 1));

        notes.Add(new Note(2, 1, 6, 1));
        notes.Add(new Note(2, 2, 6, 1));
        notes.Add(new Note(2, 3, 5, 2));

        notes.Add(new Note(3, 1, 4, 1));
        notes.Add(new Note(3, 2, 4, 1));
        notes.Add(new Note(3, 3, 3, 1));
        notes.Add(new Note(3, 4, 3, 1));

        notes.Add(new Note(4, 1, 2, 1));
        notes.Add(new Note(4, 2, 2, 1));
        notes.Add(new Note(4, 3, 1, 2));

        notes.Add(new Note(5, 1, 5, 1));
        notes.Add(new Note(5, 2, 5, 1));
        notes.Add(new Note(5, 3, 4, 1));
        notes.Add(new Note(5, 4, 4, 1));

        notes.Add(new Note(6, 1, 3, 1));
        notes.Add(new Note(6, 2, 3, 1));
        notes.Add(new Note(6, 3, 2, 2));

        notes.Add(new Note(7, 1, 5, 1));
        notes.Add(new Note(7, 2, 5, 1));
        notes.Add(new Note(7, 3, 4, 1));
        notes.Add(new Note(7, 4, 4, 1));

        notes.Add(new Note(8, 1, 3, 1));
        notes.Add(new Note(8, 2, 3, 1));
        notes.Add(new Note(8, 3, 2, 2));

        notes.Add(new Note(9, 1, 1, 1));
        notes.Add(new Note(9, 2, 1, 1));
        notes.Add(new Note(9, 3, 5, 1));
        notes.Add(new Note(9, 4, 5, 1));

        notes.Add(new Note(10, 1, 6, 1));
        notes.Add(new Note(10, 2, 6, 1));
        notes.Add(new Note(10, 3, 5, 2));

        notes.Add(new Note(11, 1, 4, 1));
        notes.Add(new Note(11, 2, 4, 1));
        notes.Add(new Note(11, 3, 3, 1));
        notes.Add(new Note(11, 4, 3, 1));

        notes.Add(new Note(12, 1, 2, 1));
        notes.Add(new Note(12, 2, 2, 1));
        notes.Add(new Note(12, 3, 1, 2));

        return notes; ;
    }
}
