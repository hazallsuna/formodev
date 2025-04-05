using WinFormsApp1.SOLID;

namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPaymentMethod = new Label();
            cmbPaymentMethod = new ComboBox();
            lblAmount = new Label();
            txtMessage = new TextBox();
            btnPay = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Location = new Point(384, 91);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(116, 20);
            lblPaymentMethod.TabIndex = 0;
            lblPaymentMethod.Text = "Ödeme Yöntemi";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Items.AddRange(new object[] { "CreditCard", "Cash", "Bitcoin" });
            cmbPaymentMethod.Location = new Point(582, 91);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(151, 28);
            cmbPaymentMethod.TabIndex = 1;
            cmbPaymentMethod.SelectedIndexChanged += cmbPaymentMethod_SelectedIndexChanged;

            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(384, 212);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(43, 20);
            lblAmount.TabIndex = 2;
            lblAmount.Text = "Tutar";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(582, 205);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(151, 27);
            txtMessage.TabIndex = 3;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(596, 272);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(117, 45);
            btnPay.TabIndex = 4;
            btnPay.Text = "Ödeme Yapınız";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;

            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(384, 365);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(56, 20);
            lblResult.TabIndex = 5;
            lblResult.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnPay);
            Controls.Add(txtMessage);
            Controls.Add(lblAmount);
            Controls.Add(cmbPaymentMethod);
            Controls.Add(lblPaymentMethod);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPaymentMethod;
        private ComboBox cmbPaymentMethod;
        private Label lblAmount;
        private TextBox txtMessage;
        private Button btnPay;
        private Label lblResult;
    }
}
