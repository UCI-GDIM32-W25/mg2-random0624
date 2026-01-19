using TMPro;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _pointText;

    public void UpdatePoint(int points)
    {
        _pointText.text = points.ToString();
    }
}
