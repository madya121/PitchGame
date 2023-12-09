using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pitch;

namespace FinerGames.PitchDetector.Recorder
{
    public class RecorderManager : MonoBehaviour
    {
        string[] supportedNotes = new string[] { "B 4", "C# 5", "D# 5", "E 5", "F# 5", "G# 5", "A# 5", "B 5" };

        [SerializeField] PitchDetector detector;

        public GameObject[] notes;

        Dictionary<string, List<int>> noteMap;

        // Start is called before the first frame update
        void Start()
        {
            noteMap = new Dictionary<string, List<int>>(8);

            new List<int>() {1, 2, 3, 4, 5 };

            noteMap.Add(supportedNotes[0], new List<int>() { });
            noteMap.Add(supportedNotes[1], new List<int>() { 7 });
            noteMap.Add(supportedNotes[2], new List<int>() { 7, 6 });
            noteMap.Add(supportedNotes[3], new List<int>() { 7, 6, 5 });
            noteMap.Add(supportedNotes[4], new List<int>() { 7, 6, 5, 4 });
            noteMap.Add(supportedNotes[5], new List<int>() { 7, 6, 5, 4, 3 });
            noteMap.Add(supportedNotes[6], new List<int>() { 7, 6, 5, 4, 3, 2 });
            noteMap.Add(supportedNotes[7], new List<int>() { 7, 6, 5, 4, 3, 1});

            float sc = getScreenWidth() * 2;
            float numberNotes = 8f;
            float noteDivider = sc / numberNotes;

            for (int i = 7; i >= 1; i--)
            {
                notes[i].transform.localPosition = new Vector3(i * noteDivider - getScreenWidth(), 0f, 0);
                notes[i].transform.localScale = new Vector3(5, 1, 1);
            }

            notes[0].transform.localPosition = new Vector3(1 * noteDivider - getScreenWidth() + noteDivider / 2.5f, -0.5f, 0);
            notes[0].transform.localScale = new Vector3(5f, 1f, 1);
        }

        // Update is called once per frame
        void Update()
        {
            string noteName = GetKeyPressed();
            
            if (noteName == "")
                noteName = PitchDsp.GetNoteName(detector.MidiNote, true, true);
            
            RenderNote(noteName);
        }

        String GetKeyPressed()
        {
            if (Input.GetKey(KeyCode.A))
                return "B 5";
            if (Input.GetKey(KeyCode.S))
                return "A# 5";
            if (Input.GetKey(KeyCode.D))
                return "G# 5";
            if (Input.GetKey(KeyCode.F))
                return "F# 5";
            if (Input.GetKey(KeyCode.G))
                return "E 5";
            if (Input.GetKey(KeyCode.H))
                return "D# 5";
            if (Input.GetKey(KeyCode.J))
                return "C# 5";
            if (Input.GetKey(KeyCode.K))
                return "B 4";
            
            return "";
        }

        void RenderNote(string noteName)
        {
            foreach (GameObject g in notes)
                g.GetComponent<SpriteRenderer>().color = Color.red;

            if (noteName == null || !noteMap.ContainsKey(noteName))
                return;
            
            BroadcastMessage("NoteHit", noteMap[noteName], SendMessageOptions.RequireReceiver);

            for (int i = 0; i < notes.Length; i++)
            {
                if (noteMap[noteName].Contains(i))
                {
                    notes[i].GetComponent<SpriteRenderer>().color = Color.red;
                } 
                else
                {
                    notes[i].GetComponent<SpriteRenderer>().color = Color.green;
                }
            }
        }

        public float getScreenWidth()
        {
            return 5f * 16f / 9f;
        }
    }
}