using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    [SerializeField]
    private GameObject _bulletsUi;
    [SerializeField]
    private Text _BulletsUi;
    [SerializeField]
    private Text _BulletsText;
    
    public Text BulletsText
    {
      get{return _BulletsText; }
    }


  [SerializeField]
  private GameObject _gameOverUi;
  [SerializeField]
  private GameObject _gameWinUi;
   [SerializeField]
  private GameObject _CrossHair;


  
 public void ShowBulletsUi(bool show)
 {
    _bulletsUi.SetActive(show);

 }
  public void ShowGameOverUI(bool show)
 {
    _gameOverUi.SetActive(show);

 }
 public void ShowGameWinUI(bool show)
 {
   _gameWinUi.SetActive(show);

 }
 public void ShowCrossHair(bool show)
 {
  _CrossHair.SetActive(show);
 }
 public void Start()
 {
   ShowBulletsUi(false);
    ShowGameOverUI(false);
    ShowGameWinUI(false);
    ShowCrossHair(false);
 }
}
