using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SongSelectionManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SongSelected(SongButtonInfo song)
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Song Library");
        if (objs.Length > 0) {
            SongLibrary sl = objs[0].GetComponent<SongLibrary>();
            sl.SelectedMusic = song.SongID;
        }
        SceneManager.LoadScene("DemoScene");
    }
}
