using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewCalc : MonoBehaviour
{
    string textRef = string.Empty;
    string op1 = string.Empty;
    string op2 = string.Empty;
    char operation;
    double result = 0.0;

    public InputField helper;

    public void AddToField(string toAdd)
    {
        if (!this.GetComponent<InputField>().text.Contains("d") || toAdd != "d")
        {
            textRef = this.GetComponent<InputField>().text;
            textRef += toAdd;
            this.GetComponent<InputField>().text = textRef;
            textRef = helper.text;
            textRef += toAdd;
            helper.text = textRef;
        }
    }

    public void ClearField()
    {
        this.GetComponent<InputField>().text = "";
        helper.text = "";
        op1 = string.Empty;
        op2 = string.Empty;

    }

    public void TotalDice(bool flag)
    {
        if(flag)
        {
            string[] words = op1.Split('d');

            int.TryParse(words[0], out int temp1);
            int.TryParse(words[1], out int temp2);
            int total = 0;

            for(int i = 0; i < temp1; i++)
            {
                total += Random.Range(1, temp2);
            }

            op1 = total.ToString();
        }

        else
        {
            string[] words = op2.Split('d');

            int.TryParse(words[0], out int temp1);
            int.TryParse(words[1], out int temp2);
            int total = 0;

            for (int i = 0; i < temp1; i++)
            {
                total += Random.Range(1, temp2);
            }

            op2 = total.ToString();
        }
    }

    public void Add()
    {
        if (op1 == string.Empty)
        {
            op1 = this.GetComponent<InputField>().text;
            textRef = helper.text;
            if (op1.Contains("d"))
            {
                TotalDice(true);
                textRef += ("(" + op1 + ")" + "+");
            }

            else
            {
                textRef += "+";
            }

            operation = '+';
            this.GetComponent<InputField>().text = "";
            helper.text = textRef;
            
        }

        else
        {
            operation = '+';
            Equals();
            op1 = this.GetComponent<InputField>().text;
            textRef = helper.text;
            textRef += "+";
            helper.text = textRef;
            this.GetComponent<InputField>().text = "";
        }
    }

    public void Subtract()
    {
        if (op1 == string.Empty)
        {
            op1 = this.GetComponent<InputField>().text;
            textRef = helper.text;
            if (op1.Contains("d"))
            {
                TotalDice(true);
                textRef += ("(" + op1 + ")" + "-");
            }

            else
            {
                textRef += "-";
            }

            operation = '-';
            this.GetComponent<InputField>().text = "";
            helper.text = textRef;
        }

        else
        {
            operation = '-';
            Equals();
            op1 = this.GetComponent<InputField>().text;
            textRef = helper.text;
            textRef += "-";
            helper.text = textRef;
            this.GetComponent<InputField>().text = "";
        }
    }

    public void Multiply()
    {
        if (op1 == string.Empty)
        {
            op1 = this.GetComponent<InputField>().text;
            textRef = helper.text;
            if (op1.Contains("d"))
            {
                TotalDice(true);
                textRef += ("(" + op1 + ")" + "*");
            }

            else
            {
                textRef += "*";
            }

            operation = '*';
            this.GetComponent<InputField>().text = "";
            helper.text = textRef;
        }

        else
        {
            operation = '*';
            Equals();
            op1 = this.GetComponent<InputField>().text;
            textRef = helper.text;
            textRef += "*";
            helper.text = textRef;
            this.GetComponent<InputField>().text = "";
        }
    }

    public void Divide()
    {
        if (op1 == string.Empty)
        {
            op1 = this.GetComponent<InputField>().text;
            textRef = helper.text;
            if (op1.Contains("d"))
            {
                TotalDice(true);
                textRef += ("(" + op1 + ")" + "/");
            }

            else
            {
                textRef += "/";
            }

            operation = '/';
            this.GetComponent<InputField>().text = "";
            helper.text = textRef;
        }

        else
        {
            operation = '/';
            Equals();
            op1 = this.GetComponent<InputField>().text;
            textRef = helper.text;
            textRef += "/";
            helper.text = textRef;
            this.GetComponent<InputField>().text = "";
        }
    }

    public void Equals()
    {
        if (op1 == string.Empty)
        {
            op1 = this.GetComponent<InputField>().text;
            if (op1.Contains("d"))
            {
                TotalDice(true);
                textRef += ("(" + op1 + ")");
            }
            this.GetComponent<InputField>().text = op1;
            helper.text = textRef;
            op1 = string.Empty;
        }

        else
        {
            op2 = this.GetComponent<InputField>().text;
            textRef = helper.text;
            if (op2.Contains("d"))
            {
                TotalDice(false);
                textRef += ("(" + op2 + ")");
            }

            helper.text = textRef;
            double num1, num2;
            double.TryParse(op1, out num1);
            double.TryParse(op2, out num2);

            op1 = string.Empty;
            op2 = string.Empty;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    this.GetComponent<InputField>().text = result.ToString();
                    break;

                case '-':
                    result = num1 - num2;
                    this.GetComponent<InputField>().text = result.ToString();
                    break;

                case '*':
                    result = num1 * num2;
                    this.GetComponent<InputField>().text = result.ToString();
                    break;

                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        this.GetComponent<InputField>().text = result.ToString();
                    }

                    else
                    {
                        this.GetComponent<InputField>().text = "ERROR: NO DIV BY 0";
                    }
                    break;
            }
        }
    }
}
