namespace A_Day_at_the_Races
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.RbAl = new System.Windows.Forms.RadioButton();
            this.RbBob = new System.Windows.Forms.RadioButton();
            this.RbJoe = new System.Windows.Forms.RadioButton();
            this.lb2 = new System.Windows.Forms.Label();
            this.lbBets = new System.Windows.Forms.Label();
            this.lbMaxbet = new System.Windows.Forms.Label();
            this.txtbAl = new System.Windows.Forms.TextBox();
            this.txtbBob = new System.Windows.Forms.TextBox();
            this.txtbJoe = new System.Windows.Forms.TextBox();
            this.NumericUpDownDogNum = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownCashBet = new System.Windows.Forms.NumericUpDown();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRace = new System.Windows.Forms.Button();
            this.btnPlaceBet = new System.Windows.Forms.Button();
            this.Pb1 = new System.Windows.Forms.PictureBox();
            this.Pb2 = new System.Windows.Forms.PictureBox();
            this.Pb3 = new System.Windows.Forms.PictureBox();
            this.Pb4 = new System.Windows.Forms.PictureBox();
            this.PbFinishLine = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Kappa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownDogNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownCashBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbFinishLine)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.RbAl);
            this.Panel1.Controls.Add(this.RbBob);
            this.Panel1.Controls.Add(this.RbJoe);
            this.Panel1.Controls.Add(this.lb2);
            this.Panel1.Controls.Add(this.lbBets);
            this.Panel1.Controls.Add(this.lbMaxbet);
            this.Panel1.Controls.Add(this.txtbAl);
            this.Panel1.Controls.Add(this.txtbBob);
            this.Panel1.Controls.Add(this.txtbJoe);
            this.Panel1.Controls.Add(this.NumericUpDownDogNum);
            this.Panel1.Controls.Add(this.NumericUpDownCashBet);
            this.Panel1.Controls.Add(this.btnReset);
            this.Panel1.Controls.Add(this.btnRace);
            this.Panel1.Controls.Add(this.btnPlaceBet);
            this.Panel1.Location = new System.Drawing.Point(12, 189);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(324, 360);
            this.Panel1.TabIndex = 0;
            // 
            // RbAl
            // 
            this.RbAl.AutoSize = true;
            this.RbAl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbAl.Location = new System.Drawing.Point(3, 68);
            this.RbAl.Name = "RbAl";
            this.RbAl.Size = new System.Drawing.Size(36, 19);
            this.RbAl.TabIndex = 9;
            this.RbAl.TabStop = true;
            this.RbAl.Text = "Al";
            this.RbAl.UseVisualStyleBackColor = true;
            this.RbAl.CheckedChanged += new System.EventHandler(this.AllRadioBtns);
            // 
            // RbBob
            // 
            this.RbBob.AutoSize = true;
            this.RbBob.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbBob.Location = new System.Drawing.Point(3, 41);
            this.RbBob.Name = "RbBob";
            this.RbBob.Size = new System.Drawing.Size(46, 19);
            this.RbBob.TabIndex = 9;
            this.RbBob.TabStop = true;
            this.RbBob.Text = "Bob";
            this.RbBob.UseVisualStyleBackColor = true;
            this.RbBob.CheckedChanged += new System.EventHandler(this.AllRadioBtns);
            // 
            // RbJoe
            // 
            this.RbJoe.AutoSize = true;
            this.RbJoe.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbJoe.Location = new System.Drawing.Point(3, 16);
            this.RbJoe.Name = "RbJoe";
            this.RbJoe.Size = new System.Drawing.Size(43, 19);
            this.RbJoe.TabIndex = 9;
            this.RbJoe.TabStop = true;
            this.RbJoe.Text = "Joe";
            this.RbJoe.UseVisualStyleBackColor = true;
            this.RbJoe.CheckedChanged += new System.EventHandler(this.AllRadioBtns);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(125, 108);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(56, 15);
            this.lb2.TabIndex = 8;
            this.lb2.Text = "On Dog #";
            // 
            // lbBets
            // 
            this.lbBets.AutoSize = true;
            this.lbBets.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBets.Location = new System.Drawing.Point(24, 108);
            this.lbBets.Name = "lbBets";
            this.lbBets.Size = new System.Drawing.Size(31, 15);
            this.lbBets.TabIndex = 7;
            this.lbBets.Text = "Bets";
            // 
            // lbMaxbet
            // 
            this.lbMaxbet.AutoSize = true;
            this.lbMaxbet.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaxbet.Location = new System.Drawing.Point(69, 23);
            this.lbMaxbet.Name = "lbMaxbet";
            this.lbMaxbet.Size = new System.Drawing.Size(52, 15);
            this.lbMaxbet.TabIndex = 6;
            this.lbMaxbet.Text = "Max bet";
            // 
            // txtbAl
            // 
            this.txtbAl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbAl.Location = new System.Drawing.Point(148, 68);
            this.txtbAl.Name = "txtbAl";
            this.txtbAl.ReadOnly = true;
            this.txtbAl.Size = new System.Drawing.Size(171, 21);
            this.txtbAl.TabIndex = 4;
            // 
            // txtbBob
            // 
            this.txtbBob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbBob.Location = new System.Drawing.Point(148, 42);
            this.txtbBob.Name = "txtbBob";
            this.txtbBob.ReadOnly = true;
            this.txtbBob.Size = new System.Drawing.Size(171, 21);
            this.txtbBob.TabIndex = 4;
            // 
            // txtbJoe
            // 
            this.txtbJoe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbJoe.Location = new System.Drawing.Point(148, 16);
            this.txtbJoe.Name = "txtbJoe";
            this.txtbJoe.ReadOnly = true;
            this.txtbJoe.Size = new System.Drawing.Size(171, 21);
            this.txtbJoe.TabIndex = 4;
            // 
            // NumericUpDownDogNum
            // 
            this.NumericUpDownDogNum.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDownDogNum.Location = new System.Drawing.Point(183, 104);
            this.NumericUpDownDogNum.Name = "NumericUpDownDogNum";
            this.NumericUpDownDogNum.Size = new System.Drawing.Size(47, 23);
            this.NumericUpDownDogNum.TabIndex = 3;
            // 
            // NumericUpDownCashBet
            // 
            this.NumericUpDownCashBet.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDownCashBet.Location = new System.Drawing.Point(58, 104);
            this.NumericUpDownCashBet.Name = "NumericUpDownCashBet";
            this.NumericUpDownCashBet.Size = new System.Drawing.Size(47, 23);
            this.NumericUpDownCashBet.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(223, 177);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(97, 28);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRace
            // 
            this.btnRace.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRace.Location = new System.Drawing.Point(127, 177);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(97, 28);
            this.btnRace.TabIndex = 1;
            this.btnRace.Text = "Race";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // btnPlaceBet
            // 
            this.btnPlaceBet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceBet.Location = new System.Drawing.Point(7, 136);
            this.btnPlaceBet.Name = "btnPlaceBet";
            this.btnPlaceBet.Size = new System.Drawing.Size(223, 28);
            this.btnPlaceBet.TabIndex = 0;
            this.btnPlaceBet.Text = "Place Bet";
            this.btnPlaceBet.UseVisualStyleBackColor = true;
            this.btnPlaceBet.Click += new System.EventHandler(this.btnPlaceBet_Click);
            // 
            // Pb1
            // 
            this.Pb1.BackColor = System.Drawing.Color.NavajoWhite;
            this.Pb1.Image = global::A_Day_at_the_Races.ResourceFile.Kappa;
            this.Pb1.Location = new System.Drawing.Point(8, 3);
            this.Pb1.Name = "Pb1";
            this.Pb1.Size = new System.Drawing.Size(120, 124);
            this.Pb1.TabIndex = 1;
            this.Pb1.TabStop = false;
            // 
            // Pb2
            // 
            this.Pb2.BackColor = System.Drawing.Color.NavajoWhite;
            this.Pb2.Image = global::A_Day_at_the_Races.ResourceFile.KappaPride;
            this.Pb2.Location = new System.Drawing.Point(134, 3);
            this.Pb2.Name = "Pb2";
            this.Pb2.Size = new System.Drawing.Size(120, 124);
            this.Pb2.TabIndex = 2;
            this.Pb2.TabStop = false;
            // 
            // Pb3
            // 
            this.Pb3.BackColor = System.Drawing.Color.NavajoWhite;
            this.Pb3.Image = global::A_Day_at_the_Races.ResourceFile.KappaSwag;
            this.Pb3.Location = new System.Drawing.Point(260, 3);
            this.Pb3.Name = "Pb3";
            this.Pb3.Size = new System.Drawing.Size(120, 124);
            this.Pb3.TabIndex = 3;
            this.Pb3.TabStop = false;
            // 
            // Pb4
            // 
            this.Pb4.BackColor = System.Drawing.Color.NavajoWhite;
            this.Pb4.Image = global::A_Day_at_the_Races.ResourceFile.GoldenKappa;
            this.Pb4.Location = new System.Drawing.Point(386, 3);
            this.Pb4.Name = "Pb4";
            this.Pb4.Size = new System.Drawing.Size(120, 124);
            this.Pb4.TabIndex = 4;
            this.Pb4.TabStop = false;
            // 
            // PbFinishLine
            // 
            this.PbFinishLine.BackColor = System.Drawing.Color.Transparent;
            this.PbFinishLine.Image = global::A_Day_at_the_Races.ResourceFile.FinishLine;
            this.PbFinishLine.Location = new System.Drawing.Point(0, 486);
            this.PbFinishLine.Name = "PbFinishLine";
            this.PbFinishLine.Size = new System.Drawing.Size(527, 76);
            this.PbFinishLine.TabIndex = 5;
            this.PbFinishLine.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.Pb4);
            this.panel2.Controls.Add(this.Pb3);
            this.panel2.Controls.Add(this.Pb2);
            this.panel2.Controls.Add(this.Pb1);
            this.panel2.Controls.Add(this.PbFinishLine);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(342, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 562);
            this.panel2.TabIndex = 6;
            // 
            // Kappa
            // 
            this.Kappa.AutoSize = true;
            this.Kappa.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kappa.Location = new System.Drawing.Point(12, 16);
            this.Kappa.Name = "Kappa";
            this.Kappa.Size = new System.Drawing.Size(199, 78);
            this.Kappa.TabIndex = 7;
            this.Kappa.Text = "Kappa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 78);
            this.label1.TabIndex = 7;
            this.label1.Text = "Race";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(335, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 562);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(0, 180);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(344, 10);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel5.Location = new System.Drawing.Point(3, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(125, 562);
            this.panel5.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel6.Location = new System.Drawing.Point(134, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(120, 565);
            this.panel6.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel7.Location = new System.Drawing.Point(260, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(120, 562);
            this.panel7.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel8.Location = new System.Drawing.Point(386, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(128, 565);
            this.panel8.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(868, 561);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kappa);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kappa Race";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownDogNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownCashBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbFinishLine)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.Button btnPlaceBet;
        private System.Windows.Forms.NumericUpDown NumericUpDownCashBet;
        private System.Windows.Forms.TextBox txtbAl;
        private System.Windows.Forms.TextBox txtbBob;
        private System.Windows.Forms.TextBox txtbJoe;
        private System.Windows.Forms.NumericUpDown NumericUpDownDogNum;
        private System.Windows.Forms.Label lbMaxbet;
        private System.Windows.Forms.PictureBox Pb1;
        private System.Windows.Forms.PictureBox Pb2;
        private System.Windows.Forms.PictureBox Pb3;
        private System.Windows.Forms.PictureBox Pb4;
        private System.Windows.Forms.PictureBox PbFinishLine;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lbBets;
        private System.Windows.Forms.RadioButton RbAl;
        private System.Windows.Forms.RadioButton RbBob;
        private System.Windows.Forms.RadioButton RbJoe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Kappa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
    }
}

