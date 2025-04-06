using Microsoft.Data.SqlClient;

namespace WinFormsDbApp
{
    public partial class Form1 : Form
    {

        string selectedPaymentType;
        IPaymentMethod paymentMethod;
        public Form1()
        {
            InitializeComponent();
            LoadPaymentMethodsFromDatabase();
        }

        private void LoadPaymentMethodsFromDatabase()
        {
            cmbPaymentMethod.Items.Clear();

            string connStr = "Server=DESKTOP-6SJGI1P\\SQLEXPRESS;Database=PaymentDb;Trusted_Connection=True;TrustServerCertificate=True;";


            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT MethodName FROM PaymentMethods", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbPaymentMethod.Items.Add(reader.GetString(0));
                    } 
                  
                }
               
            }
           

        }

        private void btnPay_Click(object sender, EventArgs e)
        {

            PaymentFactory factory = new PaymentFactory();
            paymentMethod = factory.createPaymentMethod(selectedPaymentType);
            Payment payment = new Payment(paymentMethod);
            lblResult.Text = "Sonuç : " + payment.Pay(txtMessage.Text);
        }


        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPaymentType = cmbPaymentMethod.SelectedItem.ToString();
        }

    }
}
