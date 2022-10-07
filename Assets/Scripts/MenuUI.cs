using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public GameObject StartButton;
    public GameObject SoundButton;
    public GameObject QuitButton;
    void Start()
    {
        Button start = StartButton.GetComponent<Button>();
        start.onClick.AddListener(TaskOnClickStart);
        /////////////////////////////////////////////////////
        Button sound = SoundButton.GetComponent<Button>();
        sound.onClick.AddListener(TaskOnClickSound);
        /////////////////////////////////////////////////////
        Button quit = QuitButton.GetComponent<Button>();
        quit.onClick.AddListener(TaskOnClickExit);
    }

    public void TaskOnClickStart()//���������� ����� �� �������
    {
        SceneManager.LoadScene(1); //�� �������
    }

    public void TaskOnClickSound()
    {

    }

    public void TaskOnClickExit()//����� ������
    {
        Application.Quit();
    }
}
