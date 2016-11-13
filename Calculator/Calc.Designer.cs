namespace Calculator
{
    partial class Calc
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
            this.adding = new System.Windows.Forms.Button();
            this.etykieta1 = new System.Windows.Forms.Label();
            this.value1 = new System.Windows.Forms.TextBox();
            this.value2 = new System.Windows.Forms.TextBox();
            this.subtraction = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.power = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.TextBox();
            this.valueToRoot = new System.Windows.Forms.TextBox();
            this.floatResult = new System.Windows.Forms.RadioButton();
            this.fractionResult = new System.Windows.Forms.RadioButton();
            this.root = new System.Windows.Forms.Button();
            this.closing = new System.Windows.Forms.Button();
            this.clearingHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adding
            // 
            this.adding.Location = new System.Drawing.Point(191, 156);
            this.adding.Name = "adding";
            this.adding.Size = new System.Drawing.Size(20, 20);
            this.adding.TabIndex = 0;
            this.adding.Text = "+";
            this.adding.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.adding.UseVisualStyleBackColor = true;
            this.adding.Click += new System.EventHandler(this.adding_Click);
            // 
            // etykieta1
            // 
            this.etykieta1.AutoSize = true;
            this.etykieta1.Location = new System.Drawing.Point(3, 156);
            this.etykieta1.Name = "etykieta1";
            this.etykieta1.Size = new System.Drawing.Size(76, 13);
            this.etykieta1.TabIndex = 1;
            this.etykieta1.Text = "Podaj wartości";
            // 
            // value1
            // 
            this.value1.Location = new System.Drawing.Point(85, 141);
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(100, 20);
            this.value1.TabIndex = 2;
            // 
            // value2
            // 
            this.value2.Location = new System.Drawing.Point(85, 167);
            this.value2.Name = "value2";
            this.value2.Size = new System.Drawing.Size(100, 20);
            this.value2.TabIndex = 3;
            // 
            // subtraction
            // 
            this.subtraction.Location = new System.Drawing.Point(217, 156);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(20, 20);
            this.subtraction.TabIndex = 4;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.subtraction_Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(243, 156);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(20, 20);
            this.division.TabIndex = 5;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(269, 156);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(20, 20);
            this.multiplication.TabIndex = 6;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // power
            // 
            this.power.Location = new System.Drawing.Point(295, 156);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(20, 20);
            this.power.TabIndex = 8;
            this.power.Text = "^";
            this.power.UseVisualStyleBackColor = true;
            this.power.Click += new System.EventHandler(this.power_Click);
            // 
            // history
            // 
            this.history.Location = new System.Drawing.Point(85, 12);
            this.history.Multiline = true;
            this.history.Name = "history";
            this.history.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.history.Size = new System.Drawing.Size(230, 95);
            this.history.TabIndex = 12;
            // 
            // valueToRoot
            // 
            this.valueToRoot.Location = new System.Drawing.Point(85, 240);
            this.valueToRoot.Name = "valueToRoot";
            this.valueToRoot.Size = new System.Drawing.Size(100, 20);
            this.valueToRoot.TabIndex = 13;
            // 
            // floatResult
            // 
            this.floatResult.AutoSize = true;
            this.floatResult.Location = new System.Drawing.Point(191, 183);
            this.floatResult.Name = "floatResult";
            this.floatResult.Size = new System.Drawing.Size(45, 17);
            this.floatResult.TabIndex = 14;
            this.floatResult.Text = "float";
            this.floatResult.UseVisualStyleBackColor = true;
            // 
            // fractionResult
            // 
            this.fractionResult.AutoSize = true;
            this.fractionResult.Checked = true;
            this.fractionResult.Location = new System.Drawing.Point(191, 207);
            this.fractionResult.Name = "fractionResult";
            this.fractionResult.Size = new System.Drawing.Size(60, 17);
            this.fractionResult.TabIndex = 15;
            this.fractionResult.TabStop = true;
            this.fractionResult.Text = "fraction";
            this.fractionResult.UseVisualStyleBackColor = true;
            // 
            // root
            // 
            this.root.Location = new System.Drawing.Point(192, 238);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(44, 23);
            this.root.TabIndex = 16;
            this.root.Text = "sqrt";
            this.root.UseVisualStyleBackColor = true;
            this.root.Click += new System.EventHandler(this.root_Click);
            // 
            // closing
            // 
            this.closing.Location = new System.Drawing.Point(239, 282);
            this.closing.Name = "closing";
            this.closing.Size = new System.Drawing.Size(75, 23);
            this.closing.TabIndex = 17;
            this.closing.Text = "Zamknij";
            this.closing.UseVisualStyleBackColor = true;
            this.closing.Click += new System.EventHandler(this.closing_Click);
            // 
            // clearingHistory
            // 
            this.clearingHistory.Enabled = false;
            this.clearingHistory.Location = new System.Drawing.Point(218, 113);
            this.clearingHistory.Name = "clearingHistory";
            this.clearingHistory.Size = new System.Drawing.Size(97, 23);
            this.clearingHistory.TabIndex = 18;
            this.clearingHistory.Text = "Wyczyść historię";
            this.clearingHistory.UseVisualStyleBackColor = true;
            this.clearingHistory.Click += new System.EventHandler(this.clearingHistory_Click);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 317);
            this.Controls.Add(this.clearingHistory);
            this.Controls.Add(this.closing);
            this.Controls.Add(this.root);
            this.Controls.Add(this.fractionResult);
            this.Controls.Add(this.floatResult);
            this.Controls.Add(this.valueToRoot);
            this.Controls.Add(this.history);
            this.Controls.Add(this.power);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.division);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.value2);
            this.Controls.Add(this.value1);
            this.Controls.Add(this.etykieta1);
            this.Controls.Add(this.adding);
            this.Name = "Calc";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adding;
        private System.Windows.Forms.Label etykieta1;
        private System.Windows.Forms.TextBox value1;
        private System.Windows.Forms.TextBox value2;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button power;
        private System.Windows.Forms.TextBox history;
        private System.Windows.Forms.TextBox valueToRoot;
        private System.Windows.Forms.RadioButton floatResult;
        private System.Windows.Forms.RadioButton fractionResult;
        private System.Windows.Forms.Button root;
        private System.Windows.Forms.Button closing;
        private System.Windows.Forms.Button clearingHistory;
    }
}

