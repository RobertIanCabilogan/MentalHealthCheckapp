using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class RatingSystem : MonoBehaviour
{
    public Button[] stars;
    public Button submitButton;
    private int rating = 0;
    void Start()
    {
        stars = GetComponentsInChildren<Button>();

        for (int i = 0; i < stars.Length; i++)
        {
            int rating = i + 1;
            stars[i].onClick.AddListener(() => setRating(rating));
        }

        submitButton.onClick.AddListener(SubmitRating);
        UpdateStars();
    }

    public void setRating(int value)
    {
        rating = value;
        UpdateStars();

        Debug.Log("Selected Rating: " + rating);
    }

    void UpdateStars()
    {
        for(int i = 0; i < stars.Length; i++)
        {
            TMP_Text text = stars[i].GetComponentInChildren<TMP_Text>();
            if (i < rating)
            {
                text.text = "*";
            }
            else
            {
                text.text = "#";
            }
        }
    }

    void SubmitRating()
    {
        if(rating == 0)
        {
            Debug.Log("That's not a valid rating!");
            return;
        }

        Debug.Log("Rating Submitted: " + rating + "/5");
    }
}
