using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField nameInputField;
    public TMP_Text bestScoreText;

    private void Start()
    {
        // Display saved best score when the menu loads
        bestScoreText.text = $"Best Score : {DataManager.Instance.bestPlayerName} : {DataManager.Instance.bestScore}";
    }

    public void StartNew()
    {
        DataManager.Instance.playerName = nameInputField.text;
        SceneManager.LoadScene("main");
    }

    public void Exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
