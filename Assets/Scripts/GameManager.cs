using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary> Manages the state of the whole application </summary>
public class GameManager : MonoBehaviour
{
    [SerializeField] private string gameScene;

    public void Play()
    {
        Application.LoadLevel(gameScene);
    }

    public void Exit()
    {
        Application.Quit();
    }


}