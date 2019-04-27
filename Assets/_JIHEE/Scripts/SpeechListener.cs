using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;

public class SpeechListener : MonoBehaviour
{


    [SerializeField]
    private Text RecognizedText;

    [SerializeField]
    private Text ExtractedText;

    private DictationRecognizer m_DictationRecognizer;

    List<string> recognitions = new List<string>();

    void Start()
    {
        m_DictationRecognizer = new DictationRecognizer();

        m_DictationRecognizer.DictationResult += (text, confidence) =>
        {
            Debug.LogFormat("Dictation result: {0}", text);
            //m_Recognitions.text += text + "\n";
            recognitions.Add(text);
            AddToText(RecognizedText, recognitions);
        };

        m_DictationRecognizer.DictationHypothesis += (text) =>
        {
            Debug.LogFormat("Dictation hypothesis: {0}", text);
            //m_Hypotheses.text += text + Env;
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
        Debug.Log("Before start: " + m_DictationRecognizer.Status.ToString());

        m_DictationRecognizer.Start();

        //Debug.Log("After start: " + m_DictationRecognizer.Status.ToString());
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
}
