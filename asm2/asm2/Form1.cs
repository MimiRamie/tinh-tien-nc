using System.Diagnostics.Eventing.Reader;

namespace asm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtThisMonth.Enabled = false;
            txtLastMonth.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to quit";
            string title = "Exit";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFamMem.Enabled = false;
            if (comTypeCus.SelectedIndex == 0)
            {
                txtLastMonth.Enabled = true;
                txtFamMem.Enabled = true;
                txtThisMonth.Enabled = true;
            }
            else
            {
                txtLastMonth.Enabled = true;
                txtThisMonth.Enabled = true;
                txtFamMem.Enabled = false;
                txtFamMem.Text = null;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double money = 0;
            int consump = 0;
            if (comTypeCus.SelectedIndex == 0)
            {
                try
                {
                    string tempStrFamMem = txtFamMem.Text.Trim();
                    int tempFamMem = int.Parse(tempStrFamMem);
                    string tempStrThisMonth = txtThisMonth.Text.Trim();
                    int tempThisMonth = int.Parse(tempStrThisMonth);
                    string tempStrLastMonth = txtLastMonth.Text.Trim();
                    int tempLastMonth = int.Parse(tempStrLastMonth);
                }
                catch
                {
                    MessageBox.Show("Pls, Enter a number in family member text!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string strFamMem = txtFamMem.Text.Trim();
                int famMem = int.Parse(strFamMem);
                if (famMem <= 0)
                {
                    MessageBox.Show("Family member must be greater than 0", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string strThisMonth = txtThisMonth.Text.Trim();
                    int thisMonth = int.Parse(strThisMonth);
                    string strLastMonth = txtLastMonth.Text.Trim();
                    int lastMonth = int.Parse(strLastMonth);
                    if (thisMonth >= lastMonth && thisMonth - lastMonth >= 0)
                    {
                        consump = thisMonth - lastMonth;
                        double waterPerMem = consump / famMem;

                        if (waterPerMem > 0 && waterPerMem <= 10)
                        {
                            money = waterPerMem * 5973 * 1.1;
                        }
                        else if (waterPerMem >= 10 && waterPerMem <= 20)
                        {
                            money = waterPerMem * 7050 * 1.1;
                        }
                        else if (waterPerMem > 20 && waterPerMem <= 30)
                        {
                            money = waterPerMem * 8699 * 1.1;
                        }
                        else
                        {
                            money = waterPerMem * 15929 * 1.1;
                        }
                        money = Math.Round(money, 3);
                        txtResult.Text = money.ToString();
                        txtConsump.Text = consump.ToString();
                        txtSave.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Pls,check your water index", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                try
                {
                    string tempStrThisMonth = txtThisMonth.Text.Trim();
                    int tempThisMonth = int.Parse(tempStrThisMonth);
                }
                catch
                {
                    MessageBox.Show("Pls, Enter a number in this month index!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    string tempStrLastMonth = txtLastMonth.Text.Trim();
                    int tempLastMonth = int.Parse(tempStrLastMonth);
                }
                catch
                {
                    MessageBox.Show("Pls, Enter a number in last month index!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string strThisMonth = txtThisMonth.Text.Trim();
                int thisMonth = int.Parse(strThisMonth);
                string strLastMonth = txtLastMonth.Text.Trim();
                int lastMonth = int.Parse(strLastMonth);
                if (thisMonth >= lastMonth && thisMonth - lastMonth >= 0)
                {
                    if (comTypeCus.SelectedIndex == 1)
                    {
                        consump = thisMonth - lastMonth;
                        money = consump * 9955 * 1.1;
                    }
                    if (comTypeCus.SelectedIndex == 2)
                    {
                        consump = thisMonth - lastMonth;
                        money = consump * 11.615 * 1.1;
                    }
                    if (comTypeCus.SelectedIndex == 3)
                    {
                        consump = thisMonth - lastMonth;
                        money = consump * 22.068 * 1.1;
                    }
                    money = Math.Round(money, 3);
                    txtResult.Text = money.ToString();
                    txtConsump.Text = consump.ToString();
                    txtSave.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Pls,check your water index", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

        }
        private void txtNameCus_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtThisMonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv.SelectedItems.Count > 0)
            {
                var item = lv.SelectedItems[0];
                string A = item.SubItems[0].Text.Trim();
                string B = item.SubItems[1].Text.Trim();
                string C = item.SubItems[2].Text.Trim();
                string D = item.SubItems[3].Text.Trim();
                string E = item.SubItems[4].Text.Trim();
                txtNameCus.Text = A;
                comTypeCus.Text = B;
                txtFamMem.Text = C;
                txtConsump.Text = D;
                txtResult.Text = E;
            }
           
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtConsump.Clear();
            txtLastMonth.Clear();
            txtThisMonth.Clear();
            txtResult.Clear();
            txtFamMem.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lv.View = View.Details;
            lv.GridLines = true;
            lv.FullRowSelect = true;
            lv.Columns.Add("Name", 150);
            lv.Columns.Add("Customer's Type", 250);
            lv.Columns.Add("Members", 100);
            lv.Columns.Add("Consumption", 150);
            lv.Columns.Add("Money", 150);
        }

        private void txtSave_Click(object sender, EventArgs e)
        {

            ListViewItem item = new ListViewItem(txtNameCus.Text.Trim());
            item.SubItems.Add(comTypeCus.Text.Trim());
            item.SubItems.Add(txtFamMem.Text.Trim());
            item.SubItems.Add(txtConsump.Text.Trim());
            item.SubItems.Add(txtResult.Text.Trim() + "  VND");
            lv.Items.Add(item);
            txtSave.Enabled = false;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Pay pay = new Pay();
            this.Hide();
            pay.ShowDialog();
            pay.Close();
            this.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            price price = new price();
            this.Hide();
            price.ShowDialog();
            price.Close();
            this.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {


        }

        private void btnDel_Click_1(object sender, EventArgs e)
        {
            if (lv.SelectedItems.Count > 0)
            {
                // nguoi dung chon xoa 1 dong trong list view
                DialogResult dl = MessageBox.Show("Are you want to delete it?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    lv.Items.Remove(lv.SelectedItems[0]);
                }
            }
            else
            {
                MessageBox.Show("Choose data to delete", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            lv.Items.Remove(lv.SelectedItems[0]);
            ListViewItem item = new ListViewItem();
            item.Text = txtNameCus.Text.Trim();
            item.SubItems.Add(comTypeCus.Text.Trim());
            item.SubItems.Add(txtFamMem.Text.Trim());
            item.SubItems.Add(txtConsump.Text.Trim());
            item.SubItems.Add(txtResult.Text.Trim());
            lv.Items.Add(item);

            btnUp.Enabled = false;
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConsump_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
