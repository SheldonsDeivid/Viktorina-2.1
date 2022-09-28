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
    public partial class Form2 : Form
    {
       string[] jautajumi = new string[] {
            "KĀ SAUC LATVIJAS LIELĀKO UPI?",
            "KĀ SAUC LATVIJAS GALVASPILSĒTU?",
            "KĀ SAUC LATVIJAS GARĀKO UPI?",
            "KĀ SAUC LATVIJAS AUGSTĀKO KALNU?",
            "APTUVENI, CIK LATVIJĀ IR IEDZĪVOTĀJU?",
            "KURA IR LATVIJAS VECĀKĀ PILSĒTA?",
            "ŪDENSKRITUMS VENTAS RUMBA, KAS ATRODAS KULDĪGĀ IR:",
            "KĀ SAUC BRĪVĪBAS PIEMINEKĻA AUTORU?",
            "KAS IR LATVIJAS HIMNAS AUTORS?",
            "KĀ SAUC LATVIJAS PIRMO PREZIDENTU?",
            "KURĀ GADĀ DIBINĀTA LATVIJAS VALSTS?",
            "KAD NOTIKA PIRMIE VISPĀRĒJIE LATVIEŠU DZIESMU SVĒTKI?",
            "KO LATVIJĀ ATZĪMĒ 11. NOVEMBRĪ?",
            "TV TORNIS, KAS ATRODAS ZAĶUSALĀ IR:",
            "AR KĀDU DABAS RESURSU LATVIJA IR VISBAGĀTĀKĀ?",
            "LATVIJĀ DZIMUŠAIS JĀKOBS JUFESS PASAULĒ IR ZINĀMS AR TO, KA:",
            "NOSAUC LATVIJAS DZIĻĀKO EZERU!",
            "KĀ SAUC JŪRU, PIE KURAS ATRODAS LATVIJA?",
            "KAS IR LATVIJAS VALSTS LIKUMDEVĒJS?",
            "1999. GADĀ PAR LATVIJAS PREZIDENTI KĻUVA VAIRA VĪĶE – FREIBERGA. UZ TO BRĪDI VIŅA BIJA PIRMĀ SIEVIETE PREZIDENTE:"
        };
        string[] atbildes1 = new string[] {
            "Daugava",
            "Liepāja",
            "Lielupe",
            "Gaiziņkalns",
            "1 miljons",
            "Rīga",
            "Vecākais ūdenskritums Eiropā",
            "Kārlis Zāle",
            "Kārlis Zāle",
            "Jānis Čakste",
            "1920. gadā",
            "1873. gadā",
            "Līgo svētkus",
            "Visaugstākais tornis Eiropā",
            "Ūdens",
            "Viņš izgudroja kafiju",
            "Alūksnes ezers",
            "Rīgas jūras līcis",
            "Prezidents",
            "Eiropā"
        };
        string[] atbildes2 = new string[] {
            "Lielupe",
            "Daugavpils",
            "Daugava",
            "Mākoņkalns",
            "2 miljoni",
            "Ludza",
            "Skaistākais ūdenskritums Eiropā",
            "Baumaņu Kārlis",
            "Jāzeps Vītols",
            "Guntis Ulmanis",
            "1918. gadā",
            "1973. gadā",
            "Latvijas dzimšanas dienu",
            "Otrais augstākais tornis Eiropā",
            "Mežs",
            "Viņš izgudroja radio",
            "Burtnieku ezers",
            "Baltā jūra",
            "Ministri",
            "Austrumeiropā"
        };
        string[] atbildes3 = new string[] {
            "Gauja",
            "Rīga",
            "Gauja",
            "Zilaiskalns",
            "3 miljoni",
            "Grobiņa",
            "Platākais ūdenskritums Eiropā",
            "Krišjānis Barons",
            "Baumaņu Kārlis",
            "Kārlis Ulmanis",
            "1919. gadā",
            "2003. gadā",
            "Lāčplēša dienu",
            "Trešais augstākais tornis Eiropā",
            "Māls",
            "Viņš izgudroja džinsus",
            "Drīdzis",
            "Baltijas jūra",
            "Saeima",
            "Baltijā"
        };
        string[] atbildes = new string[] {
            "Daugava",
            "Rīga",
            "Gauja",
            "Gaiziņkalns",
            "2 miljoni",
            "Ludza",
            "Platākais ūdenskritums Eiropā",
            "Kārlis Zāle",
            "Baumaņu Kārlis",
            "Jānis Čakste",
            "1918. gadā",
            "1873. gadā",
            "Lāčplēša dienu",
            "Trešais augstākais tornis Eiropā",
            "Mežs",
            "Viņš izgudroja džinsus",
            "Drīdzis",
            "Baltijas jūra",
            "Saeima",
            "Austrumeiropā"
        };
        

        int piemeri = 0;
        public static int punkti = 0;

        public Form2()
        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            labJautajums.Text = jautajumi[piemeri];
            butAtbilde1.Text = atbildes1[piemeri];
            butAtbilde2.Text = atbildes2[piemeri];
            butAtbilde3.Text = atbildes3[piemeri];
        }

        private void butAtbilde1_Click(object sender, EventArgs e)
        {
            if (butAtbilde1.Text == atbildes[piemeri]) punkti = punkti + 1;
            else if (punkti > 0) punkti = punkti - 1;
            if (punkti == 1) labPunkti.Text = punkti + " punkts";
            else labPunkti.Text = punkti + " punkti";
            piemeri = piemeri + 1;
            if (piemeri < 10)
            {
                labJautajums.Text = jautajumi[piemeri];
                butAtbilde1.Text = atbildes1[piemeri];
                butAtbilde2.Text = atbildes2[piemeri];
                butAtbilde3.Text = atbildes3[piemeri];
                labPiemers.Text = (piemeri + 1) + ". no 10 jautājumiem";
            }
            else
            {
                this.Hide();
                Form3 rezultats = new Form3();
                rezultats.Show();
            }
        }

        private void butAtbilde2_Click(object sender, EventArgs e)
        {
            if (butAtbilde2.Text == atbildes[piemeri]) punkti = punkti + 1;
            else if (punkti > 0) punkti = punkti - 1;
            if (punkti == 1) labPunkti.Text = punkti + " punkts";
            else labPunkti.Text = punkti + " punkti";
            piemeri = piemeri + 1;
            if (piemeri < 10)
            {
                labJautajums.Text = jautajumi[piemeri];
                butAtbilde1.Text = atbildes1[piemeri];
                butAtbilde2.Text = atbildes2[piemeri];
                butAtbilde3.Text = atbildes3[piemeri];
                labPiemers.Text = (piemeri + 1) + ". no 10 jautājumiem";
            }
            else
            {
                this.Hide();
                Form3 rezultats = new Form3();
                rezultats.Show();
            }
        }

        private void butAtbilde3_Click(object sender, EventArgs e)
        {
            if (butAtbilde3.Text == atbildes[piemeri]) punkti = punkti + 1;
            else if (punkti > 0) punkti = punkti - 1;
            if (punkti == 1) labPunkti.Text = punkti + " punkts";
            else labPunkti.Text = punkti + " punkti";
            piemeri = piemeri + 1;
            if (piemeri < 10)
            {
                labJautajums.Text = jautajumi[piemeri];
                butAtbilde1.Text = atbildes1[piemeri];
                butAtbilde2.Text = atbildes2[piemeri];
                butAtbilde3.Text = atbildes3[piemeri];
                labPiemers.Text = (piemeri + 1) + ". no 10 jautājumiem";
            }
            else
            {
                this.Hide();
                Form3 rezultats = new Form3();
                rezultats.Show();
            }
        }

        private void labJautajums_Click(object sender, EventArgs e)
        {
            
        }
    }
}
