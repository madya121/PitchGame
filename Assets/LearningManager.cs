using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LearningManager : MonoBehaviour
{
    public Text contentField;
    public Button songButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeContent(LearningContent lc)
    {
        contentField.text = lc.learningContent;

        if (contentField.text.Contains("Hot Cross Buns"))
            songButton.gameObject.SetActive(true);
        else songButton.gameObject.SetActive(false);

    }

    public void PlaySong()
    {
        SceneManager.LoadScene("HotCrossBunsPractice");
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
