using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.IO;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public SaveDatas saveDatas;

    public string playerName { get; private set; }

    // Start is called before the first frame update
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        loadHiScore();
    }

    public void setPlayName(string value)
    {
        playerName = value;
    }
    public void startGame()
    {
        SceneManager.LoadScene(1);
    }

    [System.Serializable]
    public class SaveDatas
    {
        public int hiScore;
    }
    private void loadHiScore()
    {
        string json = File.ReadAllText(Application.persistentDataPath + "/savefile.json");

        saveDatas = JsonUtility.FromJson<SaveDatas>(json);
    }
    public void saveHiScore(int value)
    {
        saveDatas.hiScore = value;
        string json = JsonUtility.ToJson(saveDatas);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
}
