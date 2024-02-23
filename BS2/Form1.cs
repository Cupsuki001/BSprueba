using System.Data.SqlClient;

namespace BS2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

        private void BTNcalc_Click(object sender, EventArgs e)
        {
            



            try
            {
                double exam, acum, tt;

                // Verificar si los campos están vacíos
                if (string.IsNullOrEmpty(TXBnom.Text) || string.IsNullOrEmpty(TXBapell.Text) ||
                    string.IsNullOrEmpty(MSKcarnt.Text) || string.IsNullOrEmpty(MSKacum.Text) || string.IsNullOrEmpty(MSKexam.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                // Convertir los valores de los campos
                exam = Convert.ToDouble(MSKexam.Text);
                acum = Convert.ToDouble(MSKacum.Text);

                if (acum < 0 || acum > 70)
                {
                    MessageBox.Show("No puede ser 0 o mayor a 70");
                }
                else
                {
                    if (exam < 0 || exam > 30)
                    {
                        MessageBox.Show("No puede ser 0 o mayor a 30");
                    }
                    else
                    {
                        tt = exam + acum;
                        LBLres.Text = tt.ToString();
                        MessageBox.Show("ingrese la respuesta en la nota final");
                        

                        if(LBLres.Text != TXBfinal.Text) 
                        {
                            MessageBox.Show("Tiene que ser igual");
                        }
                        else 
                        {

                            Est1 es = new Est1();
                            es.nombre = TXBnom.Text;
                            es.carnet = Convert.ToInt16(MSKcarnt.Text);
                            es.apelli = TXBapell.Text;
                            es.acum = Convert.ToInt16(MSKacum.Text);
                            es.exam = Convert.ToInt16(MSKexam.Text);
                            es.final = Convert.ToInt32(TXBfinal.Text);

                            int result = Est3.agregar(es);

                            if (result > 0)
                            {
                                MessageBox.Show("SE GUARDO");
                            }
                            else
                            {
                                MessageBox.Show("NO SE GUARDO");
                            }

                            int num = dataGridView1.Rows.Add();
                            dataGridView1.Rows[num].Cells[0].Value = MSKcarnt.Text + "U";
                            dataGridView1.Rows[num].Cells[1].Value = TXBnom.Text;
                            dataGridView1.Rows[num].Cells[2].Value = TXBapell.Text;
                            dataGridView1.Rows[num].Cells[3].Value = MSKacum.Text;
                            dataGridView1.Rows[num].Cells[4].Value = MSKexam.Text;
                            dataGridView1.Rows[num].Cells[5].Value = TXBfinal.Text;

                            TXBnom.Text = "";
                            TXBapell.Text = "";
                            MSKcarnt.Text = "";
                            MSKacum.Text = "";
                            MSKexam.Text = "";
                        }
                        
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No puede estar en blanco");
            }



        }

        private void TXBnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TXBapell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNbase_Click(object sender, EventArgs e)
        {
            int num = dataGridView1.Rows.Add();
            dataGridView1.DataSource = Est3.presentar();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {


        }

        private void TXBrefresc_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Est3.presentar();
            BTNbase.Enabled = false;
        }
    }
}