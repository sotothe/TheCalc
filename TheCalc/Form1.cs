using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheCalc
{
    public partial class TheCalc : Form
    {
        string appName = "TheCalc";
        Boolean txtRst = false;
        string mainStr;

        public TheCalc()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            change_mainStr(null);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtRst)
                btnClear_Click(null, null);
            else
            {
                if (txtDisplay.Text.Length == 1)
                    txtDisplay.Text = "0";
                else
                    txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
                change_mainStr("<");
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (txtRst)
                btnClear_Click(null, null);
            else
            {
                if (txtDisplay.Text != "0")
                {
                    if (txtDisplay.Text[0] == '-')
                        txtDisplay.Text = txtDisplay.Text.Substring(1, txtDisplay.Text.Length - 1);
                    else
                        txtDisplay.Text = "-" + txtDisplay.Text;
                    change_mainStr("--");
                }
            }
        }

        private void Operation(object sender, EventArgs e)
        {
            change_mainStr(((Button)sender).Text);
            txtDisplay.Text = "0";
            txtRst = true;
            btnDot.Enabled = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (mainStr.Contains("/") && !mainStr.Contains("."))
                if (mainStr[mainStr.Length - 1] == ')')
                {
                    mainStr = mainStr.Substring(0, mainStr.Length - 1);
                    mainStr += ".0)";
                }
                else
                    mainStr += ".";
            string ans = calc(mainStr);
            change_mainStr("=");
            if (ans.Length < 14 || ans.Contains("."))
                txtDisplay.Text = ans;
            else
            {
                txtDisplay.Text = "Long Answer!";
                MessageBox.Show(ans,"=");
            }
            txtRst = true;
        }

        private string calc(string str)
        {
            var pySrc =
            @"def Calc(s):
                try:
                    s=str(eval(s))
                except:
                    s='Error'
                return s";
            
            // host python and execute script
            var engine = IronPython.Hosting.Python.CreateEngine();
            var scope = engine.CreateScope();
            engine.Execute(pySrc, scope);

            // get function and dynamically invoke
            var calc = scope.GetVariable("Calc");
            var result = calc(str); // returns 42 (Int32)

            // get function with a strongly typed signature
            var calcTyped = scope.GetVariable<Func<string, string>>("Calc");
            String resultTyped = calcTyped(str);

            return resultTyped;
        }

        private string neg(string str, string dsp)
        {
            Boolean po = false;
            if (dsp[0] == '-')
            {
                str = str.Substring(0, str.Length - dsp.Length + 1);
                if (str.Length > 1 && str[str.Length - 1] == '(')
                    po = true;
                if (po)
                    str += dsp + ")";
                else
                    str += "(" + dsp + ")";
            }
            else
            {
                str = str.Substring(0, str.Length - dsp.Length -3);
                str += dsp;
            }

            return str;
        }

        private void change_mainStr(string key)
        {
            switch (key)
            {
                case null:
                    mainStr = appName;
                    break;

                case "<":
                    mainStr = mainStr.Substring(0, mainStr.Length - 1);
                    break;

                case "--":
                    mainStr = neg(mainStr, txtDisplay.Text);
                    break;

                case "=":
                    mainStr = "=";
                    break;

                case ".":
                    if (!txtDisplay.Text.Contains("."))
                        if (txtDisplay.Text == "")
                            mainStr += "0";
                        mainStr += key;
                    break;

                case "0":
                    if (txtDisplay.Text != "0" && txtDisplay.Text !="")
                        mainStr += key;
                    break;

                default:
                    if (mainStr == appName || mainStr == "=")
                        mainStr = "";
                    mainStr += key;
                    break;
            }
            if(mainStr != null)
                strDisplay(mainStr);
        }

        private void strDisplay(string str)
        {
            if (str.Length <= 30)
                TheCalc.ActiveForm.Text = str;
            else
                TheCalc.ActiveForm.Text = "..." + str.Substring(str.Length - 30, 30);
        }

        private void Number(object sender, EventArgs e)
        {
            if (txtRst)
            {
                txtDisplay.Text = "0";
                txtRst = false;
            }

            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = txtDisplay.Text.Substring(1, txtDisplay.Text.Length - 1);
            }
            change_mainStr(((Button)sender).Text);
            txtDisplay.Text += ((Button)sender).Text;
            btnBack.Enabled = true;
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains("."))
                btnDot.Enabled = false;
            else
                btnDot.Enabled = true;

            if (txtDisplay.Text == "0")
            {
                btnBack.Enabled = false;
                btnSign.Enabled = false;
            }
            else
            {
                btnClear.Enabled = true;
                btnBack.Enabled = true;
                btnSign.Enabled = true;
            }
        }

        private void Pr(object sender, MouseEventArgs e)
        {
            change_mainStr(((Button)sender).Text);
        }

        private void TheCalc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Button temp = new Button();
            temp.Text = e.KeyChar.ToString();
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                Number(temp, null);
            else if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/')
                Operation(temp, null);
            else if (e.KeyChar == '\n')
                btnEquals_Click(null, null);
            else if (e.KeyChar == '.' && !txtDisplay.Text.Contains('.'))
                Number(temp, null);
        }
    }
}
