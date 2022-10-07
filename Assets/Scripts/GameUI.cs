using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public GameObject RestartButton;
    public GameObject SoundButton;

    void Start()
    {
        //////////////////////////////////////////////////// ��������� ���������� �� Button
        Button restart = RestartButton.GetComponent<Button>();
        restart.onClick.AddListener(TaskOnClickStart);
        //////////////////////////////////////////////////// ��� ��������� �� restart ����� ������ ��������� �����, �� ��, ��� � �� start
        Button sound = SoundButton.GetComponent<Button>();
        sound.onClick.AddListener(TaskOnClickSound);
    }

    public void TaskOnClickStart()//���������� ����� �� �������
    {
        SceneManager.LoadScene(1); //�� �������
    }

    public void TaskOnClickSound()
    {

    }
}
