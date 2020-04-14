namespace MathUsing
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
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnLog10 = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnAbs = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirstNumber.Location = new System.Drawing.Point(180, 28);
            this.txtFirstNumber.Multiline = true;
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(156, 29);
            this.txtFirstNumber.TabIndex = 0;
            this.txtFirstNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFirstNumber_KeyPress_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Number";
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSecondNumber.Location = new System.Drawing.Point(180, 88);
            this.txtSecondNumber.Multiline = true;
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(156, 29);
            this.txtSecondNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(40, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Second Number";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtResult.Location = new System.Drawing.Point(180, 153);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(156, 29);
            this.txtResult.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(40, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Result";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCopy);
            this.panel1.Controls.Add(this.btnLog10);
            this.panel1.Controls.Add(this.btnTan);
            this.panel1.Controls.Add(this.btnAbs);
            this.panel1.Controls.Add(this.btnLog);
            this.panel1.Controls.Add(this.btnCos);
            this.panel1.Controls.Add(this.btnMax);
            this.panel1.Controls.Add(this.btnSqrt);
            this.panel1.Controls.Add(this.btnSin);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnExp);
            this.panel1.Controls.Add(this.btnPow);
            this.panel1.Controls.Add(this.btnSign);
            this.panel1.Controls.Add(this.btnC);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(352, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 266);
            this.panel1.TabIndex = 4;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(111, 155);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(119, 42);
            this.btnCopy.TabIndex = 13;
            this.btnCopy.Text = "Copy to First Number";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // btnLog10
            // 
            this.btnLog10.Location = new System.Drawing.Point(180, 107);
            this.btnLog10.Name = "btnLog10";
            this.btnLog10.Size = new System.Drawing.Size(50, 42);
            this.btnLog10.TabIndex = 11;
            this.btnLog10.Text = "Log 10";
            this.btnLog10.UseVisualStyleBackColor = true;
            this.btnLog10.Click += new System.EventHandler(this.BtnLog10_Click);
            // 
            // btnTan
            // 
            this.btnTan.Location = new System.Drawing.Point(180, 59);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(50, 42);
            this.btnTan.TabIndex = 7;
            this.btnTan.Text = "Tan";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.BtnTan_Click);
            // 
            // btnAbs
            // 
            this.btnAbs.Location = new System.Drawing.Point(180, 11);
            this.btnAbs.Name = "btnAbs";
            this.btnAbs.Size = new System.Drawing.Size(50, 42);
            this.btnAbs.TabIndex = 3;
            this.btnAbs.Text = "Abs";
            this.btnAbs.UseVisualStyleBackColor = true;
            this.btnAbs.Click += new System.EventHandler(this.BtnAbs_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(124, 107);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(50, 42);
            this.btnLog.TabIndex = 10;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.BtnLog_Click);
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(124, 59);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(50, 42);
            this.btnCos.TabIndex = 6;
            this.btnCos.Text = "Cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.BtnCos_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(124, 11);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(50, 42);
            this.btnMax.TabIndex = 2;
            this.btnMax.Text = "Max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Location = new System.Drawing.Point(68, 107);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(50, 42);
            this.btnSqrt.TabIndex = 9;
            this.btnSqrt.Text = "sqrt";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.BtnSqrt_Click);
            // 
            // btnSin
            // 
            this.btnSin.Location = new System.Drawing.Point(68, 59);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(50, 42);
            this.btnSin.TabIndex = 5;
            this.btnSin.Text = "Sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.BtnSin_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(68, 11);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(50, 42);
            this.btnMin.TabIndex = 1;
            this.btnMin.Text = "Min";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // btnExp
            // 
            this.btnExp.Location = new System.Drawing.Point(12, 155);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(50, 42);
            this.btnExp.TabIndex = 12;
            this.btnExp.Text = "Exp";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.BtnExp_Click);
            // 
            // btnPow
            // 
            this.btnPow.Location = new System.Drawing.Point(12, 107);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(50, 42);
            this.btnPow.TabIndex = 8;
            this.btnPow.Text = "Pow";
            this.btnPow.UseVisualStyleBackColor = true;
            this.btnPow.Click += new System.EventHandler(this.BtnPow_Click);
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(12, 59);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(50, 42);
            this.btnSign.TabIndex = 4;
            this.btnSign.Text = "Sign";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.BtnSign_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(12, 11);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(50, 42);
            this.btnC.TabIndex = 0;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 355);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSecondNumber);
            this.Controls.Add(this.txtFirstNumber);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSecondNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnLog10;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnAbs;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnC;
    }
}

