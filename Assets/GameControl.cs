using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{

    private float healt;
    private int oldValue;
    [SerializeField] Image healtBar;
    [SerializeField] GameObject newObject;
    [SerializeField] Text HealtSkor;
    [SerializeField] GameObject[] points;
    [SerializeField] Button[] buttons;



    void Start()
    {
        healt = 100f;
        oldValue = 30;
        HealtControl();
        // healtBar.fillAmount -= 1f; 
    }

    void HealtControl()
    {
        HealtSkor.text = oldValue.ToString();
    }

    void ButtonControl()
    {

        if(oldValue == 0)
        {
            foreach (var button in buttons)
            {
                button.interactable = false;
            }
        }
    }

    public void PointControl(int indisPoint)
    {

        healt--;
        HealtControl();
        Instantiate(newObject, points[indisPoint].transform.position, Quaternion.identity);
        ButtonControl();

    }
}
