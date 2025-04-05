using WinFormsApp1.SOLID;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        string selectedPaymentType;
        IPaymentMethod paymentMethod;
        public Form1()
        {
            InitializeComponent();
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

