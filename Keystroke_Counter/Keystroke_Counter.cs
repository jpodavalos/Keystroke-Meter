using System;
using System.Windows.Forms;
using Utilities;

namespace Keystroke_Counter
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        private globalKeyboardHook gkh = new globalKeyboardHook();
        private long counter = 0;
        private long total_counter = 0;

        public Main()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                //Letters A-Z
                gkh.HookedKeys.Add(Keys.A);
                gkh.HookedKeys.Add(Keys.B);
                gkh.HookedKeys.Add(Keys.C);
                gkh.HookedKeys.Add(Keys.D);
                gkh.HookedKeys.Add(Keys.E);
                gkh.HookedKeys.Add(Keys.F);
                gkh.HookedKeys.Add(Keys.G);
                gkh.HookedKeys.Add(Keys.H);
                gkh.HookedKeys.Add(Keys.I);
                gkh.HookedKeys.Add(Keys.J);
                gkh.HookedKeys.Add(Keys.K);
                gkh.HookedKeys.Add(Keys.L);
                gkh.HookedKeys.Add(Keys.M);
                gkh.HookedKeys.Add(Keys.N);
                gkh.HookedKeys.Add(Keys.O);
                gkh.HookedKeys.Add(Keys.P);
                gkh.HookedKeys.Add(Keys.Q);
                gkh.HookedKeys.Add(Keys.R);
                gkh.HookedKeys.Add(Keys.S);
                gkh.HookedKeys.Add(Keys.T);
                gkh.HookedKeys.Add(Keys.U);
                gkh.HookedKeys.Add(Keys.V);
                gkh.HookedKeys.Add(Keys.W);
                gkh.HookedKeys.Add(Keys.X);
                gkh.HookedKeys.Add(Keys.Y);
                gkh.HookedKeys.Add(Keys.Z);

                //Numbers
                gkh.HookedKeys.Add(Keys.NumPad0);
                gkh.HookedKeys.Add(Keys.D0);
                gkh.HookedKeys.Add(Keys.NumPad1);
                gkh.HookedKeys.Add(Keys.D1);
                gkh.HookedKeys.Add(Keys.NumPad2);
                gkh.HookedKeys.Add(Keys.D2);
                gkh.HookedKeys.Add(Keys.NumPad3);
                gkh.HookedKeys.Add(Keys.D3);
                gkh.HookedKeys.Add(Keys.NumPad4);
                gkh.HookedKeys.Add(Keys.D4);
                gkh.HookedKeys.Add(Keys.NumPad5);
                gkh.HookedKeys.Add(Keys.D5);
                gkh.HookedKeys.Add(Keys.NumPad6);
                gkh.HookedKeys.Add(Keys.D6);
                gkh.HookedKeys.Add(Keys.NumPad7);
                gkh.HookedKeys.Add(Keys.D7);
                gkh.HookedKeys.Add(Keys.NumPad8);
                gkh.HookedKeys.Add(Keys.D8);
                gkh.HookedKeys.Add(Keys.NumPad9);
                gkh.HookedKeys.Add(Keys.D9);

                //Modifiers
                gkh.HookedKeys.Add(Keys.LMenu);
                gkh.HookedKeys.Add(Keys.RMenu);

                gkh.HookedKeys.Add(Keys.LShiftKey);
                gkh.HookedKeys.Add(Keys.RShiftKey);
                gkh.HookedKeys.Add(Keys.Shift);

                gkh.HookedKeys.Add(Keys.ControlKey);
                gkh.HookedKeys.Add(Keys.Control);
                gkh.HookedKeys.Add(Keys.LControlKey);
                gkh.HookedKeys.Add(Keys.RControlKey);

                gkh.HookedKeys.Add(Keys.CapsLock);

                gkh.HookedKeys.Add(Keys.Tab);
                gkh.HookedKeys.Add(Keys.Escape);
                gkh.HookedKeys.Add(Keys.Back);

                //Arithmetic
                gkh.HookedKeys.Add(Keys.Add);
                gkh.HookedKeys.Add(Keys.Subtract);
                gkh.HookedKeys.Add(Keys.Multiply);
                gkh.HookedKeys.Add(Keys.Divide);

                //Symbols
                gkh.HookedKeys.Add(Keys.Decimal);
                gkh.HookedKeys.Add(Keys.Oem1);
                gkh.HookedKeys.Add(Keys.Oem2);
                gkh.HookedKeys.Add(Keys.Oem3);
                gkh.HookedKeys.Add(Keys.Oem4);
                gkh.HookedKeys.Add(Keys.Oem5);
                gkh.HookedKeys.Add(Keys.Oem6);
                gkh.HookedKeys.Add(Keys.Oem7);
                gkh.HookedKeys.Add(Keys.Oem8);
                gkh.HookedKeys.Add(Keys.Oem102);
                gkh.HookedKeys.Add(Keys.OemBackslash);
                gkh.HookedKeys.Add(Keys.OemClear);
                gkh.HookedKeys.Add(Keys.OemCloseBrackets);
                gkh.HookedKeys.Add(Keys.Oemcomma);
                gkh.HookedKeys.Add(Keys.OemMinus);
                gkh.HookedKeys.Add(Keys.OemOpenBrackets);
                gkh.HookedKeys.Add(Keys.OemPeriod);
                gkh.HookedKeys.Add(Keys.OemPipe);
                gkh.HookedKeys.Add(Keys.Oemplus);
                gkh.HookedKeys.Add(Keys.OemQuestion);
                gkh.HookedKeys.Add(Keys.OemQuotes);
                gkh.HookedKeys.Add(Keys.OemSemicolon);
                gkh.HookedKeys.Add(Keys.Oemtilde);

                gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
            }
            catch (Exception)
            {
            }
        }

        private void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                counter++;
                total_counter++;
                total_char_text.Text = total_counter.ToString();
                lastkey.Text = e.KeyCode.ToString();
            }
            catch (Exception)
            {
            }
        }
    }
}