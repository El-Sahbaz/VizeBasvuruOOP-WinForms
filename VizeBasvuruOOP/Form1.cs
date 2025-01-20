namespace VizeBasvuruOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Insan insan1 = new Insan();
            insan1.AdSoyad = "Emre Şahbaz";
            insan1.CanliMi = true;

            Insan insan2 = new Insan();
            insan2.AdSoyad = "Queen Elizabeth II";
            insan2.CanliMi = false;

            Insan insan3 = new Insan();
            insan3.AdSoyad = "Osman Ruslan";

            Insan insan4 = new Insan("Jack Mass");

            Insan insan5 = new Insan("Sawyer Less");

            Insan insan6 = new Insan()
            {
                AdSoyad = "Arda Turan",
                CanliMi = true
            };

            MessageBox.Show(insan1.AdiniSoyle());
            MessageBox.Show(Insan.SelamVer());

        }

        private void button1_Click(object sender, EventArgs e)
        {

            TCVatandas vatandas1 = new TCVatandas();
            vatandas1.DogumTarihi = Convert.ToDateTime("1990-10-10");
            MessageBox.Show(vatandas1.VizeAl());
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ABDVatandas abdVatandas1 = new ABDVatandas();
            abdVatandas1.AdSoyad = "Mark Lenen";
            abdVatandas1.Dil = "English";
            abdVatandas1.DogumTarihi = Convert.ToDateTime("1988-03-08");
            MessageBox.Show(abdVatandas1.Yas.ToString());
        }
    }
}
