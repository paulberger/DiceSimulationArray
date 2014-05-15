namespace Dice_Simulation
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
            this.lblInstructionsWrite = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Die1label = new System.Windows.Forms.Label();
            this.Die2label = new System.Windows.Forms.Label();
            this.lbxDie1 = new System.Windows.Forms.Label();
            this.lbxDie2 = new System.Windows.Forms.Label();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbxTotal = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rtbxResults = new System.Windows.Forms.RichTextBox();
            this.rtbxFrequency = new System.Windows.Forms.RichTextBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.btnFrequency = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInstructionsWrite
            // 
            this.lblInstructionsWrite.AutoSize = true;
            this.lblInstructionsWrite.Location = new System.Drawing.Point(11, 13);
            this.lblInstructionsWrite.Name = "lblInstructionsWrite";
            this.lblInstructionsWrite.Size = new System.Drawing.Size(342, 13);
            this.lblInstructionsWrite.TabIndex = 0;
            this.lblInstructionsWrite.Text = "Please click WRITE to run the simulation and add the results to the file.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please click READ to view the simulation results from the file.";
            // 
            // Die1label
            // 
            this.Die1label.AutoSize = true;
            this.Die1label.Location = new System.Drawing.Point(69, 74);
            this.Die1label.Name = "Die1label";
            this.Die1label.Size = new System.Drawing.Size(35, 13);
            this.Die1label.TabIndex = 2;
            this.Die1label.Text = "Die 1:";
            // 
            // Die2label
            // 
            this.Die2label.AutoSize = true;
            this.Die2label.Location = new System.Drawing.Point(260, 74);
            this.Die2label.Name = "Die2label";
            this.Die2label.Size = new System.Drawing.Size(35, 13);
            this.Die2label.TabIndex = 3;
            this.Die2label.Text = "Die 2:";
            // 
            // lbxDie1
            // 
            this.lbxDie1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxDie1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxDie1.Location = new System.Drawing.Point(46, 101);
            this.lbxDie1.Name = "lbxDie1";
            this.lbxDie1.Size = new System.Drawing.Size(80, 80);
            this.lbxDie1.TabIndex = 4;
            this.lbxDie1.Text = "1";
            this.lbxDie1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxDie2
            // 
            this.lbxDie2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxDie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxDie2.Location = new System.Drawing.Point(237, 101);
            this.lbxDie2.Name = "lbxDie2";
            this.lbxDie2.Size = new System.Drawing.Size(80, 80);
            this.lbxDie2.TabIndex = 5;
            this.lbxDie2.Text = "1";
            this.lbxDie2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(139, 81);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(87, 35);
            this.btnWrite.TabIndex = 0;
            this.btnWrite.Text = "ROLL THE DICE";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(139, 122);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(87, 35);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "ROLL RESULTS";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(40, 215);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(157, 33);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Dice Total";
            // 
            // lbxTotal
            // 
            this.lbxTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxTotal.Location = new System.Drawing.Point(203, 204);
            this.lbxTotal.Name = "lbxTotal";
            this.lbxTotal.Size = new System.Drawing.Size(114, 48);
            this.lbxTotal.TabIndex = 9;
            this.lbxTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(225, 322);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 29);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(226, 282);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 29);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rtbxResults
            // 
            this.rtbxResults.Location = new System.Drawing.Point(38, 282);
            this.rtbxResults.Name = "rtbxResults";
            this.rtbxResults.Size = new System.Drawing.Size(64, 69);
            this.rtbxResults.TabIndex = 12;
            this.rtbxResults.Text = "";
            // 
            // rtbxFrequency
            // 
            this.rtbxFrequency.Location = new System.Drawing.Point(108, 282);
            this.rtbxFrequency.Name = "rtbxFrequency";
            this.rtbxFrequency.Size = new System.Drawing.Size(112, 69);
            this.rtbxFrequency.TabIndex = 13;
            this.rtbxFrequency.Text = "";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(38, 263);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(64, 13);
            this.lblResults.TabIndex = 14;
            this.lblResults.Text = "RESULTS";
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrequency.Location = new System.Drawing.Point(123, 263);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(82, 13);
            this.lblFrequency.TabIndex = 15;
            this.lblFrequency.Text = "FREQUENCY";
            // 
            // btnFrequency
            // 
            this.btnFrequency.Location = new System.Drawing.Point(139, 163);
            this.btnFrequency.Name = "btnFrequency";
            this.btnFrequency.Size = new System.Drawing.Size(87, 35);
            this.btnFrequency.TabIndex = 16;
            this.btnFrequency.Text = "FREQUENCY OF TOTALS";
            this.btnFrequency.UseVisualStyleBackColor = true;
            this.btnFrequency.Click += new System.EventHandler(this.btnFrequency_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 365);
            this.Controls.Add(this.btnFrequency);
            this.Controls.Add(this.lblFrequency);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.rtbxFrequency);
            this.Controls.Add(this.rtbxResults);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbxTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.lbxDie2);
            this.Controls.Add(this.lbxDie1);
            this.Controls.Add(this.Die2label);
            this.Controls.Add(this.Die1label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInstructionsWrite);
            this.Name = "Form1";
            this.Text = "Dice Simulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructionsWrite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Die1label;
        private System.Windows.Forms.Label Die2label;
        private System.Windows.Forms.Label lbxDie1;
        private System.Windows.Forms.Label lbxDie2;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lbxTotal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox rtbxResults;
        private System.Windows.Forms.RichTextBox rtbxFrequency;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.Button btnFrequency;
    }
}

