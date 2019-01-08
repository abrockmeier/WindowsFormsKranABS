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
	}
}
