using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongLibrary : MonoBehaviour
{
    public GameObject[] Musics;
    public int SelectedMusic = 0;

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Song Library");

        if (objs.Length > 1) {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
