namespace __Rent_a_car___Forms_Örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] PriceList = new string[] { "0 - 200", "200 - 500", "500+" };
            string[] CarCap = new string[] { "1 - 2", "3+"};

            foreach (var cap in CarCap)
            {
                lbxCarCap.Items.Add(cap);
            }
            foreach (var price in PriceList)
            {
                lbxPriceList.Items.Add(price);
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCarList_Click(object sender, EventArgs e)
        {
            if (lbxCarCap.SelectedItem == "1 - 2" && lbxPriceList.SelectedItem == "0 - 200")
            {
                lbxRent.Items.Clear();
                lbxRent.Items.Add("Honda RX7");
                lbxRent.Items.Add("Honda Integra");
                lbxRent.Items.Add("Peugeot 106");
            }
            else if (lbxCarCap.SelectedItem == "3+" && lbxPriceList.SelectedItem == "0 - 200")
            {
                lbxRent.Items.Clear();
                lbxRent.Items.Add("Mazda");
                lbxRent.Items.Add("Hyundai");
                lbxRent.Items.Add("Toyota Corolla (Eski)");
                lbxRent.Items.Add("Wolkwagen Transporter (Eski)");

            }
            else if (lbxCarCap.SelectedItem == "1 - 2" && lbxPriceList.SelectedItem == "200 - 500")
            {
                lbxRent.Items.Clear();
                lbxRent.Items.Add("Mini Cooper");
                lbxRent.Items.Add("Peugeot 307");
                lbxRent.Items.Add("Sandking");
            }
            else if (lbxCarCap.SelectedItem == "3+" && lbxPriceList.SelectedItem == "200 - 500")
            {
                lbxRent.Items.Clear();
                lbxRent.Items.Add("Mazda RX8");
                lbxRent.Items.Add("Honda Civic");
                lbxRent.Items.Add("Audi A3");
                lbxRent.Items.Add("Toyota Corolla (Yeni)");
                lbxRent.Items.Add("Wolkwagen Transporter(Yeni)");
                lbxRent.Items.Add("Mercedes Vito (Eski)");

            }
            else if (lbxCarCap.SelectedItem == "1 - 2" && lbxPriceList.SelectedItem == "500+")
            {
                lbxRent.Items.Clear();
                lbxRent.Items.Add("Lamborghini");
                lbxRent.Items.Add("Lexus");
                lbxRent.Items.Add("Ferrrari");
                lbxRent.Items.Add("Audi R9");
                lbxRent.Items.Add("Bugatti");
            }
            else if (lbxCarCap.SelectedItem == "3+" && lbxPriceList.SelectedItem == "500+")
            {
                lbxRent.Items.Clear();
                lbxRent.Items.Add("Bentley");
                lbxRent.Items.Add("Rolls Royce");
                lbxRent.Items.Add("Mercedes C180");
                lbxRent.Items.Add("Audi A8");
                lbxRent.Items.Add("Volvo S90");
                lbxRent.Items.Add("Mercedes Vito (Yeni)");

            }
        }

        private void lblCarModel_Click(object sender, EventArgs e)
        {

        }

        private void lbxCarCap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lbxRent.SelectedItem.ToString() + " marka aracınız başarı ile kiralandı.");
            btnConfirm.Enabled = false;
        }
    }
}