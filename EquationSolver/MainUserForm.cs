using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquationSolver
{
    public partial class MainUserForm : Form
    {
        double[] UserVariables = new double[26];

        void InitKeyPressEventHandler()
        {
            this.KeyPress += new KeyPressEventHandler( Hotkey_EventHandler );
            TextBox_InputInfix.KeyPress += new KeyPressEventHandler( Hotkey_EventHandler );
            TextBox_InputRPN.KeyPress += new KeyPressEventHandler( Hotkey_EventHandler );
            TextBox_Output.KeyPress += new KeyPressEventHandler( Hotkey_EventHandler );
            TextBox_Error.KeyPress += new KeyPressEventHandler( Hotkey_EventHandler );
            
            TextBox_VarToChange.KeyPress += new KeyPressEventHandler( Hotkey_EventHandler );
            DataGridView_VarList.KeyPress += new KeyPressEventHandler( Hotkey_EventHandler );
            
            TextBox_Epsilon.KeyPress += new KeyPressEventHandler( Hotkey_EventHandler );
            TextBox_Intervals.KeyPress += new KeyPressEventHandler( Hotkey_EventHandler );
            TextBox_Step.KeyPress += new KeyPressEventHandler( Hotkey_EventHandler );
            TextBox_Range.KeyPress += new KeyPressEventHandler( Hotkey_EventHandler );
            Button_Next.KeyPress += new KeyPressEventHandler( Hotkey_EventHandler );
            Button_Prev.KeyPress += new KeyPressEventHandler( Hotkey_EventHandler );
            Button_RetryOutput.KeyPress += new KeyPressEventHandler( Hotkey_EventHandler );
        }

        public MainUserForm()
        {
            InitializeComponent();

            for(int i = 0; i < 26; i++)
            {
                UserVariables[i] = 0;
            }
            
            InitKeyPressEventHandler();
        }

        private string OneSideExpression()
        {
            string temp = TextBox_InputInfix.Text;

            string LeftSide = "";
            string RightSide = "";
            bool IsLeftSided = true;

            for(int i = 0; i<temp.Length; i++)
            {
                if(IsLeftSided)
                {
                    if(temp[i] == '=')
                        IsLeftSided = false;
                    else
                        LeftSide += temp[i];
                }
                else
                {
                    RightSide += temp[i];
                }
            }

            if( IsLeftSided )
                return LeftSide;
            else
                return "(" + LeftSide + ")-(" + RightSide + ")"; 
        }

        
        private void HandleHotkeys(char key)
        {
            // cycle unkown variables
            if( key == 13 )
            {
                Cycle_ComboBox_Unknown();
            }
            
            // refresh output
            if( key == 10 /* Ctrl Enter */ )
            {
                List<string> pn = ExpressionCalculator.ConvertInfixToRPN( OneSideExpression() );
                Update_Textbox_Output(pn, -ExpressionCalculator.MaxRange, ExpressionCalculator.MaxRange);
                Update_DataGridView_VarList();
            }

            if( key == 12 /* Ctrl L */ )
            {
                DataGridView_VarList.Focus();
            }

            if( key == 9 /* Ctrl I */ )
            {
                TextBox_InputInfix.Focus();
            }

            if( key == 16 /* Ctrl P */ )
            {
                if( TextBox_VarToChange.Enabled )
                    TextBox_VarToChange.Focus();
            }

            if( key == 27 )
            {
                TextBox_InputInfix.Text = "";
                TextBox_InputInfix.Focus();
            }

            // MessageBox.Show(((int)key).ToString());
        }

    // UPDATING //////////////////////////////////////////////////////////////////////////////////////////////////        
        private void Update_TextBox_InputRPN(List<string> pn)
        {
            string temp = "";            
            foreach(string element in pn)
            {
                temp+=element+" ";
            }
            TextBox_InputRPN.Text = temp;
        }

        private void Update_Textbox_Output(List<string> pn, double LeftRange, double RightRange)
        {
            this.Cursor = Cursors.WaitCursor;

            if( Label_Unknown.Enabled )
            {
                if( ComboBox_Unkown.Text == "" )
                {
                    TextBox_Output.Text = "[ NO UNKOWN ]";
                    this.Cursor = Cursors.Default;
                    return;
                }
                if( pn[0] == "[ INVALID EXPRESSION ]")
                {
                    TextBox_Output.Text = "[ INVALID EXPRESSION ]";
                }
            
                char unknown = ComboBox_Unkown.Text[0];
                string temp = ExpressionCalculator.SolveForUnkown(pn, UserVariables, unknown, LeftRange, RightRange);
                TextBox_Output.Text = temp;

                temp = ExpressionCalculator.CalculateRPN(pn, UserVariables);
                TextBox_Error.Text = temp;
            }
            else
            {    
                string temp = ExpressionCalculator.CalculateRPN(pn, UserVariables);
                TextBox_Output.Text = temp;
                TextBox_Error.Text = "[ NOT AVAILABLE ]";
            }

            this.Cursor = Cursors.Default;
        }

        private void Update_DataGridView_VarList()
        {
            bool[] EnabledVariables = new bool[26];
            string temp = TextBox_InputInfix.Text;
            
            for(int i = 0; i < 26; i++)
            {
                EnabledVariables[i] = false;
            }

            for(int i = 0; i<temp.Length; i++)
            {
                if( temp[i] >= 'a' && temp[i] <= 'z' )
                    EnabledVariables[temp[i] - 'a'] = true;
            }

            DataGridView_VarList.Rows.Clear();
            for(int i = 0; i < 26; i++)
            {
                if( EnabledVariables[i] )
                {
                    DataGridView_VarList.Rows.Add( (char)(i+'a'), UserVariables[i].ToString("0." + new string('#', 339)));
                }
            } 
        }

        private void Update_ComboBox_Unknown()
        {
            string OldUnkown = ComboBox_Unkown.Text;
            ComboBox_Unkown.Items.Clear();

            bool[] EnabledVariables = new bool[26];
            string temp = TextBox_InputInfix.Text;
            bool equationMode = false;

            for(int i = 0; i<temp.Length; i++)
            {
                if( temp[i] >= 'a' && temp[i] <= 'z' )
                    EnabledVariables[temp[i] - 'a'] = true;
                if( temp[i] == '=' )
                    equationMode =true;
            }

            for(int i = 0; i < 26; i++)
            {
                if( EnabledVariables[i] )
                {
                    ComboBox_Unkown.Items.Add(((char)(i+'a')).ToString());
                }
            }

            if ( equationMode )
            {
                Label_Unknown.Enabled = true;
                ComboBox_Unkown.Enabled =true;
                Label_Error.Enabled = true;
                TextBox_Error.Enabled = true;
            }
            else
            {
                Label_Unknown.Enabled = false;
                ComboBox_Unkown.Enabled =false;   
                Label_Error.Enabled = false;
                TextBox_Error.Enabled = false;
            }

            if( OldUnkown != "" )
            {
                if( EnabledVariables[OldUnkown[0] - 'a'] )
                {
                    ComboBox_Unkown.Text = OldUnkown;
                }
                else
                {
                    ComboBox_Unkown.Text = "";
                }
            }
        }

        private void Update_Value_UserVariables(int rowIndex)
        {
            if( rowIndex < 0 )
            {
                return;
            }

            char c = DataGridView_VarList.Rows[rowIndex].Cells[0].Value.ToString()[0];
            string value = DataGridView_VarList.Rows[rowIndex].Cells[1].Value.ToString();

            try
            {
                UserVariables[c - 'a'] = double.Parse(value);
            }
            catch
            {
                UserVariables[c - 'a'] = double.NaN;
            }
        }

        private void Cycle_ComboBox_Unknown()
        {
            if( ComboBox_Unkown.Items.Count == 0)
            {
                return;
            }

            int index = 0;
            if( ComboBox_Unkown.Text != "" )
            {
                index = ComboBox_Unkown.Items.IndexOf(ComboBox_Unkown.Text);
                index = (index+1)%ComboBox_Unkown.Items.Count;
            }

            ComboBox_Unkown.Text = ComboBox_Unkown.Items[index].ToString();
        }

    // EVENT HANDLING //////////////////////////////////////////////////////////////////////////////////////////////////        
        private void TextBox_InputInfix_TextChanged(object sender, EventArgs e)
        {
            int temp = TextBox_InputInfix.SelectionStart;
            TextBox_InputInfix.Text = TextBox_InputInfix.Text.ToLower();
            TextBox_InputInfix.SelectionStart = temp;

            List<string> pn = ExpressionCalculator.ConvertInfixToRPN( OneSideExpression() );

            Update_TextBox_InputRPN(pn);
            Update_Textbox_Output(pn, -ExpressionCalculator.MaxRange, ExpressionCalculator.MaxRange);
            Update_DataGridView_VarList();
            Update_ComboBox_Unknown();
        }

        private void DataGridView_VarList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Update_Value_UserVariables(e.RowIndex);

            List<string> pn = ExpressionCalculator.ConvertInfixToRPN( OneSideExpression() );
            Update_Textbox_Output(pn, -ExpressionCalculator.MaxRange, ExpressionCalculator.MaxRange);
        }

        private void DataGridView_VarList_SelectionChanged(object sender, EventArgs e)
        {
            if( DataGridView_VarList.SelectedRows.Count == 0 )
            {
                Label_VarToChange.Text = "#";
                Label_VarToChange.Enabled = false;
                TextBox_VarToChange.Text = "";
                TextBox_VarToChange.Enabled = false;
                return;
            }

            DataGridViewRow row = DataGridView_VarList.SelectedRows[0];
            Label_VarToChange.Text = row.Cells[0].Value.ToString() + ":";
            Label_VarToChange.Enabled = true;
            TextBox_VarToChange.Text = row.Cells[1].Value.ToString();
            TextBox_VarToChange.Enabled = true;
        }

        private void TextBox_VarToChange_TextChanged(object sender, EventArgs e)
        {
            if( DataGridView_VarList.SelectedRows.Count == 0 )
            {
                return;
            }

            DataGridViewRow row = DataGridView_VarList.SelectedRows[0];
            row.Cells[1].Value = TextBox_VarToChange.Text;
        }

        private void DataGridView_VarList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBox_VarToChange.Focus();    
        }

        private void ComboBox_Unkown_TextChanged(object sender, EventArgs e)
        {
            if(!Label_Unknown.Enabled)
                return;

            List<string> pn = ExpressionCalculator.ConvertInfixToRPN( OneSideExpression() );
            Update_Textbox_Output(pn, -ExpressionCalculator.MaxRange, ExpressionCalculator.MaxRange);
            Update_DataGridView_VarList();
        }

        private void Button_RetryOutput_MouseClick(object sender, MouseEventArgs e)
        {
            List<string> pn = ExpressionCalculator.ConvertInfixToRPN( OneSideExpression() );
            Update_Textbox_Output(pn, -ExpressionCalculator.MaxRange, ExpressionCalculator.MaxRange);
            Update_DataGridView_VarList();
        }

        private void TextBox_Range_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ExpressionCalculator.MaxRange = double.Parse( TextBox_Range.Text );
            }
            catch
            {
                ExpressionCalculator.MaxRange = ExpressionCalculator.MaxRange_default;
                TextBox_Range.Text = ExpressionCalculator.MaxRange.ToString("0." + new string('#', 339));
            }
        }

        private void TextBox_Step_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ExpressionCalculator.TimesStep = int.Parse( TextBox_Step.Text );
            }
            catch
            {
                ExpressionCalculator.TimesStep = ExpressionCalculator.TimesStep_default;
                TextBox_Step.Text = ExpressionCalculator.TimesStep.ToString("0." + new string('#', 339));
            }
        }

        private void TextBox_Epsilon_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ExpressionCalculator.epsilon = double.Parse( TextBox_Epsilon.Text );
            }
            catch
            {
                ExpressionCalculator.epsilon = ExpressionCalculator.epsilon_default;
                TextBox_Epsilon.Text = ExpressionCalculator.epsilon.ToString("0." + new string('#', 339));
            }
        }

        private void TextBox_Intervals_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ExpressionCalculator.NumberOfIntervals = int.Parse( TextBox_Intervals.Text );
            }
            catch
            {
                ExpressionCalculator.NumberOfIntervals = ExpressionCalculator.NumberOfIntervals_default;
                TextBox_Intervals.Text = ExpressionCalculator.NumberOfIntervals.ToString("0." + new string('#', 339));
            }
        }

        private void TextBox_Precision_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ExpressionCalculator.DecimalDigits = int.Parse( TextBox_Precision.Text );
            }
            catch
            {
                ExpressionCalculator.DecimalDigits = ExpressionCalculator.DecimalDigits_default;
                TextBox_Precision.Text = ExpressionCalculator.DecimalDigits.ToString("0." + new string('#', 339));
            }
        }

        private void Button_Prev_MouseClick(object sender, MouseEventArgs e)
        {
            double RightRange;
            try
            {
                RightRange = double.Parse( TextBox_Output.Text ) - 1;
            }
            catch
            {
                return;
            }
            List<string> pn = ExpressionCalculator.ConvertInfixToRPN( OneSideExpression() );
            Update_Textbox_Output(pn, -ExpressionCalculator.MaxRange, RightRange);
            Update_DataGridView_VarList();
        }

        private void Button_Next_MouseClick(object sender, MouseEventArgs e)
        {
            double LeftRange;
            try
            {
                LeftRange = double.Parse( TextBox_Output.Text ) + 1;
            }
            catch
            {
                return;
            }
            List<string> pn = ExpressionCalculator.ConvertInfixToRPN( OneSideExpression() );
            Update_Textbox_Output(pn, LeftRange, ExpressionCalculator.MaxRange);
            Update_DataGridView_VarList();
        }

        // Common function to handle all keypress event of all controls
        void Hotkey_EventHandler(object sender, KeyPressEventArgs e)
        {
            HandleHotkeys(e.KeyChar);
        }


    }
}
