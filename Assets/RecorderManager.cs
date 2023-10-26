using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pitch;

namespace FinerGames.PitchDetector.Recorder
{
    public class RecorderManager : MonoBehaviour
    {
        string[] supportedNotes = new string[] { "B", "C#", "D", "D#", "F", "G", "A", "A#" };

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
        }

        // Update is called once per frame
        void Update()
        {
            string noteName = PitchDsp.GetNoteName(detector.MidiNote, true, false);

            RenderNote(noteName);
        }

        void RenderNote(string noteName)
        {
            foreach (GameObject g in notes)
                g.GetComponent<SpriteRenderer>().color = Color.red;

            if (noteName == null || !noteMap.ContainsKey(noteName))
                return;

            for (int i = 0; i < notes.Length; i++)
            {
                if (noteMap[noteName].Contains(i))
                {
                    notes[i].GetComponent<SpriteRenderer>().color = Color.green;
                } 
                else
                {
                    notes[i].GetComponent<SpriteRenderer>().color = Color.red;
                }
            }
        }
    }
}