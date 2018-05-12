using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rocnikova_prace__1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnVypocet_Click(object sender, EventArgs e)
        {
            //pole vstupů známek
            TextBox[] vstupyZnamek = { textBoxZnamka1, textBoxZnamka2, textBoxZnamka3, textBoxZnamka4, textBoxZnamka5 };
            //pole vstupů váh
            TextBox[] vstupyVah = { textBoxVaha1, textBoxVaha2, textBoxVaha3, textBoxVaha4, textBoxVaha5 };
            //pole známek
            int[] znamky = new int[5];
            //pole váh
            int[] vahy = new int[5];
            for (int i = 0; i < 5; i++)
            {
                String vstupZnamka = vstupyZnamek[i].Text;
                if (vstupZnamka == null || vstupZnamka.Equals(""))
                {
                    znamky[i] = -1;
                    continue;
                }
                int znamka;
                if (!int.TryParse(vstupyZnamek[i].Text, out znamka) || znamka <= 0 || znamka > 5)
                {
                    MessageBox.Show("Byla špatne zadána známka č. " + (i + 1) + ", známka může být v rozmezí 1-5");
                    return;
                }
                znamky[i] = znamka;
                String vstupVaha = vstupyVah[i].Text;
                if (vstupVaha == null || vstupVaha.Equals(""))
                {
                    vahy[i] = -1;
                    continue;
                }
                int vaha;
                if (!int.TryParse(vstupVaha, out vaha) || vaha <= 0 || vaha > 10)
                {
                    MessageBox.Show("Byla špatne zadána váha známky č. " + (i + 1) + ", váha může být v rozmezí 1-10");
                    return;
                }
                vahy[i] = vaha;
            }
            double celkova_vaha = 0;
            double vypocet_prumeru = 0;
            for (int i = 0; i < 5; i++)
            {
                double znamka = znamky[i];
                double vaha = vahy[i];
                if (znamka == -1 || vaha == -1)
                {
                    continue;
                }
                    vypocet_prumeru += znamka * vaha;
                celkova_vaha += vaha;
            }
            double vysledek = vypocet_prumeru / celkova_vaha;
            MessageBox.Show("Tvůj průměr je: " + vysledek);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pole vstupů známek
            TextBox[] vstupyZnamek = { textBoxZnamka1, textBoxZnamka2, textBoxZnamka3, textBoxZnamka4, textBoxZnamka5 };
            //pole vstupů váh
            TextBox[] vstupyVah = { textBoxVaha1, textBoxVaha2, textBoxVaha3, textBoxVaha4, textBoxVaha5 };
            //pole známek
            int[] znamky = new int[5];
            //pole váh
            int[] vahy = new int[5];
            for (int i = 0; i < 5; i++)
            {
                String vstupZnamka = vstupyZnamek[i].Text;
                if (vstupZnamka == null || vstupZnamka.Equals(""))
                {
                    znamky[i] = -1;
                    continue;
                }
                int znamka;
                if (!int.TryParse(vstupyZnamek[i].Text, out znamka) || znamka <= 0 || znamka > 5)
                {
                    MessageBox.Show("Byla špatne zadána známka č. " + (i + 1) + ", známka může být v rozmezí 1-5");
                    return;
                }
                znamky[i] = znamka;
                String vstupVaha = vstupyVah[i].Text;
                if (vstupVaha == null || vstupVaha.Equals(""))
                {
                    vahy[i] = -1;
                    continue;
                }
                int vaha;
                if (!int.TryParse(vstupVaha, out vaha) || vaha <= 0 || vaha > 10)
                {
                    MessageBox.Show("Byla špatne zadána váha známky č. " + (i + 1) + ", váha může být v rozmezí 1-10");
                    return;
                }
                vahy[i] = vaha;
            }
            float celkova_vaha = 0;
            float vypocet_prumeru = 0;
            for (int i = 0; i < 5; i++)
            {
                float znamka = znamky[i];
                float vaha = vahy[i];
                if (znamka == -1 || vaha == -1)
                {
                    continue;
                }
                vypocet_prumeru += znamka * vaha;
                celkova_vaha += vaha;
            }
            float vysledek = vypocet_prumeru / celkova_vaha;
            MessageBox.Show("Tvůj průměr je: " + vysledek);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxVaha1.Text = "";
            textBoxVaha2.Text = "";
            textBoxVaha3.Text = "";
            textBoxVaha4.Text = "";
            textBoxVaha5.Text = "";
            textBoxZnamka1.Text = "";
            textBoxZnamka2.Text = "";
            textBoxZnamka3.Text = "";
            textBoxZnamka4.Text = "";
            textBoxZnamka5.Text = "";
        }
    }
}

