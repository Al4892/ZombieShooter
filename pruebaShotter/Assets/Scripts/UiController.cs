using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    [SerializeField]
    private GameObject _bulletsUi;
    [SerializeField]
    private Text _BulletsUi;
    public Text BulletsText;
  
 public void ShowBulletsUi(bool show)
 {
    _bulletsUi.SetActive(show);

 }
}
