using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using UnityEngine.UI;
public class SimpleKPAD : UdonSharpBehaviour
{
    [SerializeField] public int passcode;
    [SerializeField] private string[] Users;
    [SerializeField] private GameObject[] ObjectsOn;
    [SerializeField] private GameObject[] ObjectsOff;
    public Text inputText;
    public Text AccessText;
    private int enteredNumber = 0;
    private bool access = false;
    public void Start()
    {
        if (Networking.LocalPlayer != null)
        {
            string localPlayerName = Networking.LocalPlayer.displayName;

            foreach (string u in Users)
            {
                if (u == localPlayerName)
                {
                    SetActiveForAll(ObjectsOn, true);
                    SetActiveForAll(ObjectsOff, false);
                    access = true;
                }
            }
        }
        AccessText.color = access ? Color.green : Color.red;
    }
    public void EnterPasscode_0(){AddToEnteredNumber(0);}
    public void EnterPasscode_1(){AddToEnteredNumber(1);}
    public void EnterPasscode_2(){AddToEnteredNumber(2);}
    public void EnterPasscode_3(){AddToEnteredNumber(3);}
    public void EnterPasscode_4(){AddToEnteredNumber(4);}
    public void EnterPasscode_5(){AddToEnteredNumber(5);}
    public void EnterPasscode_6(){AddToEnteredNumber(6);}
    public void EnterPasscode_7(){AddToEnteredNumber(7);}
    public void EnterPasscode_8(){AddToEnteredNumber(8);}
    public void EnterPasscode_9(){AddToEnteredNumber(9);}
    private void AddToEnteredNumber(int number)
    {
        enteredNumber = enteredNumber * 10 + number;
        inputText.text = enteredNumber.ToString();
    }
    public void ClearEnteredNumber()
    {
        enteredNumber = 0;
        inputText.text = "";
    }
    public void CheckEnteredNumber()
    {
        if (enteredNumber == passcode)
        {
            access = true;
            SetActiveForAll(ObjectsOn, true);
            SetActiveForAll(ObjectsOff, false);
        }
        else
        {
            access = false;
        }
        AccessText.color = access ? Color.green : Color.red;
        ClearEnteredNumber();
    }
    private void SetActiveForAll(GameObject[] objects, bool active)
    {
        foreach (GameObject obj in objects)
        {
            obj.SetActive(active);
        }
    }
}