using UnityEngine.UI;
using UnityEngine;

public class DifficultyButton : MonoBehaviour
{

    private GameManager gameManager;

    public int difficulty;

    private Button button;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    void SetDifficulty()
    {
        Debug.Log(button.name + " was clicked");
        gameManager.startGame(difficulty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
