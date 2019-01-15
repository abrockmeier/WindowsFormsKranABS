namespace WindowsFormsKranABS
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.BT_H_ausf = new System.Windows.Forms.Button();
			this.BT_H_einf = new System.Windows.Forms.Button();
			this.BT_A_links = new System.Windows.Forms.Button();
			this.BT_A_rechts = new System.Windows.Forms.Button();
			this.BT_KA_r = new System.Windows.Forms.Button();
			this.BT_KA_l = new System.Windows.Forms.Button();
			this.BT_K_ausf = new System.Windows.Forms.Button();
			this.BT_K_einf = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.RB_Mright = new System.Windows.Forms.RadioButton();
			this.BT_Stop = new System.Windows.Forms.Button();
			this.BT_Start = new System.Windows.Forms.Button();
			this.RB_Mleft = new System.Windows.Forms.RadioButton();
			this.RB_H_einf = new System.Windows.Forms.RadioButton();
			this.RB_Ausl_einf = new System.Windows.Forms.RadioButton();
			this.BT_Mright = new System.Windows.Forms.Button();
			this.RB_Ausl_ausf = new System.Windows.Forms.RadioButton();
			this.RB_K_einf = new System.Windows.Forms.RadioButton();
			this.BT_Mleft = new System.Windows.Forms.Button();
			this.RB_H_ausf = new System.Windows.Forms.RadioButton();
			this.RB_K_ausf = new System.Windows.Forms.RadioButton();
			this.P_Fr = new System.Windows.Forms.Panel();
			this.P_Kg = new System.Windows.Forms.Panel();
			this.P_Ab = new System.Windows.Forms.Panel();
			this.P_Hg = new System.Windows.Forms.Panel();
			this.T_Kran = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// BT_H_ausf
			// 
			this.BT_H_ausf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.BT_H_ausf.Location = new System.Drawing.Point(96, 103);
			this.BT_H_ausf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.BT_H_ausf.Name = "BT_H_ausf";
			this.BT_H_ausf.Size = new System.Drawing.Size(71, 31);
			this.BT_H_ausf.TabIndex = 0;
			this.BT_H_ausf.Text = "H_ausf";
			this.BT_H_ausf.UseVisualStyleBackColor = false;
			this.BT_H_ausf.Click += new System.EventHandler(this.BT_H_ausf_Click);
			// 
			// BT_H_einf
			// 
			this.BT_H_einf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.BT_H_einf.Location = new System.Drawing.Point(7, 81);
			this.BT_H_einf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.BT_H_einf.Name = "BT_H_einf";
			this.BT_H_einf.Size = new System.Drawing.Size(68, 31);
			this.BT_H_einf.TabIndex = 1;
			this.BT_H_einf.Text = "H_einf";
			this.BT_H_einf.UseVisualStyleBackColor = false;
			this.BT_H_einf.Click += new System.EventHandler(this.BT_H_einf_Click);
			// 
			// BT_A_links
			// 
			this.BT_A_links.BackColor = System.Drawing.Color.SteelBlue;
			this.BT_A_links.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BT_A_links.Location = new System.Drawing.Point(0, 9);
			this.BT_A_links.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.BT_A_links.Name = "BT_A_links";
			this.BT_A_links.Size = new System.Drawing.Size(58, 31);
			this.BT_A_links.TabIndex = 2;
			this.BT_A_links.Text = "<-- A";
			this.BT_A_links.UseVisualStyleBackColor = false;
			this.BT_A_links.Click += new System.EventHandler(this.BT_A_ausf_Click);
			// 
			// BT_A_rechts
			// 
			this.BT_A_rechts.BackColor = System.Drawing.Color.SteelBlue;
			this.BT_A_rechts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BT_A_rechts.Location = new System.Drawing.Point(131, 32);
			this.BT_A_rechts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.BT_A_rechts.Name = "BT_A_rechts";
			this.BT_A_rechts.Size = new System.Drawing.Size(55, 31);
			this.BT_A_rechts.TabIndex = 3;
			this.BT_A_rechts.Text = "A -->";
			this.BT_A_rechts.UseVisualStyleBackColor = false;
			this.BT_A_rechts.Click += new System.EventHandler(this.BT_A_einf_Click);
			// 
			// BT_KA_r
			// 
			this.BT_KA_r.BackColor = System.Drawing.Color.SteelBlue;
			this.BT_KA_r.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BT_KA_r.Location = new System.Drawing.Point(99, 168);
			this.BT_KA_r.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.BT_KA_r.Name = "BT_KA_r";
			this.BT_KA_r.Size = new System.Drawing.Size(74, 31);
			this.BT_KA_r.TabIndex = 4;
			this.BT_KA_r.Text = "A <>>";
			this.BT_KA_r.UseVisualStyleBackColor = false;
			this.BT_KA_r.Click += new System.EventHandler(this.BT_KA_r_Click);
			// 
			// BT_KA_l
			// 
			this.BT_KA_l.BackColor = System.Drawing.Color.SteelBlue;
			this.BT_KA_l.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BT_KA_l.Location = new System.Drawing.Point(3, 168);
			this.BT_KA_l.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.BT_KA_l.Name = "BT_KA_l";
			this.BT_KA_l.Size = new System.Drawing.Size(72, 31);
			this.BT_KA_l.TabIndex = 5;
			this.BT_KA_l.Text = "<<> A";
			this.BT_KA_l.UseVisualStyleBackColor = false;
			this.BT_KA_l.Click += new System.EventHandler(this.BT_KA_l_Click);
			// 
			// BT_K_ausf
			// 
			this.BT_K_ausf.BackColor = System.Drawing.Color.Gold;
			this.BT_K_ausf.Location = new System.Drawing.Point(13, 231);
			this.BT_K_ausf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.BT_K_ausf.Name = "BT_K_ausf";
			this.BT_K_ausf.Size = new System.Drawing.Size(68, 31);
			this.BT_K_ausf.TabIndex = 6;
			this.BT_K_ausf.Text = "K_ausf";
			this.BT_K_ausf.UseVisualStyleBackColor = false;
			this.BT_K_ausf.Click += new System.EventHandler(this.BT_K_ausf_Click);
			// 
			// BT_K_einf
			// 
			this.BT_K_einf.BackColor = System.Drawing.Color.Gold;
			this.BT_K_einf.Location = new System.Drawing.Point(96, 257);
			this.BT_K_einf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.BT_K_einf.Name = "BT_K_einf";
			this.BT_K_einf.Size = new System.Drawing.Size(81, 31);
			this.BT_K_einf.TabIndex = 7;
			this.BT_K_einf.Text = "K_einf";
			this.BT_K_einf.UseVisualStyleBackColor = false;
			this.BT_K_einf.Click += new System.EventHandler(this.BT_K_einf_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.RB_Mright);
			this.panel1.Controls.Add(this.BT_Stop);
			this.panel1.Controls.Add(this.BT_Start);
			this.panel1.Controls.Add(this.RB_Mleft);
			this.panel1.Controls.Add(this.RB_H_einf);
			this.panel1.Controls.Add(this.RB_Ausl_einf);
			this.panel1.Controls.Add(this.BT_Mright);
			this.panel1.Controls.Add(this.RB_Ausl_ausf);
			this.panel1.Controls.Add(this.BT_A_rechts);
			this.panel1.Controls.Add(this.RB_K_einf);
			this.panel1.Controls.Add(this.BT_Mleft);
			this.panel1.Controls.Add(this.BT_A_links);
			this.panel1.Controls.Add(this.BT_H_einf);
			this.panel1.Controls.Add(this.BT_H_ausf);
			this.panel1.Controls.Add(this.RB_H_ausf);
			this.panel1.Controls.Add(this.BT_K_einf);
			this.panel1.Controls.Add(this.RB_K_ausf);
			this.panel1.Controls.Add(this.BT_KA_l);
			this.panel1.Controls.Add(this.BT_K_ausf);
			this.panel1.Controls.Add(this.BT_KA_r);
			this.panel1.Location = new System.Drawing.Point(615, 26);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(186, 402);
			this.panel1.TabIndex = 8;
			// 
			// RB_Mright
			// 
			this.RB_Mright.AutoSize = true;
			this.RB_Mright.Location = new System.Drawing.Point(92, 328);
			this.RB_Mright.Name = "RB_Mright";
			this.RB_Mright.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RB_Mright.Size = new System.Drawing.Size(81, 21);
			this.RB_Mright.TabIndex = 21;
			this.RB_Mright.TabStop = true;
			this.RB_Mright.Text = "Kran -->";
			this.RB_Mright.UseVisualStyleBackColor = true;
			this.RB_Mright.CheckedChanged += new System.EventHandler(this.RB_Mright_CheckedChanged);
			// 
			// BT_Stop
			// 
			this.BT_Stop.Location = new System.Drawing.Point(99, 355);
			this.BT_Stop.Name = "BT_Stop";
			this.BT_Stop.Size = new System.Drawing.Size(75, 40);
			this.BT_Stop.TabIndex = 19;
			this.BT_Stop.Text = "Stop";
			this.BT_Stop.UseVisualStyleBackColor = true;
			this.BT_Stop.Click += new System.EventHandler(this.BT_Stop_Click);
			// 
			// BT_Start
			// 
			this.BT_Start.Location = new System.Drawing.Point(13, 355);
			this.BT_Start.Name = "BT_Start";
			this.BT_Start.Size = new System.Drawing.Size(75, 40);
			this.BT_Start.TabIndex = 18;
			this.BT_Start.Text = "Start";
			this.BT_Start.UseVisualStyleBackColor = true;
			this.BT_Start.Click += new System.EventHandler(this.BT_Start_Click);
			// 
			// RB_Mleft
			// 
			this.RB_Mleft.AutoSize = true;
			this.RB_Mleft.Location = new System.Drawing.Point(10, 329);
			this.RB_Mleft.Name = "RB_Mleft";
			this.RB_Mleft.Size = new System.Drawing.Size(81, 21);
			this.RB_Mleft.TabIndex = 20;
			this.RB_Mleft.TabStop = true;
			this.RB_Mleft.Text = "<-- Kran";
			this.RB_Mleft.UseVisualStyleBackColor = true;
			this.RB_Mleft.CheckedChanged += new System.EventHandler(this.RB_Mleft_CheckedChanged);
			// 
			// RB_H_einf
			// 
			this.RB_H_einf.AutoSize = true;
			this.RB_H_einf.Location = new System.Drawing.Point(8, 113);
			this.RB_H_einf.Name = "RB_H_einf";
			this.RB_H_einf.Size = new System.Drawing.Size(82, 21);
			this.RB_H_einf.TabIndex = 11;
			this.RB_H_einf.TabStop = true;
			this.RB_H_einf.Text = "Haken /\\";
			this.RB_H_einf.UseVisualStyleBackColor = true;
			this.RB_H_einf.CheckedChanged += new System.EventHandler(this.RB_H_einf_CheckedChanged);
			// 
			// RB_Ausl_einf
			// 
			this.RB_Ausl_einf.AutoSize = true;
			this.RB_Ausl_einf.Location = new System.Drawing.Point(29, 37);
			this.RB_Ausl_einf.Name = "RB_Ausl_einf";
			this.RB_Ausl_einf.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RB_Ausl_einf.Size = new System.Drawing.Size(97, 21);
			this.RB_Ausl_einf.TabIndex = 13;
			this.RB_Ausl_einf.TabStop = true;
			this.RB_Ausl_einf.Text = "Ausleger >";
			this.RB_Ausl_einf.UseVisualStyleBackColor = true;
			this.RB_Ausl_einf.CheckedChanged += new System.EventHandler(this.RB_Ausl_einf_CheckedChanged);
			// 
			// BT_Mright
			// 
			this.BT_Mright.BackColor = System.Drawing.Color.Crimson;
			this.BT_Mright.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BT_Mright.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BT_Mright.Location = new System.Drawing.Point(96, 293);
			this.BT_Mright.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.BT_Mright.Name = "BT_Mright";
			this.BT_Mright.Size = new System.Drawing.Size(81, 31);
			this.BT_Mright.TabIndex = 10;
			this.BT_Mright.Text = "-->";
			this.BT_Mright.UseVisualStyleBackColor = false;
			this.BT_Mright.Click += new System.EventHandler(this.BT_Mright_Click);
			// 
			// RB_Ausl_ausf
			// 
			this.RB_Ausl_ausf.AutoSize = true;
			this.RB_Ausl_ausf.Location = new System.Drawing.Point(59, 13);
			this.RB_Ausl_ausf.Name = "RB_Ausl_ausf";
			this.RB_Ausl_ausf.Size = new System.Drawing.Size(97, 21);
			this.RB_Ausl_ausf.TabIndex = 12;
			this.RB_Ausl_ausf.Text = "< Ausleger";
			this.RB_Ausl_ausf.UseVisualStyleBackColor = true;
			this.RB_Ausl_ausf.CheckedChanged += new System.EventHandler(this.RB_Ausl_ausf_CheckedChanged);
			// 
			// RB_K_einf
			// 
			this.RB_K_einf.AutoSize = true;
			this.RB_K_einf.Location = new System.Drawing.Point(96, 231);
			this.RB_K_einf.Name = "RB_K_einf";
			this.RB_K_einf.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RB_K_einf.Size = new System.Drawing.Size(71, 21);
			this.RB_K_einf.TabIndex = 17;
			this.RB_K_einf.TabStop = true;
			this.RB_K_einf.Text = "Kran \\/";
			this.RB_K_einf.UseVisualStyleBackColor = true;
			this.RB_K_einf.CheckedChanged += new System.EventHandler(this.RB_K_einf_CheckedChanged);
			// 
			// BT_Mleft
			// 
			this.BT_Mleft.BackColor = System.Drawing.Color.Crimson;
			this.BT_Mleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BT_Mleft.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BT_Mleft.Location = new System.Drawing.Point(7, 293);
			this.BT_Mleft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.BT_Mleft.Name = "BT_Mleft";
			this.BT_Mleft.Size = new System.Drawing.Size(81, 31);
			this.BT_Mleft.TabIndex = 9;
			this.BT_Mleft.Text = "<--";
			this.BT_Mleft.UseVisualStyleBackColor = false;
			this.BT_Mleft.Click += new System.EventHandler(this.BT_Mleft_Click);
			// 
			// RB_H_ausf
			// 
			this.RB_H_ausf.AutoSize = true;
			this.RB_H_ausf.Location = new System.Drawing.Point(94, 82);
			this.RB_H_ausf.Name = "RB_H_ausf";
			this.RB_H_ausf.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RB_H_ausf.Size = new System.Drawing.Size(82, 21);
			this.RB_H_ausf.TabIndex = 11;
			this.RB_H_ausf.TabStop = true;
			this.RB_H_ausf.Text = "Haken \\/";
			this.RB_H_ausf.UseVisualStyleBackColor = true;
			this.RB_H_ausf.CheckedChanged += new System.EventHandler(this.RB_H_ausf_CheckedChanged);
			// 
			// RB_K_ausf
			// 
			this.RB_K_ausf.AutoSize = true;
			this.RB_K_ausf.Location = new System.Drawing.Point(10, 267);
			this.RB_K_ausf.Name = "RB_K_ausf";
			this.RB_K_ausf.Size = new System.Drawing.Size(71, 21);
			this.RB_K_ausf.TabIndex = 16;
			this.RB_K_ausf.TabStop = true;
			this.RB_K_ausf.Text = "Kran /\\";
			this.RB_K_ausf.UseVisualStyleBackColor = true;
			this.RB_K_ausf.CheckedChanged += new System.EventHandler(this.RB_K_ausf_CheckedChanged);
			// 
			// P_Fr
			// 
			this.P_Fr.BackColor = System.Drawing.Color.OrangeRed;
			this.P_Fr.Location = new System.Drawing.Point(264, 410);
			this.P_Fr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.P_Fr.Name = "P_Fr";
			this.P_Fr.Size = new System.Drawing.Size(115, 25);
			this.P_Fr.TabIndex = 9;
			// 
			// P_Kg
			// 
			this.P_Kg.BackColor = System.Drawing.Color.Gold;
			this.P_Kg.Location = new System.Drawing.Point(311, 210);
			this.P_Kg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.P_Kg.Name = "P_Kg";
			this.P_Kg.Size = new System.Drawing.Size(20, 199);
			this.P_Kg.TabIndex = 10;
			// 
			// P_Ab
			// 
			this.P_Ab.BackColor = System.Drawing.Color.SteelBlue;
			this.P_Ab.Location = new System.Drawing.Point(211, 210);
			this.P_Ab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.P_Ab.Name = "P_Ab";
			this.P_Ab.Size = new System.Drawing.Size(100, 20);
			this.P_Ab.TabIndex = 12;
			// 
			// P_Hg
			// 
			this.P_Hg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.P_Hg.Location = new System.Drawing.Point(211, 230);
			this.P_Hg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.P_Hg.Name = "P_Hg";
			this.P_Hg.Size = new System.Drawing.Size(20, 39);
			this.P_Hg.TabIndex = 11;
			// 
			// T_Kran
			// 
			this.T_Kran.Interval = 200;
			this.T_Kran.Tick += new System.EventHandler(this.T_Kran_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.P_Hg);
			this.Controls.Add(this.P_Ab);
			this.Controls.Add(this.P_Kg);
			this.Controls.Add(this.P_Fr);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button BT_H_ausf;
		private System.Windows.Forms.Button BT_H_einf;
		private System.Windows.Forms.Button BT_A_links;
		private System.Windows.Forms.Button BT_A_rechts;
		private System.Windows.Forms.Button BT_KA_r;
		private System.Windows.Forms.Button BT_KA_l;
		private System.Windows.Forms.Button BT_K_ausf;
		private System.Windows.Forms.Button BT_K_einf;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel P_Fr;
		private System.Windows.Forms.Panel P_Kg;
		private System.Windows.Forms.Panel P_Ab;
		private System.Windows.Forms.Panel P_Hg;
		private System.Windows.Forms.Button BT_Mleft;
		private System.Windows.Forms.Button BT_Mright;
		private System.Windows.Forms.RadioButton RB_H_einf;
		private System.Windows.Forms.Button BT_Stop;
		private System.Windows.Forms.Button BT_Start;
		private System.Windows.Forms.RadioButton RB_K_einf;
		private System.Windows.Forms.RadioButton RB_K_ausf;
		private System.Windows.Forms.RadioButton RB_Ausl_einf;
		private System.Windows.Forms.RadioButton RB_Ausl_ausf;
		private System.Windows.Forms.RadioButton RB_H_ausf;
		private System.Windows.Forms.RadioButton RB_Mright;
		private System.Windows.Forms.RadioButton RB_Mleft;
		private System.Windows.Forms.Timer T_Kran;
	}
}

