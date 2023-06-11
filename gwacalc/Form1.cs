using Newtonsoft.Json;

namespace gwacalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_LoadAsync(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = null;
            HttpResponseMessage response = null;
            string result = null;
            dynamic post = null;
            try
            {
                client.BaseAddress = new Uri("https://api.vldz.tk/subjects/subjects");
                response = await client.GetAsync(client.BaseAddress);
                result = await response.Content.ReadAsStringAsync();
                post = Newtonsoft.Json.JsonConvert.DeserializeObject(result);

                label1.Text = post.piyu.s1;
                label2.Text = post.piyu.s2;
                label3.Text = post.piyu.s3;
                label4.Text = post.piyu.s4;
                label5.Text = post.piyu.s5;
                label6.Text = post.piyu.s6;
                label7.Text = post.piyu.s7;
                label8.Text = post.piyu.s8;

                comboBox1.Text = post.piyu.units_s1;
                comboBox2.Text = post.piyu.units_s2;
                comboBox3.Text = post.piyu.units_s3;
                comboBox4.Text = post.piyu.units_s4;
                comboBox5.Text = post.piyu.units_s5;
                comboBox6.Text = post.piyu.units_s6;
                comboBox7.Text = post.piyu.units_s7;
                comboBox8.Text = post.piyu.units_s8;

                if (post.piyu.announcement_label_isenabled == "true")
                {
                    label12.Visible = true;
                    label12.Text = post.piyu.announcement_title + post.piyu.announcement;
                }


                if (post.piyu.s1_isenabled == "false")
                {
                    comboBox1.Enabled = false;
                    comboBox9.Enabled = false;
                }

                if (post.piyu.s2_isenabled == "false")
                {
                    comboBox2.Enabled = false;
                    comboBox10.Enabled = false;
                }

                if (post.piyu.s3_isenabled == "false")
                {
                    comboBox3.Enabled = false;
                    comboBox11.Enabled = false;
                }

                if (post.piyu.s4_isenabled == "false")
                {
                    comboBox4.Enabled = false;
                    comboBox12.Enabled = false;
                }

                if (post.piyu.s5_isenabled == "false")
                {
                    comboBox5.Enabled = false;
                    comboBox13.Enabled = false;
                }

                if (post.piyu.s6_isenabled == "false")
                {
                    comboBox6.Enabled = false;
                    comboBox14.Enabled = false;
                }

                if (post.piyu.s7_isenabled == "false")
                {
                    comboBox7.Enabled = false;
                    comboBox15.Enabled = false;
                }

                if (post.piyu.s8_isenabled == "false")
                {
                    comboBox8.Enabled = false;
                    comboBox16.Enabled = false;
                }
            }

            catch (Exception ex)
            {
                DialogResult dResult = MessageBox.Show("This application is meant to be used with an internet connection, do you wish to proceed without internet?" + Environment.NewLine + Environment.NewLine + ex.Message, "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }

            
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // units
            var cbs1 = Convert.ToDouble(comboBox1.SelectedItem);
            var cbs2 = Convert.ToDouble(comboBox2.SelectedItem);
            var cbs3 = Convert.ToDouble(comboBox3.SelectedItem);
            var cbs4 = Convert.ToDouble(comboBox4.SelectedItem);
            var cbs5 = Convert.ToDouble(comboBox5.SelectedItem);
            var cbs6 = Convert.ToDouble(comboBox6.SelectedItem);
            var cbs7 = Convert.ToDouble(comboBox7.SelectedItem);
            var cbs8 = Convert.ToDouble(comboBox8.SelectedItem);

            //grade
            var grs1 = Convert.ToDouble(comboBox9.SelectedItem);
            var grs2 = Convert.ToDouble(comboBox10.SelectedItem);
            var grs3 = Convert.ToDouble(comboBox11.SelectedItem);
            var grs4 = Convert.ToDouble(comboBox12.SelectedItem);
            var grs5 = Convert.ToDouble(comboBox13.SelectedItem);
            var grs6 = Convert.ToDouble(comboBox14.SelectedItem);
            var grs7 = Convert.ToDouble(comboBox15.SelectedItem);
            var grs8 = Convert.ToDouble(comboBox16.SelectedItem);


            label11.Visible = true;

            double gwas1 = cbs1 * grs1;
            double gwas2 = cbs2 * grs2;
            double gwas3 = cbs3 * grs3;
            double gwas4 = cbs4 * grs4;
            double gwas5 = cbs5 * grs5;
            double gwas6 = cbs6 * grs6;
            double gwas7 = cbs7 * grs7;
            double gwas8 = cbs8 * grs8;


            double gwas_total = gwas1 + gwas2 + gwas3 + gwas4 + gwas5 + gwas6 + gwas7 + gwas8;

            double gwa_gsm = gwas_total / (cbs1 + cbs2 + cbs3 + cbs4 + cbs5 + cbs6 + cbs7 + cbs8);
            var gwa_final = Math.Round((gwa_gsm), 4);
            label11.Text = "GWA: " + gwa_final;

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox17.SelectedIndex == 0)
            {
                pictureBox1.Image = Properties.Resources.piyu1;
                pictureBox1.Size = new System.Drawing.Size(125, 117);
                comboBox17.Location = new System.Drawing.Point(630, 154);
            }
            else if (comboBox17.SelectedIndex == 1)
            {
                pictureBox1.Image = Properties.Resources.National_University_seal;
                pictureBox1.Size = new System.Drawing.Size(125, 138);
                comboBox17.Location = new System.Drawing.Point(630, 175);
            }
            else if (comboBox17.SelectedIndex == 2)
            {
                pictureBox1.Image = Properties.Resources.Systems_Technology_Institute;
                pictureBox1.Size = new System.Drawing.Size(125, 70);
                comboBox17.Location = new System.Drawing.Point(630, 120);
            }
            else if (comboBox17.SelectedIndex == 3)
            {
                pictureBox1.Image = Properties.Resources.DMMMSU;
                pictureBox1.Size = new System.Drawing.Size(125, 117);
                comboBox17.Location = new System.Drawing.Point(630, 154);
            }
        }
    }
}