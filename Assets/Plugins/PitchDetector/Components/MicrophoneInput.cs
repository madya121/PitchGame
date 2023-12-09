using System;
using UnityEngine;

namespace FinerGames.PitchDetector
{
    public class MicrophoneInput : MonoBehaviour
    {
        public AudioSource Source;

        public string DeviceName;
        public bool IsRecording = true;

        public int SampleRate = 44100;

        private void Awake()
        {
            DeviceName = PlayerPrefs.GetString("Mic");
            if (DeviceName == "" && Microphone.devices.Length > 0)
                DeviceName = Microphone.devices[0];
        }
    }
}