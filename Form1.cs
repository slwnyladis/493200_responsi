using Npgsql;
using System.Data;
using System.Windows.Forms;


namespace responsi2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=salwanaylaadistri;Password=tHanderz1;Database=responsi2024";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);

            cbDept.Items.Add("HR");
            cbDept.Items.Add("ENG");
            cbDept.Items.Add("DEV");
            cbDept.Items.Add("PM");
            cbDept.Items.Add("FIN");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();
                    sql = @"SELECT * FROM st_insert(:_nama, :_nama_dep)";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                        cmd.Parameters.AddWithValue("_nama_dep", cbDept.Text);

                        if ((int)cmd.ExecuteScalar() == 1)
                        {
                            MessageBox.Show("Data Berhasil Ditambah", "Well Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbNama.Clear();
                            cbDept.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Delete Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();
                    sql = @"SELECT * FROM st_edit(:_id_karyawan, :_nama, :_nama_dep)";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("_id_karyawan", label3.Text);
                        cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                        cmd.Parameters.AddWithValue("_nama_dep", cbDept.Text);

                        int result = (int)cmd.ExecuteScalar();
                        if (result == 200)
                        {
                            MessageBox.Show("Data Karyawan Berhasil Diperbarui!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbNama.Clear();
                            cbDept.SelectedIndex = -1;
                        }
                        else if (result == 404)
                        {
                            MessageBox.Show("Karyawan tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Update Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();
                    sql = @"SELECT * FROM st_delete(:_id_karyawan)";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("_id_karyawan", label3.Text);

                        int result = (int)cmd.ExecuteScalar();
                        if (result == 200)
                        {
                            MessageBox.Show("Data Berhasil Terhapus", "Delete Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label3.Text = string.Empty;
                        }
                        else if (result == 404)
                        {
                            MessageBox.Show("Karyawan tidak terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Delete Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvData.Rows[e.RowIndex];
                label3.Text = r.Cells["id_karyawan"].Value.ToString();
                tbNama.Text = r.Cells["nama"].Value.ToString();
                cbDept.Text = r.Cells["nama_dep"].Value.ToString();
                tbJabatan.Text = r.Cells["nama_jabatan"].Value.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();
                    sql = "SELECT * FROM st_load()"; // Memanggil fungsi untuk memuat data
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        dt = new DataTable();
                        using (var rd = cmd.ExecuteReader())
                        {
                            dt.Load(rd); // Mengisi DataTable dengan hasil query
                        }
                        dgvData.DataSource = dt; // Menampilkan data ke DataGridView
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
