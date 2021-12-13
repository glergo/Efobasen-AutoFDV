using System.Net;
using Newtonsoft.Json;

namespace Efobasen_AutoFDV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        StringConversion StringConversion = new StringConversion();

        private void btn_hent_fdv_Click(object sender, EventArgs e)
        {
            int elNummer, fdvNummer;
            String vareTekst, fabrikat;
            const String path = "https://efobasen.efo.no/API/VisProdukt/HentProduktinfo?produktnr=";
            const String fdvDownloadPath = "https://efobasen.efo.no/API/Produktfiler/LastNed?id=";

            if (Int32.TryParse(textBox_elnr.Text, out elNummer))
            {
                String URL = path + elNummer;
                using (WebClient wc = new WebClient())
                {
                    wc.Headers.Add("User-Agent", "C# Windows Application");
                    String jsonData = wc.DownloadString(URL);

                    EfobasenRoot EfobasenDeserialized = JsonConvert.DeserializeObject<EfobasenRoot>(jsonData);
                    
                    // EL Nr
                    elNummer = EfobasenDeserialized.Produktskjema.Produktnr;
                    
                    // Varetekst
                    vareTekst = EfobasenDeserialized.Produktinfo.Varetekst;
                    vareTekst = StringConversion.stripSlashes(vareTekst);
                    
                    // Fabrikat
                    fabrikat = EfobasenDeserialized.Produktinfo.Fabrikat;

                    // FDV Download ID
                    // Due to syntax in the Json file, I take the last bbject and save it to a string
                    // So we can deseriallize it again to get the fileID for the FDV file
                    if (EfobasenDeserialized.Produktskjema.Skjema.Grupper[2].Felter[0].Verdi != null)
                    {
                        var jsonFDV = EfobasenDeserialized.Produktskjema.Skjema.Grupper[2].Felter[0].Verdi.ToString();
                        EfobasenFDV EfobasenFDVDeserialized = JsonConvert.DeserializeObject<EfobasenFDV>(jsonFDV);
                        fdvNummer = Convert.ToInt32(EfobasenFDVDeserialized.FilId);

                        // Download the FDV file from URL
                        var saveFile = new SaveFileDialog();
                        saveFile.FileName = fabrikat + "-" + vareTekst + "-" + elNummer + "-FDV";
                        saveFile.Filter = "PDF document (*.pdf)|*.pdf";
                        var result = saveFile.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            wc.DownloadFile(fdvDownloadPath + fdvNummer, saveFile.FileName);
                        }
                    } else
                    {
                        MessageBox.Show("Det finnes ingen FDV fil for dette produktet.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Bare bruk gyldig el nummer.", "Obs");
            }
        }

        private void btn_om_autofdv_Click(object sender, EventArgs e)
        {
            om_efobasen_autofdv omEFO = new om_efobasen_autofdv();
            omEFO.ShowDialog();
        }
    }


    public class Felter
    {
            public object Verdi { get; set; }
    }

    public class Grupper
    {
        public List<Felter> Felter { set; get; }
    }
    public class Skjema
    {
        public List<Grupper> Grupper { set; get; }
    }
    public class Produktskjema
    {
        public int Produktnr { get; set; }
        public Skjema Skjema { get; set; }
    }

    public class Produktinfo
    {
        public String Fabrikat { get; set; }
        public String Varetekst { get; set; }
    }

    public class EfobasenRoot
    {
        public Produktskjema Produktskjema { get; set; }
        public Produktinfo Produktinfo { get; set; }
    }

    public class EfobasenFDV
    {
        public object FilId { get; set; }
    }

    public class StringConversion
    {
        public string stripSlashes(String stripText)
        {
            stripText = stripText.Replace("/", "");
            stripText = stripText.Replace("\\", "");
            return stripText;
        }
    }

}