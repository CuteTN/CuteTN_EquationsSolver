namespace EquationSolver
{
    partial class MainUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label_InputInfix = new System.Windows.Forms.Label();
            this.TextBox_InputInfix = new System.Windows.Forms.TextBox();
            this.TextBox_InputRPN = new System.Windows.Forms.TextBox();
            this.Label_InputRPN = new System.Windows.Forms.Label();
            this.TextBox_Output = new System.Windows.Forms.TextBox();
            this.Label_Output = new System.Windows.Forms.Label();
            this.Label_VarList = new System.Windows.Forms.Label();
            this.DataGridView_VarList = new System.Windows.Forms.DataGridView();
            this.Col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextBox_VarToChange = new System.Windows.Forms.TextBox();
            this.Label_VarToChange = new System.Windows.Forms.Label();
            this.Label_Unknown = new System.Windows.Forms.Label();
            this.ComboBox_Unkown = new System.Windows.Forms.ComboBox();
            this.Button_RetryOutput = new System.Windows.Forms.Button();
            this.TextBox_Range = new System.Windows.Forms.TextBox();
            this.Label_Step = new System.Windows.Forms.Label();
            this.TextBox_Step = new System.Windows.Forms.TextBox();
            this.Label_Range = new System.Windows.Forms.Label();
            this.TextBox_Epsilon = new System.Windows.Forms.TextBox();
            this.Label_Epsilon = new System.Windows.Forms.Label();
            this.Label_Intervals = new System.Windows.Forms.Label();
            this.TextBox_Intervals = new System.Windows.Forms.TextBox();
            this.Button_Next = new System.Windows.Forms.Button();
            this.Button_Prev = new System.Windows.Forms.Button();
            this.TextBox_Error = new System.Windows.Forms.TextBox();
            this.Label_Error = new System.Windows.Forms.Label();
            this.TextBox_Precision = new System.Windows.Forms.TextBox();
            this.Label_Precision = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_VarList)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_InputInfix
            // 
            this.Label_InputInfix.AutoSize = true;
            this.Label_InputInfix.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_InputInfix.Location = new System.Drawing.Point(50, 50);
            this.Label_InputInfix.Name = "Label_InputInfix";
            this.Label_InputInfix.Size = new System.Drawing.Size(49, 17);
            this.Label_InputInfix.TabIndex = 0;
            this.Label_InputInfix.Text = "Input:";
            // 
            // TextBox_InputInfix
            // 
            this.TextBox_InputInfix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_InputInfix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_InputInfix.Location = new System.Drawing.Point(30, 70);
            this.TextBox_InputInfix.Name = "TextBox_InputInfix";
            this.TextBox_InputInfix.Size = new System.Drawing.Size(700, 30);
            this.TextBox_InputInfix.TabIndex = 1;
            this.TextBox_InputInfix.TextChanged += new System.EventHandler(this.TextBox_InputInfix_TextChanged);
            // 
            // TextBox_InputRPN
            // 
            this.TextBox_InputRPN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_InputRPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_InputRPN.Location = new System.Drawing.Point(30, 140);
            this.TextBox_InputRPN.Name = "TextBox_InputRPN";
            this.TextBox_InputRPN.ReadOnly = true;
            this.TextBox_InputRPN.Size = new System.Drawing.Size(700, 30);
            this.TextBox_InputRPN.TabIndex = 3;
            // 
            // Label_InputRPN
            // 
            this.Label_InputRPN.AutoSize = true;
            this.Label_InputRPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_InputRPN.Location = new System.Drawing.Point(50, 120);
            this.Label_InputRPN.Name = "Label_InputRPN";
            this.Label_InputRPN.Size = new System.Drawing.Size(121, 17);
            this.Label_InputRPN.TabIndex = 2;
            this.Label_InputRPN.Text = "Polish notation:";
            // 
            // TextBox_Output
            // 
            this.TextBox_Output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Output.Location = new System.Drawing.Point(30, 280);
            this.TextBox_Output.Name = "TextBox_Output";
            this.TextBox_Output.ReadOnly = true;
            this.TextBox_Output.Size = new System.Drawing.Size(700, 30);
            this.TextBox_Output.TabIndex = 5;
            // 
            // Label_Output
            // 
            this.Label_Output.AutoSize = true;
            this.Label_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Output.Location = new System.Drawing.Point(50, 260);
            this.Label_Output.Name = "Label_Output";
            this.Label_Output.Size = new System.Drawing.Size(62, 17);
            this.Label_Output.TabIndex = 4;
            this.Label_Output.Text = "Output:";
            // 
            // Label_VarList
            // 
            this.Label_VarList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_VarList.AutoSize = true;
            this.Label_VarList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_VarList.Location = new System.Drawing.Point(770, 50);
            this.Label_VarList.Name = "Label_VarList";
            this.Label_VarList.Size = new System.Drawing.Size(81, 17);
            this.Label_VarList.TabIndex = 7;
            this.Label_VarList.Text = "Variables:";
            // 
            // DataGridView_VarList
            // 
            this.DataGridView_VarList.AllowUserToAddRows = false;
            this.DataGridView_VarList.AllowUserToDeleteRows = false;
            this.DataGridView_VarList.AllowUserToResizeRows = false;
            this.DataGridView_VarList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_VarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_VarList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Name,
            this.Col_Value});
            this.DataGridView_VarList.Location = new System.Drawing.Point(750, 70);
            this.DataGridView_VarList.MultiSelect = false;
            this.DataGridView_VarList.Name = "DataGridView_VarList";
            this.DataGridView_VarList.RowHeadersVisible = false;
            this.DataGridView_VarList.RowHeadersWidth = 51;
            this.DataGridView_VarList.RowTemplate.Height = 24;
            this.DataGridView_VarList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_VarList.Size = new System.Drawing.Size(300, 410);
            this.DataGridView_VarList.TabIndex = 8;
            this.DataGridView_VarList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_VarList_CellDoubleClick);
            this.DataGridView_VarList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_VarList_CellValueChanged);
            this.DataGridView_VarList.SelectionChanged += new System.EventHandler(this.DataGridView_VarList_SelectionChanged);
            // 
            // Col_Name
            // 
            this.Col_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Col_Name.DefaultCellStyle = dataGridViewCellStyle7;
            this.Col_Name.Frozen = true;
            this.Col_Name.HeaderText = "Name";
            this.Col_Name.MinimumWidth = 50;
            this.Col_Name.Name = "Col_Name";
            this.Col_Name.ReadOnly = true;
            this.Col_Name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Col_Name.Width = 50;
            // 
            // Col_Value
            // 
            this.Col_Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Col_Value.DefaultCellStyle = dataGridViewCellStyle8;
            this.Col_Value.Frozen = true;
            this.Col_Value.HeaderText = "Value";
            this.Col_Value.MinimumWidth = 150;
            this.Col_Value.Name = "Col_Value";
            this.Col_Value.ReadOnly = true;
            this.Col_Value.Width = 197;
            // 
            // TextBox_VarToChange
            // 
            this.TextBox_VarToChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_VarToChange.Enabled = false;
            this.TextBox_VarToChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_VarToChange.Location = new System.Drawing.Point(790, 500);
            this.TextBox_VarToChange.Name = "TextBox_VarToChange";
            this.TextBox_VarToChange.Size = new System.Drawing.Size(260, 30);
            this.TextBox_VarToChange.TabIndex = 10;
            this.TextBox_VarToChange.TextChanged += new System.EventHandler(this.TextBox_VarToChange_TextChanged);
            // 
            // Label_VarToChange
            // 
            this.Label_VarToChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_VarToChange.AutoSize = true;
            this.Label_VarToChange.Enabled = false;
            this.Label_VarToChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_VarToChange.Location = new System.Drawing.Point(750, 500);
            this.Label_VarToChange.Name = "Label_VarToChange";
            this.Label_VarToChange.Size = new System.Drawing.Size(28, 29);
            this.Label_VarToChange.TabIndex = 9;
            this.Label_VarToChange.Text = "#";
            // 
            // Label_Unknown
            // 
            this.Label_Unknown.AutoSize = true;
            this.Label_Unknown.Enabled = false;
            this.Label_Unknown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Unknown.Location = new System.Drawing.Point(50, 195);
            this.Label_Unknown.Name = "Label_Unknown";
            this.Label_Unknown.Size = new System.Drawing.Size(78, 17);
            this.Label_Unknown.TabIndex = 11;
            this.Label_Unknown.Text = "Unknown:";
            // 
            // ComboBox_Unkown
            // 
            this.ComboBox_Unkown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Unkown.Enabled = false;
            this.ComboBox_Unkown.FormattingEnabled = true;
            this.ComboBox_Unkown.Location = new System.Drawing.Point(150, 190);
            this.ComboBox_Unkown.Name = "ComboBox_Unkown";
            this.ComboBox_Unkown.Size = new System.Drawing.Size(50, 24);
            this.ComboBox_Unkown.TabIndex = 12;
            this.ComboBox_Unkown.TextChanged += new System.EventHandler(this.ComboBox_Unkown_TextChanged);
            // 
            // Button_RetryOutput
            // 
            this.Button_RetryOutput.Location = new System.Drawing.Point(660, 317);
            this.Button_RetryOutput.Name = "Button_RetryOutput";
            this.Button_RetryOutput.Size = new System.Drawing.Size(60, 30);
            this.Button_RetryOutput.TabIndex = 13;
            this.Button_RetryOutput.Text = "Retry";
            this.Button_RetryOutput.UseVisualStyleBackColor = true;
            this.Button_RetryOutput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button_RetryOutput_MouseClick);
            // 
            // TextBox_Range
            // 
            this.TextBox_Range.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Range.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Range.Location = new System.Drawing.Point(30, 438);
            this.TextBox_Range.Name = "TextBox_Range";
            this.TextBox_Range.Size = new System.Drawing.Size(200, 30);
            this.TextBox_Range.TabIndex = 15;
            this.TextBox_Range.Text = "1000000";
            this.TextBox_Range.TextChanged += new System.EventHandler(this.TextBox_Range_TextChanged);
            // 
            // Label_Step
            // 
            this.Label_Step.AutoSize = true;
            this.Label_Step.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Step.Location = new System.Drawing.Point(270, 418);
            this.Label_Step.Name = "Label_Step";
            this.Label_Step.Size = new System.Drawing.Size(54, 17);
            this.Label_Step.TabIndex = 14;
            this.Label_Step.Text = "Steps:";
            // 
            // TextBox_Step
            // 
            this.TextBox_Step.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Step.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Step.Location = new System.Drawing.Point(250, 438);
            this.TextBox_Step.Name = "TextBox_Step";
            this.TextBox_Step.Size = new System.Drawing.Size(200, 30);
            this.TextBox_Step.TabIndex = 17;
            this.TextBox_Step.Text = "100";
            this.TextBox_Step.TextChanged += new System.EventHandler(this.TextBox_Step_TextChanged);
            // 
            // Label_Range
            // 
            this.Label_Range.AutoSize = true;
            this.Label_Range.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Range.Location = new System.Drawing.Point(50, 418);
            this.Label_Range.Name = "Label_Range";
            this.Label_Range.Size = new System.Drawing.Size(60, 17);
            this.Label_Range.TabIndex = 16;
            this.Label_Range.Text = "Range:";
            // 
            // TextBox_Epsilon
            // 
            this.TextBox_Epsilon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Epsilon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Epsilon.Location = new System.Drawing.Point(470, 438);
            this.TextBox_Epsilon.Name = "TextBox_Epsilon";
            this.TextBox_Epsilon.Size = new System.Drawing.Size(200, 30);
            this.TextBox_Epsilon.TabIndex = 19;
            this.TextBox_Epsilon.Text = "0.000000001";
            this.TextBox_Epsilon.TextChanged += new System.EventHandler(this.TextBox_Epsilon_TextChanged);
            // 
            // Label_Epsilon
            // 
            this.Label_Epsilon.AutoSize = true;
            this.Label_Epsilon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Epsilon.Location = new System.Drawing.Point(490, 418);
            this.Label_Epsilon.Name = "Label_Epsilon";
            this.Label_Epsilon.Size = new System.Drawing.Size(66, 17);
            this.Label_Epsilon.TabIndex = 18;
            this.Label_Epsilon.Text = "Epsilon:";
            // 
            // Label_Intervals
            // 
            this.Label_Intervals.AutoSize = true;
            this.Label_Intervals.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Intervals.Location = new System.Drawing.Point(50, 488);
            this.Label_Intervals.Name = "Label_Intervals";
            this.Label_Intervals.Size = new System.Drawing.Size(75, 17);
            this.Label_Intervals.TabIndex = 21;
            this.Label_Intervals.Text = "Intervals:";
            // 
            // TextBox_Intervals
            // 
            this.TextBox_Intervals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Intervals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Intervals.Location = new System.Drawing.Point(30, 508);
            this.TextBox_Intervals.Name = "TextBox_Intervals";
            this.TextBox_Intervals.Size = new System.Drawing.Size(200, 30);
            this.TextBox_Intervals.TabIndex = 20;
            this.TextBox_Intervals.Text = "100";
            this.TextBox_Intervals.TextChanged += new System.EventHandler(this.TextBox_Intervals_TextChanged);
            // 
            // Button_Next
            // 
            this.Button_Next.Location = new System.Drawing.Point(580, 317);
            this.Button_Next.Name = "Button_Next";
            this.Button_Next.Size = new System.Drawing.Size(60, 30);
            this.Button_Next.TabIndex = 22;
            this.Button_Next.Text = "Next";
            this.Button_Next.UseVisualStyleBackColor = true;
            this.Button_Next.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button_Next_MouseClick);
            // 
            // Button_Prev
            // 
            this.Button_Prev.Location = new System.Drawing.Point(500, 317);
            this.Button_Prev.Name = "Button_Prev";
            this.Button_Prev.Size = new System.Drawing.Size(60, 30);
            this.Button_Prev.TabIndex = 23;
            this.Button_Prev.Text = "Prev";
            this.Button_Prev.UseVisualStyleBackColor = true;
            this.Button_Prev.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button_Prev_MouseClick);
            // 
            // TextBox_Error
            // 
            this.TextBox_Error.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Error.Enabled = false;
            this.TextBox_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Error.Location = new System.Drawing.Point(110, 315);
            this.TextBox_Error.Name = "TextBox_Error";
            this.TextBox_Error.ReadOnly = true;
            this.TextBox_Error.Size = new System.Drawing.Size(300, 30);
            this.TextBox_Error.TabIndex = 24;
            // 
            // Label_Error
            // 
            this.Label_Error.AutoSize = true;
            this.Label_Error.Enabled = false;
            this.Label_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Error.Location = new System.Drawing.Point(50, 320);
            this.Label_Error.Name = "Label_Error";
            this.Label_Error.Size = new System.Drawing.Size(50, 17);
            this.Label_Error.TabIndex = 25;
            this.Label_Error.Text = "Error:";
            // 
            // TextBox_Precision
            // 
            this.TextBox_Precision.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Precision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Precision.Location = new System.Drawing.Point(250, 508);
            this.TextBox_Precision.Name = "TextBox_Precision";
            this.TextBox_Precision.Size = new System.Drawing.Size(200, 30);
            this.TextBox_Precision.TabIndex = 27;
            this.TextBox_Precision.Text = "6";
            this.TextBox_Precision.TextChanged += new System.EventHandler(this.TextBox_Precision_TextChanged);
            // 
            // Label_Precision
            // 
            this.Label_Precision.AutoSize = true;
            this.Label_Precision.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Precision.Location = new System.Drawing.Point(270, 488);
            this.Label_Precision.Name = "Label_Precision";
            this.Label_Precision.Size = new System.Drawing.Size(80, 17);
            this.Label_Precision.TabIndex = 26;
            this.Label_Precision.Text = "Precision:";
            // 
            // MainUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.TextBox_Precision);
            this.Controls.Add(this.Label_Precision);
            this.Controls.Add(this.Label_Error);
            this.Controls.Add(this.TextBox_Error);
            this.Controls.Add(this.Button_Prev);
            this.Controls.Add(this.Button_Next);
            this.Controls.Add(this.Label_Intervals);
            this.Controls.Add(this.TextBox_Intervals);
            this.Controls.Add(this.TextBox_Epsilon);
            this.Controls.Add(this.Label_Epsilon);
            this.Controls.Add(this.TextBox_Step);
            this.Controls.Add(this.Label_Range);
            this.Controls.Add(this.TextBox_Range);
            this.Controls.Add(this.Label_Step);
            this.Controls.Add(this.Button_RetryOutput);
            this.Controls.Add(this.ComboBox_Unkown);
            this.Controls.Add(this.Label_Unknown);
            this.Controls.Add(this.TextBox_VarToChange);
            this.Controls.Add(this.Label_VarToChange);
            this.Controls.Add(this.DataGridView_VarList);
            this.Controls.Add(this.Label_VarList);
            this.Controls.Add(this.TextBox_Output);
            this.Controls.Add(this.Label_Output);
            this.Controls.Add(this.TextBox_InputRPN);
            this.Controls.Add(this.Label_InputRPN);
            this.Controls.Add(this.TextBox_InputInfix);
            this.Controls.Add(this.Label_InputInfix);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainUserForm";
            this.Text = "Equation Solver (© CuteTN)";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_VarList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_InputInfix;
        private System.Windows.Forms.TextBox TextBox_InputInfix;
        private System.Windows.Forms.TextBox TextBox_InputRPN;
        private System.Windows.Forms.Label Label_InputRPN;
        private System.Windows.Forms.TextBox TextBox_Output;
        private System.Windows.Forms.Label Label_Output;
        private System.Windows.Forms.Label Label_VarList;
        private System.Windows.Forms.DataGridView DataGridView_VarList;
        private System.Windows.Forms.TextBox TextBox_VarToChange;
        private System.Windows.Forms.Label Label_VarToChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Value;
        private System.Windows.Forms.Label Label_Unknown;
        private System.Windows.Forms.ComboBox ComboBox_Unkown;
        private System.Windows.Forms.Button Button_RetryOutput;
        private System.Windows.Forms.TextBox TextBox_Range;
        private System.Windows.Forms.Label Label_Step;
        private System.Windows.Forms.TextBox TextBox_Step;
        private System.Windows.Forms.Label Label_Range;
        private System.Windows.Forms.TextBox TextBox_Epsilon;
        private System.Windows.Forms.Label Label_Epsilon;
        private System.Windows.Forms.Label Label_Intervals;
        private System.Windows.Forms.TextBox TextBox_Intervals;
        private System.Windows.Forms.Button Button_Next;
        private System.Windows.Forms.Button Button_Prev;
        private System.Windows.Forms.TextBox TextBox_Error;
        private System.Windows.Forms.Label Label_Error;
        private System.Windows.Forms.TextBox TextBox_Precision;
        private System.Windows.Forms.Label Label_Precision;
    }
}

