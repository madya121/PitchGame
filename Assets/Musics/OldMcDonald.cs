using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldMcDonald : BaseMusic
{
    public override float GetBPM()
    {
        return 60;
    }

    public override int GetBar()
    {
        return 18; // 16 + 2
    }

    public override int GetBeatPerBar()
    {
        return 4;
    }

    public override int GetMeasurePerBeat()
    {
        return 3;
    }

    public override int GetMeasureHeight()
    {
        return 1;
    }

    public override List<Note> GetNotes()
    {
        List<Note> notes = new List<Note>();

        notes.Add(new Note(1, 1, 5, 1));
        notes.Add(new Note(1, 3, 5, 1));
        notes.Add(new Note(1, 5, 5, 1));
        notes.Add(new Note(1, 7, 2, 1));

        notes.Add(new Note(2, 1, 3, 1));
        notes.Add(new Note(2, 3, 3, 1));
        notes.Add(new Note(2, 5, 2, 2));

        notes.Add(new Note(3, 1, 7, 1));
        notes.Add(new Note(3, 3, 7, 1));
        notes.Add(new Note(3, 5, 6, 1));
        notes.Add(new Note(3, 7, 6, 1));

        notes.Add(new Note(4, 1, 5, 2));
        notes.Add(new Note(4, 7, 2, 1));

        notes.Add(new Note(5, 1, 5, 1));
        notes.Add(new Note(5, 3, 5, 1));
        notes.Add(new Note(5, 5, 5, 1));
        notes.Add(new Note(5, 7, 2, 1));

        notes.Add(new Note(6, 1, 3, 1));
        notes.Add(new Note(6, 3, 3, 1));
        notes.Add(new Note(6, 5, 2, 2));

        notes.Add(new Note(7, 1, 7, 1));
        notes.Add(new Note(7, 3, 7, 1));
        notes.Add(new Note(7, 5, 6, 1));
        notes.Add(new Note(7, 7, 6, 1));

        notes.Add(new Note(8, 1, 5, 2));
        notes.Add(new Note(8, 7, 2, 0.5f));
        notes.Add(new Note(8, 8, 2, 0.5f));

        notes.Add(new Note(9, 1, 5, 1));
        notes.Add(new Note(9, 3, 5, 1));
        notes.Add(new Note(9, 5, 5, 1));
        notes.Add(new Note(9, 7, 2, 0.5f));
        notes.Add(new Note(9, 8, 2, 0.5f));

        notes.Add(new Note(10, 1, 5, 1));
        notes.Add(new Note(10, 3, 5, 1));
        notes.Add(new Note(10, 5, 5, 2));

        notes.Add(new Note(11, 1, 5, 0.5f));
        notes.Add(new Note(11, 2, 5, 0.5f));
        notes.Add(new Note(11, 3, 5, 1));
        notes.Add(new Note(11, 5, 5, 0.5f));
        notes.Add(new Note(11, 6, 5, 0.5f));
        notes.Add(new Note(11, 7, 5, 1));

        notes.Add(new Note(12, 1, 5, 0.5f));
        notes.Add(new Note(12, 2, 5, 0.5f));
        notes.Add(new Note(12, 3, 5, 0.5f));
        notes.Add(new Note(12, 4, 5, 0.5f));
        notes.Add(new Note(12, 5, 5, 1));
        notes.Add(new Note(12, 7, 5, 1));

        notes.Add(new Note(13, 1, 5, 1));
        notes.Add(new Note(13, 3, 5, 1));
        notes.Add(new Note(13, 5, 5, 1));
        notes.Add(new Note(13, 7, 2, 1));

        notes.Add(new Note(14, 1, 3, 1));
        notes.Add(new Note(14, 3, 3, 1));
        notes.Add(new Note(14, 5, 2, 2));

        notes.Add(new Note(15, 1, 7, 1));
        notes.Add(new Note(15, 3, 7, 1));
        notes.Add(new Note(15, 5, 6, 1));
        notes.Add(new Note(15, 7, 6, 1));

        notes.Add(new Note(16, 1, 5, 3));

        return notes;
    }
}
