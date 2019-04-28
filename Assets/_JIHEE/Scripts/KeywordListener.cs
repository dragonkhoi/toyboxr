using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;

public class KeywordListener : MonoBehaviour
{
    //[SerializeField]
    //private string[] m_Keywords;
    //List<string> keywords = new List<string>();

    private KeywordRecognizer recognizer;
    public ConfidenceLevel confidence = ConfidenceLevel.Low;

    public TextAsset keywordsFile;
    string[] keywords;

    void Start()
    {
        keywords = keywordsFile.text.Split('\n');
        Debug.Log("keywords are: \n" + keywords[0]);
        recognizer = new KeywordRecognizer(keywords, confidence);
        recognizer.OnPhraseRecognized += OnPhraseRecognized;
        recognizer.Start();
        Debug.Log("Is this active? " + recognizer.IsRunning.ToString());
    }

    private void OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendFormat("{0} ({1}){2}", args.text, args.confidence, Environment.NewLine);
        builder.AppendFormat("\tTimestamp: {0}{1}", args.phraseStartTime, Environment.NewLine);
        builder.AppendFormat("\tDuration: {0} seconds{1}", args.phraseDuration.TotalSeconds, Environment.NewLine);
        Debug.Log(builder.ToString());
    }

    void AddToText(Text textObject, List<string> strings)
    {
        textObject.text = "Recognized phrases: \n";
        foreach (string s in strings)
        {
            textObject.text += s + "\n";
        }
        //textObject.text = 
    }

    private void OnApplicationQuit()
    {
        if (recognizer != null && recognizer.IsRunning)
        {
            recognizer.Stop();
        }
    }
}
