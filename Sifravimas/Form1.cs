using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sifravimas
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}



		private void ButSifruot_Click(object sender, EventArgs e)
		{

			
			char[] tekstas = boxTekstas.Text.ToCharArray();
			int[] toDec = new int[tekstas.Length];
			for (int i = 0; i < tekstas.Length; i++) { toDec[i] = (int)tekstas[i]; }

		
			char[] raktas = boxRaktas.Text.ToCharArray();

			// istempimas

			char[] raktasExtended = new char[tekstas.Length];
			int k = 0;
			for (int i = 0; i < raktasExtended.Length; i++)
            {
				if (k < raktas.Length) {  raktasExtended[i] = raktas[k]; k++;  } else { k = 0; i--; }
				
            }

			// Convertas į dec

			int[] toDecRaktas = new int[raktasExtended.Length];
			for (int i = 0; i < raktasExtended.Length; i++) { toDecRaktas[i] = (int)raktasExtended[i]; }

			// Sifravimas

			int asciiLength = 127;
			//int k = 0; // rakto resetui
			int[] sifruotasMasyvas = new int[tekstas.Length];

			for (int i = 0; i < tekstas.Length; i++)
			{
				//if (k < toDecRaktas.Length){ k = 0; } else { k++ }
				sifruotasMasyvas[i] = (toDec[i] + toDecRaktas[i] + asciiLength) % asciiLength;

			}

			// int > char
			char[] charMas = new char[sifruotasMasyvas.Length];
			for (int i = 0; i < sifruotasMasyvas.Length; i++) { charMas[i] = (char)sifruotasMasyvas[i]; }

			boxSifras.Text = string.Join("", charMas);

		}

        private void butAtsifruot_Click(object sender, EventArgs e)
        {
			// teksto string > char > int
			char[] tekstas = boxSifruotas.Text.ToCharArray();
			int[] toDec = new int[tekstas.Length];
			for (int i = 0; i < tekstas.Length; i++) { toDec[i] = (int)tekstas[i]; }


			char[] raktas = boxRaktas2.Text.ToCharArray();

			// istempimas

			char[] raktasExtended = new char[tekstas.Length];
			int k = 0;
			for (int i = 0; i < raktasExtended.Length; i++)
			{
				if (k < raktas.Length) { raktasExtended[i] = raktas[k]; k++; } else { k = 0; i--; }

			}

			// Convertas į dec

			int[] toDecRaktas = new int[raktasExtended.Length];
			for (int i = 0; i < raktasExtended.Length; i++) { toDecRaktas[i] = (int)raktasExtended[i]; }

			// Sifravimas

			int asciiLength = 127;
			//int k = 0; // rakto resetui
			int[] sifruotasMasyvas = new int[tekstas.Length];

			for (int i = 0; i < tekstas.Length; i++)
			{
				//if (k < toDecRaktas.Length){ k = 0; } else { k++ }
				sifruotasMasyvas[i] = (toDec[i] - toDecRaktas[i] + asciiLength) % asciiLength;

			}

			// int > char
			char[] charMas = new char[sifruotasMasyvas.Length];
			for (int i = 0; i < sifruotasMasyvas.Length; i++) { charMas[i] = (char)sifruotasMasyvas[i]; }

			boxAtsifruotas.Text = string.Join("", charMas);

		}
	}
    
}

