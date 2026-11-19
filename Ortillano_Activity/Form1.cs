using System;
using System.Windows.Forms;

namespace Ortillano_Activity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double totalSales_Danielle = 0.0;
        private double totalSales_Edward = 0.0;
        private double totalSales_Fatima = 0.0;


        private void getSalesPerson_Amount(string salesInitial, double salesAmount)
        {
            string result = "";
            result += $"Updated Total Sales:\n";

            if (salesInitial == "D")
            {
                totalSales_Danielle += salesAmount;
                result += $"  Danielle: ₱{totalSales_Danielle}";
            }
            else if (salesInitial == "E")
            {
                totalSales_Edward += salesAmount;
                result += $"  Edward: ₱{totalSales_Edward}";
            }
            else if (salesInitial == "F")
            {
                totalSales_Fatima += salesAmount;
                result += $"  Fatima: ₱{totalSales_Fatima}";
            }
            else
            {
                MessageBox.Show("Invalid Sales Person Initial. Please enter D, E, or F.");
                return;
            }

            label_Results.Text = result;

            // Clear textboxes
            textBox_salesPersonInitial.Text = "";
            textBox_AmountOfSale.Text = "";
        }

        private void clearEntry()
        {
            textBox_salesPersonInitial.Text = "";
            textBox_AmountOfSale.Text = "";
            label_Results.Text = "";
        }


        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            string salesInitial = textBox_salesPersonInitial.Text;
            double salesAmount;

            if (double.TryParse(textBox_AmountOfSale.Text, out salesAmount))
            {
                getSalesPerson_Amount(salesInitial, salesAmount);
            }
            else
            {
                MessageBox.Show("Please enter a valid number for the amount of sale.");
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            clearEntry();
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            string result = "";
            result += $"Sales:\n";
            result += $"  Danielle: ₱{totalSales_Danielle}\n";
            result += $"  Edward: ₱{totalSales_Edward}\n";
            result += $"  Fatima: ₱{totalSales_Fatima}\n";
            result += $"Total: ₱{(totalSales_Danielle + totalSales_Edward + totalSales_Fatima)}";

            MessageBox.Show(result);
        }
    }
}
