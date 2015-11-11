using UnityEngine;

public class GameOverScript : MonoBehaviour
{

    int score = 0;
    private float GameOverX, GameOverY, GameOverWidth, GameOverHeight = 0.0f;
    private float ButtonX, ButtonY, ButtonWidth, ButtonHeight = 0.0f;
    private float ScoreX, ScoreY, ScoreWidth, ScoreHeight = 0.0f;

    // Use this for initialization
    void Start()
    {
        // Keep screen in portrait mode for mobile
        Screen.orientation = ScreenOrientation.Portrait;
        score = PlayerPrefs.GetInt("score");
    }

    void OnGUI()
    {
        ButtonHeight = Screen.height / 8.0f;
        ButtonWidth = Screen.width / 2.0f;
        ButtonX = Screen.width / 2.0f - ButtonWidth / 2.0f;
        ButtonY = Screen.height / 2.0f;

        GUI.skin.button.fontSize = 50;
        if (GUI.Button(new Rect(ButtonX, ButtonY - ButtonHeight, ButtonWidth, ButtonHeight), "Retry?"))
            Application.LoadLevel("GameScreen");
        if (GUI.Button(new Rect(ButtonX, ButtonY, ButtonWidth, ButtonHeight), "Main Menu"))
            Application.LoadLevel("MainMenuScene");

        GameOverWidth = Screen.width / 2f;
        GameOverHeight = Screen.height / 10.0f;
        GameOverX = Screen.width / 2.0f - GameOverWidth / 2.0f;
        GameOverY = Screen.height / 8.0f;//ButtonY - 2.0f * GameOverHeight;

        GUI.skin.label.fontSize = 40;
        GUI.Label(new Rect(GameOverX, GameOverY, GameOverWidth, GameOverHeight), "GAME OVER");

        ScoreHeight = Screen.height / 10.0f;
        ScoreWidth = Screen.width / 2.0f;
        ScoreX = GameOverX;
        ScoreY = GameOverY - GameOverHeight;

        GUI.Label(new Rect(ScoreX, ScoreY, ScoreWidth, ScoreHeight), "Score: " + score);
    }

}
