using UnityEngine;

public class Pagamanager : MonoBehaviour
{
    public GameObject moodPage;
    public GameObject questPage;
    public GameObject journalPage;


    public void Start()
    {
        ShowMoodPage();
    }
    public void ShowMoodPage()
    {
        moodPage.SetActive(true);
        questPage.SetActive(false);
        journalPage.SetActive(false);
    }
    public void ShowQuestPage()
    {
        moodPage.SetActive(false);
        questPage.SetActive(true);
        journalPage.SetActive(false);
    }
    public void ShowJournalPage()
    {
        moodPage.SetActive(false);
        questPage.SetActive(false);
        journalPage.SetActive(true);
    }
}
