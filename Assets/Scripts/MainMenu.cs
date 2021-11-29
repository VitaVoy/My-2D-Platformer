using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject _mainMenu;

    [SerializeField]
    private GameObject _optionMenu;

    [SerializeField]
    private Button _start;

    [SerializeField]
    private Button _option;

    [SerializeField]
    private Button _exit;

    [SerializeField]
    private Button _returnMainMenu;   

    private void Awake()
    {
        _start.onClick.AddListener(Resume);
        _option.onClick.AddListener(Option);
        _returnMainMenu.onClick.AddListener(ReturnMainMenu);
        _exit.onClick.AddListener(Exit);        
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            StartMainMenu();
        }        
    }

    private void StartMainMenu()
    {
        _mainMenu.SetActive(true);        
    }

    private void Resume()
    {
        _mainMenu.SetActive(false);        
    }

    private void Option()
    {
        _optionMenu.SetActive(true);
        _mainMenu.SetActive(false);
    }

    private void ReturnMainMenu()
    {
        _optionMenu.SetActive(false);
        _mainMenu.SetActive(true);
    }

    private void Exit()
    {
        Debug.Log("Вы вышли из игры");
    }
}
