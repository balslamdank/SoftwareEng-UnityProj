using dice_roller;
using UnityEngine;
using UnityEngine.UI;

public class calculator : MonoBehaviour
{
    //Make sure to attach these Buttons & InputField in the Inspector
    //Creating the buttons here
    public Button m_ButtonOne, m_ButtonTwo, m_ButtonThree, m_ButtonFour, m_ButtonFive, m_ButtonSix, m_ButtonD;
    public Button m_ButtonSeven, m_ButtonEight, m_ButtonNine, m_ButtonZero, m_ButtonPlus, m_ButtonMinus, m_ButtonDiv, m_ButtonMul, m_ButtonEnter, m_ButtonClear, m_ButtonBack;

    public InputField field;

    private dice_roller.roller roll = new dice_roller.roller();

    public roller Roll { get => roll; set => roll = value; }

    //Rotate test = new Rotate;

    void Start()
    {
        //Tells what each button puts into the input field/debug.log
        //Having trouble getting it to simply input the Text object associated with the button
        //Ideally want to pass the text object to input. Need to do some more work on this
        //Still missing the Backspace and Enter button. Everything else inputs correctly
        m_ButtonZero.onClick.AddListener(delegate { TaskWithParameters(field.text += "0"); });
        m_ButtonOne.onClick.AddListener(delegate { TaskWithParameters(field.text += "1"); });
        m_ButtonTwo.onClick.AddListener(delegate { TaskWithParameters(field.text += "2"); });
        m_ButtonThree.onClick.AddListener(delegate { TaskWithParameters(field.text += "3"); });
        m_ButtonFour.onClick.AddListener(delegate { TaskWithParameters(field.text += "4"); });
        m_ButtonFive.onClick.AddListener(delegate { TaskWithParameters(field.text += "5"); });
        m_ButtonSix.onClick.AddListener(delegate { TaskWithParameters(field.text += "6"); });
        m_ButtonSeven.onClick.AddListener(delegate { TaskWithParameters(field.text += "7"); });
        m_ButtonEight.onClick.AddListener(delegate { TaskWithParameters(field.text += "8"); });
        m_ButtonNine.onClick.AddListener(delegate { TaskWithParameters(field.text += "9"); });
        m_ButtonPlus.onClick.AddListener(delegate { TaskWithParameters(field.text += "+"); });
        m_ButtonMinus.onClick.AddListener(delegate { TaskWithParameters(field.text += "-"); });
        m_ButtonMul.onClick.AddListener(delegate { TaskWithParameters(field.text += "*"); });
        m_ButtonDiv.onClick.AddListener(delegate { TaskWithParameters(field.text += "/"); });
        m_ButtonD.onClick.AddListener(delegate { TaskWithParameters(field.text += "d"); });
        m_ButtonClear.onClick.AddListener(delegate { TaskWithParameters(field.text = ""); });

    }

    void TaskOnClick()
    {
        //Output this to console
        Debug.Log("You have clicked the button!");
    }

    void TaskWithParameters(string message)
    {
        //Output this to console
        Debug.Log(message);
    }

    void ButtonClicked(int buttonNo)
    {
        //Output this to console
        
        Debug.Log("Button clicked = " + buttonNo);
    }

    public void NewRoll(InputField input)
    {
        int output;
        string inputString = input.text;
        output = Roll.Work(inputString);
        inputString = output.ToString();
        field.text = inputString;

    }
}