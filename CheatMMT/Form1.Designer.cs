namespace CheatMMT
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
            this.txInput = new System.Windows.Forms.TextBox();
            this.btGet = new System.Windows.Forms.Button();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txKey = new System.Windows.Forms.TextBox();
            this.btSolve = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txRes = new System.Windows.Forms.TextBox();
            this.txResCheckSum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btCheckSum = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbRes = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txResHamming = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txInputHm = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txInput
            // 
            this.txInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txInput.Location = new System.Drawing.Point(83, 15);
            this.txInput.Margin = new System.Windows.Forms.Padding(4);
            this.txInput.Name = "txInput";
            this.txInput.Size = new System.Drawing.Size(105, 26);
            this.txInput.TabIndex = 0;
            this.txInput.TextChanged += new System.EventHandler(this.TxInput_TextChanged);
            // 
            // btGet
            // 
            this.btGet.Location = new System.Drawing.Point(561, 15);
            this.btGet.Margin = new System.Windows.Forms.Padding(4);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(100, 28);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "Get Bin";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbOutput
            // 
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.ItemHeight = 16;
            this.lbOutput.Location = new System.Drawing.Point(17, 50);
            this.lbOutput.Margin = new System.Windows.Forms.Padding(4);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(535, 164);
            this.lbOutput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Text";
            // 
            // txData
            // 
            this.txData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txData.Location = new System.Drawing.Point(83, 279);
            this.txData.Margin = new System.Windows.Forms.Padding(4);
            this.txData.Name = "txData";
            this.txData.Size = new System.Drawing.Size(469, 26);
            this.txData.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 322);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "G : ";
            // 
            // txKey
            // 
            this.txKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txKey.Location = new System.Drawing.Point(65, 57);
            this.txKey.Margin = new System.Windows.Forms.Padding(4);
            this.txKey.Name = "txKey";
            this.txKey.Size = new System.Drawing.Size(469, 26);
            this.txKey.TabIndex = 7;
            // 
            // btSolve
            // 
            this.btSolve.Location = new System.Drawing.Point(573, 279);
            this.btSolve.Margin = new System.Windows.Forms.Padding(4);
            this.btSolve.Name = "btSolve";
            this.btSolve.Size = new System.Drawing.Size(88, 28);
            this.btSolve.TabIndex = 8;
            this.btSolve.Text = "CRC";
            this.btSolve.UseVisualStyleBackColor = true;
            this.btSolve.Click += new System.EventHandler(this.btSolve_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txRes);
            this.groupBox1.Controls.Add(this.txKey);
            this.groupBox1.Location = new System.Drawing.Point(17, 260);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(548, 130);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giải thật CRC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Result : ";
            // 
            // txRes
            // 
            this.txRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txRes.Location = new System.Drawing.Point(65, 96);
            this.txRes.Margin = new System.Windows.Forms.Padding(4);
            this.txRes.Name = "txRes";
            this.txRes.Size = new System.Drawing.Size(469, 26);
            this.txRes.TabIndex = 8;
            // 
            // txResCheckSum
            // 
            this.txResCheckSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txResCheckSum.Location = new System.Drawing.Point(108, 223);
            this.txResCheckSum.Margin = new System.Windows.Forms.Padding(4);
            this.txResCheckSum.Name = "txResCheckSum";
            this.txResCheckSum.Size = new System.Drawing.Size(444, 26);
            this.txResCheckSum.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Check Sum";
            // 
            // btCheckSum
            // 
            this.btCheckSum.Location = new System.Drawing.Point(561, 223);
            this.btCheckSum.Margin = new System.Windows.Forms.Padding(4);
            this.btCheckSum.Name = "btCheckSum";
            this.btCheckSum.Size = new System.Drawing.Size(100, 28);
            this.btCheckSum.TabIndex = 12;
            this.btCheckSum.Text = "Get CS";
            this.btCheckSum.UseVisualStyleBackColor = true;
            this.btCheckSum.Click += new System.EventHandler(this.btCheckSum_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 412);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Solve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbRes);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txResHamming);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txInputHm);
            this.groupBox2.Location = new System.Drawing.Point(17, 399);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(548, 129);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hamming";
            // 
            // lbRes
            // 
            this.lbRes.AutoSize = true;
            this.lbRes.Location = new System.Drawing.Point(497, 97);
            this.lbRes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRes.Name = "lbRes";
            this.lbRes.Size = new System.Drawing.Size(0, 17);
            this.lbRes.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(451, 97);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Char:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Result : ";
            // 
            // txResHamming
            // 
            this.txResHamming.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txResHamming.Location = new System.Drawing.Point(65, 91);
            this.txResHamming.Margin = new System.Windows.Forms.Padding(4);
            this.txResHamming.Name = "txResHamming";
            this.txResHamming.Size = new System.Drawing.Size(376, 26);
            this.txResHamming.TabIndex = 13;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(407, 63);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(123, 21);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Encode/Detect";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Input :";
            // 
            // txInputHm
            // 
            this.txInputHm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txInputHm.Location = new System.Drawing.Point(91, 28);
            this.txInputHm.Margin = new System.Windows.Forms.Padding(4);
            this.txInputHm.Name = "txInputHm";
            this.txInputHm.Size = new System.Drawing.Size(444, 26);
            this.txInputHm.TabIndex = 10;
            this.txInputHm.TextChanged += new System.EventHandler(this.TxInputHm_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(197, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(355, 26);
            this.textBox1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 534);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btCheckSum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txResCheckSum);
            this.Controls.Add(this.btSolve);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.txInput);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txInput;
		private System.Windows.Forms.Button btGet;
		private System.Windows.Forms.ListBox lbOutput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txData;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txKey;
		private System.Windows.Forms.Button btSolve;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txResCheckSum;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btCheckSum;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txRes;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txInputHm;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txResHamming;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lbRes;
	}
}

