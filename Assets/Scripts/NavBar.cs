using UnityEngine;
using UnityEngine.UI;

public class NavBar : MonoBehaviour
{
    public Button moodButton;
    public Button questButton;
    public Button journalButton;

    public Image moodBG;
    public Image questBG;
    public Image journalBG; 

    public Color selectedColor;
    public Color normalColor;

    void Start()
    {
        SelectMood();

        moodButton.onClick.AddListener(SelectMood);
        questButton.onClick.AddListener(SelectQuests);
        journalButton.onClick.AddListener(SelectJournal);
    }

    void SelectMood()
    {
        moodBG.color = selectedColor;
        questBG.color = normalColor;
        journalBG.color = normalColor;
    }

    void SelectQuests()
    {
        moodBG.color = normalColor;
        questBG.color = selectedColor;
        journalBG.color = normalColor;
    }

    void SelectJournal()
    {
        moodBG.color = normalColor;
        questBG.color = normalColor;
        journalBG.color = selectedColor;
    }
}
