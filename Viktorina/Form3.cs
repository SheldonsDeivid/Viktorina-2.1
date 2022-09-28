using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viktorina
{
    public partial class Form3 : Form
    {
        

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            labRezultats.Text = Form2.punkti + " punkti";
            labUzmundrinajums.Text = labRezultats.Text;
            if (Form2.punkti <= 5)
            {
                labUzmundrinajums.Text = "Spriežot pēc atbildēm, zināšanas par Latviju tev ir jāpapildina! Diemžēl liela daļa tavu atbilžu bija nepareizas.";
            }
            else if (Form2.punkti == 10)
            {
                labUzmundrinajums.Text = "Tu esi īsts savas zemes patriots! Turklāt vēl ar lieliskām zināšanām. Apsveicam! Tu atbildēji pareizi uz visiem jautājumiem!";
            }
            else
            {
                labUzmundrinajums.Text = "Atbildes liecina, ka pazīsti Latviju, bet tev vēl ir fakti ko atklāt!";
            }


        }

        private void labRezultats_Click(object sender, EventArgs e)
        {

        }
    }
}
