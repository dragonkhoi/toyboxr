using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] Vector3 defaultSpawnLocation;
    [SerializeField] float spawnSpacing;

    void Start()
    {
        SpeechListener.Instance.keywordsDetected.AddListener(OnKeywordDetected);
    }

    void OnKeywordDetected(List<string> foundWords)
    {
        for (int i = 0; i < foundWords.Count; ++i)
        {
            GameObject prefab = (GameObject)Resources.Load(foundWords[i], typeof(GameObject));
            Vector3 spawnLocation = defaultSpawnLocation;
            spawnLocation.y += spawnSpacing * i;
            Instantiate(prefab, spawnLocation, Quaternion.identity);
        }
    }
}
