using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LearningManager : MonoBehaviour
{
    public Text contentField;

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
    }
}
