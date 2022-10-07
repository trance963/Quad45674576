using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public GameObject RestartButton;
    public GameObject SoundButton;

    void Start()
    {
        //////////////////////////////////////////////////// добавляем слушателей на Button
        Button restart = RestartButton.GetComponent<Button>();
        restart.onClick.AddListener(TaskOnClickStart);
        //////////////////////////////////////////////////// для упрощения на restart стоит функия включения сцены, та же, что и на start
        Button sound = SoundButton.GetComponent<Button>();
        sound.onClick.AddListener(TaskOnClickSound);
    }

    public void TaskOnClickStart()//переключем сцену на игровую
    {
        SceneManager.LoadScene(1); //по индексу
    }

    public void TaskOnClickSound()
    {

    }
}
