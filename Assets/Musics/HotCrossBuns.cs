using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotCrossBuns : BaseMusic
{
    public override int GetBar()
    {
        return 10; // 8 + 2
    }

    public override int GetBeatPerBar()
    {
        return 4;
    }

    public override float GetBPM()
    {
        return 100;
    }

    public override int GetMeasureHeight()
    {
        return 1;
    }

    public override int GetMeasurePerBeat()
    {
        return 2;
    }

    public override List<Note> GetNotes()
    {
        List<Note> notes = new List<Note>();

        notes.Add(new Note(1, 1, 7, 1));
        notes.Add(new Note(1, 3, 6, 1));
        notes.Add(new Note(1, 5, 5, 2));
        
        notes.Add(new Note(2, 1, 7, 1));
        notes.Add(new Note(2, 3, 6, 1));
        notes.Add(new Note(2, 5, 5, 2));
        
        notes.Add(new Note(3, 1, 5, 0.5f));
        notes.Add(new Note(3, 2, 5, 0.5f));
        notes.Add(new Note(3, 3, 5, 0.5f));
        notes.Add(new Note(3, 4, 5, 0.5f));
        notes.Add(new Note(3, 5, 6, 0.5f));
        notes.Add(new Note(3, 6, 6, 0.5f));
        notes.Add(new Note(3, 7, 6, 0.5f));
        notes.Add(new Note(3, 8, 6, 0.5f));
        
        notes.Add(new Note(4, 1, 7, 1));
        notes.Add(new Note(4, 3, 6, 1));
        notes.Add(new Note(4, 5, 5, 2));
        
        notes.Add(new Note(5, 1, 7, 1));
        notes.Add(new Note(5, 3, 6, 1));
        notes.Add(new Note(5, 5, 5, 2));
        
        notes.Add(new Note(6, 1, 7, 1));
        notes.Add(new Note(6, 3, 6, 1));
        notes.Add(new Note(6, 5, 5, 2));
        
        notes.Add(new Note(7, 1, 5, 0.5f));
        notes.Add(new Note(7, 2, 5, 0.5f));
        notes.Add(new Note(7, 3, 5, 0.5f));
        notes.Add(new Note(7, 4, 5, 0.5f));
        notes.Add(new Note(7, 5, 6, 0.5f));
        notes.Add(new Note(7, 6, 6, 0.5f));
        notes.Add(new Note(7, 7, 6, 0.5f));
        notes.Add(new Note(7, 8, 6, 0.5f));
        
        notes.Add(new Note(8, 1, 7, 1));
        notes.Add(new Note(8, 3, 6, 1));
        notes.Add(new Note(8, 5, 5, 2));
        

        return notes; ;
    }
}
