using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*	Einzige Kommentarzeilen:
 *	einfach:	[in den Entwurfsmodus wechseln (doppleklick auf Form1.cs),
 *				dann schauen wie die Knöpfe und Panels heißen...]
 *				
 *	ausführlich:
 *	Buttons:
 *	BT_KA_l		::= Kranausleger links
 *	BT_KA_r		::= Kranausleger rechts
 *	BT_H_ausf	::= Haken ausfahren
 *	BT_H_einf	::= Haken einfahren
 *	BT_A_ausf	::= Ausleger ausfahren
 *	BT_A_einf	::= Ausleger einfahren
 *	BT_K_ausf	::= Kran ausfahren
 *	BT_K_einf	::= Kran einfahren
 *	BT_Mleft	::= nach links fahren
 *	BT_Mright	::= nach rechts fahren
 *	
 *	Panels:
 *	P_Hg ::= Haken (grün)
 *	P_Ab ::= Ausleger (blau)
 *	P_Kg ::= Kran (gelb)
 *	P_Fr ::= Fundament (rot)
 *	
 *	Wesentliche Bewengungsmanipulation findet über die Points statt, die aus den 
 *	Forms ausgelesen, manipuliert und wieder zurück geschrieben werden.
 */

namespace WindowsFormsKranABS
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public bool started = false;
		public bool KA_l = true;
		
		private void BT_KA_r_Click(object sender, EventArgs e)
		{
			int width = ActiveForm.Width -177; //effektiver Anzeigebereich
			if (P_Ab.Location.X + P_Ab.Width < width - P_Ab.Width)
				while (KA_l)
				{
					Point actualPointHg = new Point(P_Hg.Location.X + 2*P_Ab.Width,
					P_Kg.Location.Y + P_Ab.Height);
					P_Hg.Location = actualPointHg;
					Point actualPointAb = new Point(P_Ab.Location.X + P_Ab.Width + P_Kg.Width,
					P_Ab.Location.Y);
					P_Ab.Location = actualPointAb;
					KA_l = false;
					FalseAll();
				}
		}
		private void BT_KA_l_Click(object sender, EventArgs e)
		{
			if (P_Ab.Location.X - P_Ab.Width > 10)
				while (!KA_l)
				{
					Point actualPointHg = new Point(P_Hg.Location.X  - 2*P_Ab.Width,
					P_Kg.Location.Y + P_Ab.Height );
					P_Hg.Location = actualPointHg;
					Point actualPointAb = new Point(P_Ab.Location.X - P_Ab.Width - P_Kg.Width,
					P_Ab.Location.Y);
					P_Ab.Location = actualPointAb;
					KA_l = true;
					FalseAll();
				}
		}
		private void BT_H_ausf_Click(object sender, EventArgs e)
		{
			if (P_Hg.Height < P_Kg.Height )
			if (!(P_Ab.Width <= 60 && P_Hg.Height <= P_Kg.Height))  
			P_Hg.Height += 10;
		}
		private void BT_H_einf_Click(object sender, EventArgs e)
		{
			if (P_Hg.Height > 40)
			P_Hg.Height -= 10;
		}
		private void BT_A_ausf_Click(object sender, EventArgs e)
		{
			int width = ActiveForm.Width - P_Ab.Location.X -147;;
			if (KA_l)
			{
				if (P_Ab.Width < P_Ab.Location.X + P_Ab.Width)
				{
					P_Ab.Width += 10;
					Point actualPointAb = new Point(P_Ab.Location.X - 10,
					P_Ab.Location.Y);
					P_Ab.Location = actualPointAb;
					Point actualPointHg = new Point(P_Hg.Location.X - 10,
					P_Hg.Location.Y);
					P_Hg.Location = actualPointHg;
				}
			}
			else
			{ 
				if (P_Ab.Width < width)
				{
					P_Ab.Width += 10;
					Point actualPointHg = new Point(P_Hg.Location.X  +10,
					P_Hg.Location.Y);
					P_Hg.Location = actualPointHg;
				}
			}
		}
		private void BT_A_einf_Click(object sender, EventArgs e)
		{
			if (KA_l)
			{
				if (P_Ab.Width >= 40)
				{
					P_Ab.Width -= 10;
					Point actualPointAb = new Point(P_Ab.Location.X +10,
					P_Ab.Location.Y);
					P_Ab.Location = actualPointAb;
					Point actualPointHg = new Point(P_Hg.Location.X  +10,
					P_Hg.Location.Y);
					P_Hg.Location = actualPointHg;
				}
			}
			else
			{
				if (!KA_l)
				{
					if (P_Ab.Width > 40)
					{
						P_Ab.Width -= 10;
						Point actualPointAb = new Point(P_Ab.Location.X,
						P_Ab.Location.Y);
						P_Ab.Location = actualPointAb;
						Point actualPointHg = new Point(P_Hg.Location.X - 10,
						P_Hg.Location.Y);
						P_Hg.Location = actualPointHg;
					}
				}
			}
		}
		private void BT_K_ausf_Click(object sender, EventArgs e)
		{
			if (P_Kg.Location.Y > 10)
			{
				P_Kg.Height += 10;
				Point actualPointKg = new Point(P_Kg.Location.X,
				P_Kg.Location.Y - 10);
				P_Kg.Location = actualPointKg;
				Point actualPointHg = new Point(P_Hg.Location.X,
				P_Hg.Location.Y - 10);
				P_Hg.Location = actualPointHg;
				Point actualPointAb = new Point(P_Ab.Location.X,
				P_Ab.Location.Y - 10);
				P_Ab.Location = actualPointAb;
			}
		}
		private void BT_K_einf_Click(object sender, EventArgs e)
		{
			if (!(P_Ab.Width <= 60 && P_Hg.Height <= P_Kg.Height)
			|| (P_Kg.Height +10 > P_Hg.Height + P_Ab.Height))
				if (P_Hg.Height < P_Kg.Height -20)
				{
					P_Kg.Height -= 10;
					Point actualPointKg = new Point(P_Kg.Location.X,
					P_Kg.Location.Y + 10);
					P_Kg.Location = actualPointKg;
					Point actualPointAb = new Point(P_Ab.Location.X,
					P_Ab.Location.Y + 10);
					P_Ab.Location = actualPointAb;
					Point actualPointHg = new Point(P_Hg.Location.X,
					P_Hg.Location.Y + 10);
					P_Hg.Location = actualPointHg;
				}
		}
		private void BT_Mleft_Click(object sender, EventArgs e)
		{
			if (P_Fr.Location.X > 0 && P_Ab.Location.X > 0)
			{
				Point actualPointHg = new Point(P_Hg.Location.X - 10,
				P_Hg.Location.Y);
				P_Hg.Location = actualPointHg;
				Point actualPointAb = new Point(P_Ab.Location.X - 10,
				P_Ab.Location.Y);
				P_Ab.Location = actualPointAb;
				Point actualPointKg = new Point(P_Kg.Location.X - 10,
				P_Kg.Location.Y);
				P_Kg.Location = actualPointKg;
				Point actualPointFr = new Point(P_Fr.Location.X - 10,
				P_Fr.Location.Y);
				P_Fr.Location = actualPointFr;
			}
		}
		private void BT_Mright_Click(object sender, EventArgs e)
		{
			int width = ActiveForm.Width -167;
			if (P_Fr.Location.X < width - P_Fr.Width && P_Ab.Location.X < width - P_Ab.Width)
			{
				Point actualPointHg = new Point(P_Hg.Location.X + 10,
				P_Hg.Location.Y);
				P_Hg.Location = actualPointHg;
				Point actualPointAb = new Point(P_Ab.Location.X + 10,
				P_Ab.Location.Y);
				P_Ab.Location = actualPointAb;
				Point actualPointKg = new Point(P_Kg.Location.X + 10,
				P_Kg.Location.Y);
				P_Kg.Location = actualPointKg;
				Point actualPointFr = new Point(P_Fr.Location.X + 10,
				P_Fr.Location.Y);
				P_Fr.Location = actualPointFr;
			}
		}
		// Hier folgt die Ergänzng aus der Erweiterungsaufgabe des Krans!
		
		private bool TB_A_ausf, TB_A_einf;
		private bool TB_H_ausf, TB_H_einf;
		private bool TB_K_ausf, TB_K_einf;
		private bool TB_Mleft, TB_Mright;

		private void MoveByTimer_Tick_Event (object sender,EventArgs e)
		{	// Hier wird unterschieden, was bewegt werden soll
			if (TB_A_ausf)
				BT_A_ausf_Click(sender, e);
			if (TB_A_einf)
				BT_A_einf_Click(sender, e);
			if (TB_H_ausf)
				BT_H_ausf_Click(sender, e);
			if (TB_H_einf)
				BT_H_einf_Click(sender, e);
			if (TB_K_ausf)
				BT_K_ausf_Click(sender, e);
			if (TB_K_einf)
				BT_K_einf_Click(sender, e);
			if (TB_Mleft)
				BT_Mleft_Click(sender, e);
			if (TB_Mright)
				BT_Mright_Click(sender, e);
		}


		private void RB_Ausl_ausf_CheckedChanged(object sender, EventArgs e)
		{
			T_Kran.Enabled = false;
			{
				if (KA_l)
				{
					TB_A_ausf = true;
					TB_A_einf = false;
				}
				else
				{
					TB_A_ausf = false;
					TB_A_einf = true;
				}
				TB_H_ausf = false;
				TB_H_einf = false;
				TB_K_ausf = false;
				TB_K_einf = false;
				TB_Mleft = false;
				TB_Mright = false;
			}
			while (T_Kran.Enabled)
			T_Kran_Tick(sender, e);
		}

		private void RB_Ausl_einf_CheckedChanged(object sender, EventArgs e)
		{
			T_Kran.Enabled = false;
			{
				if (!KA_l)
				{
					TB_A_ausf = true;
					TB_A_einf = false;
				}
				else
				{
					TB_A_ausf = false;
					TB_A_einf = true;
				}
				TB_H_ausf = false;
				TB_H_einf = false;
				TB_K_ausf = false;
				TB_K_einf = false;
				TB_Mleft = false;
				TB_Mright = false;
			}
			
			while (T_Kran.Enabled)
			T_Kran_Tick(sender, e);
		}

		private void RB_H_ausf_CheckedChanged(object sender, EventArgs e)
		{	
			T_Kran.Enabled = false;
			{
				TB_A_ausf = false;
				TB_A_einf = false;
				TB_H_ausf = true;
				TB_H_einf = false;
				TB_K_ausf = false;
				TB_K_einf = false;
				TB_Mleft = false;
				TB_Mright = false;
			}
			while (T_Kran.Enabled)
			T_Kran_Tick(sender, e);
		}

		private void RB_H_einf_CheckedChanged(object sender, EventArgs e)
		{	
			T_Kran.Enabled = false;
			{
				TB_A_ausf = false;
				TB_A_einf = false;
				TB_H_ausf = false;
				TB_H_einf = true;
				TB_K_ausf = false;
				TB_K_einf = false;
				TB_Mleft = false;
				TB_Mright = false;
			}
			while (T_Kran.Enabled)
			T_Kran_Tick(sender, e);
		}

		private void RB_K_ausf_CheckedChanged(object sender, EventArgs e)
		{	
			T_Kran.Enabled = false;
			{
				TB_A_ausf = false;
				TB_A_einf = false;
				TB_H_ausf = false;
				TB_H_einf = false;
				TB_K_ausf = true;
				TB_K_einf = false;
				TB_Mleft = false;
				TB_Mright = false;
			}
			
			while (T_Kran.Enabled)
			T_Kran_Tick(sender, e);
		}

		private void RB_K_einf_CheckedChanged(object sender, EventArgs e)
		{
			T_Kran.Enabled = false;
			{
				TB_A_ausf = false;
				TB_A_einf = false;
				TB_H_ausf = false;
				TB_H_einf = false;
				TB_K_ausf = false;
				TB_K_einf = true;
				TB_Mleft = false;
				TB_Mright = false;
			}
			while (T_Kran.Enabled)
			T_Kran_Tick(sender, e);
		}

		private void RB_Mleft_CheckedChanged(object sender, EventArgs e)
		{
			T_Kran.Enabled = false;
			{
				TB_A_ausf = false;
				TB_A_einf = false;
				TB_H_ausf = false;
				TB_H_einf = false;
				TB_K_ausf = false;
				TB_K_einf = false;
				TB_Mleft = true;
				TB_Mright = false;
			}
			while (T_Kran.Enabled)
			T_Kran_Tick(sender, e);
		}

		private void RB_Mright_CheckedChanged(object sender, EventArgs e)
		{	
			{
				TB_A_ausf = false;
				TB_A_einf = false;
				TB_H_ausf = false;
				TB_H_einf = false;
				TB_K_ausf = false;
				TB_K_einf = false;
				TB_Mleft = false;
				TB_Mright = true;
			}
			while (T_Kran.Enabled)
			T_Kran_Tick(sender, e);
		}

		private void BT_Start_Click(object sender, EventArgs e)
		{
			T_Kran.Enabled = true;
		}

		private void BT_Stop_Click(object sender, EventArgs e)
		{
			T_Kran.Enabled = false;
			FalseAll();
		}

		private void FalseAll()
		{
			RB_Ausl_ausf.Checked = false;
			RB_Ausl_einf.Checked = false;
			RB_H_ausf.Checked = false;
			RB_H_einf.Checked = false;
			RB_K_ausf.Checked = false;
			RB_K_einf.Checked = false;
			RB_Mleft.Checked = false;
			RB_Mright.Checked = false;
		}

		private void T_Kran_Tick(object sender, EventArgs e)
		{
			MoveByTimer_Tick_Event(sender, e);
		}

		// Stop und toggle...
		// else @ stop /... start ... <--- links
		// Radio button an lassen und am Rand stoppen und Auswahlrichtung ändern..
	}
}
