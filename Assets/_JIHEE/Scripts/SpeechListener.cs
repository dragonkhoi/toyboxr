using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

using UnityEngine.Windows.Speech;

public class SpeechListener : MonoBehaviour
{
    public static SpeechListener Instance;

    public UnityEvent<List<string>> keywordsDetected;
    public TextAsset keywordsFile;
    public HashSet<string> keywords;

    private DictationRecognizer m_DictationRecognizer;

    List<string> recognitions = new List<string>();
    List<string> extractions = new List<string>();

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            keywords = new HashSet<string>(keywordsFile.text.Split('\n'));
        }
    }

    void Start()
    {
        m_DictationRecognizer = new DictationRecognizer();

        m_DictationRecognizer.DictationResult += (text, confidence) =>
        {
            Debug.LogFormat("Dictation result: {0}", text);
            //m_Recognitions.text += text + "\n";
            recognitions.Add(text);
            SearchFromKeywords(text);
        };

        m_DictationRecognizer.DictationHypothesis += (text) =>
        {
            Debug.LogFormat("Dictation hypothesis: {0}", text);
        };

        m_DictationRecognizer.DictationComplete += (completionCause) =>
        {
            if (completionCause != DictationCompletionCause.Complete)
                Debug.LogErrorFormat("Dictation completed unsuccessfully: {0}.", completionCause);
        };

        m_DictationRecognizer.DictationError += (error, hresult) =>
        {
            Debug.LogErrorFormat("Dictation error: {0}; HResult = {1}.", error, hresult);
        };

        m_DictationRecognizer.Start();
    }

    void SearchFromKeywords(string newString) {
        List<string> foundWords = new List<string>();
        string[] bagOfWords = newString.Split(' ');
        foreach (string s in bagOfWords) {
            foreach (string keyword in keywords)
            {
                if (s.Trim().Equals(keyword.Trim()))
                {
                    Debug.Log("Found match: " + keyword.Trim() + "\n");
                    extractions.Add(s);
                    foundWords.Add(keyword.Trim());
                }
            }
        }
        keywordsDetected.Invoke(foundWords);
    }

    /*
    void AddToText(Text textObject, List<string> strings)
    {
        textObject.text = "Recognized phrases: \n";
        foreach (string s in strings)
        {
            textObject.text += s + "\n";
        }
    }
    */
}
