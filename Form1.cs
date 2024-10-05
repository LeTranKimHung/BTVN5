using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTVN5.Model;
namespace BTVN5
{
    public partial class Form1 : Form
    {
        StudentContextDB dbstudent = new StudentContextDB();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Student> liststudent = dbstudent.Students.ToList();
            List<Faculty> listfaculty = dbstudent.Faculties.ToList();
            FillDataCBB(listfaculty);
            FillDataDGV(liststudent);
        }
        private void FillDataCBB(List<Faculty> listfaculty)
        {
            comboBox1.DataSource = listfaculty;
            comboBox1.DisplayMember = "FacultyName";
            comboBox1.ValueMember = "FacultyID";
        }
        private void FillDataDGV(List<Student> liststudent)
        {
            dgvsv.Rows.Clear();
            foreach (var student in liststudent)
            {
                int rownew = dgvsv.Rows.Add();
                dgvsv.Rows[rownew].Cells[0].Value = student.StudentID;
                dgvsv.Rows[rownew].Cells[1].Value = student.FullName;
                dgvsv.Rows[rownew].Cells[2].Value = student.Faculty.FacultyName;
                dgvsv.Rows[rownew].Cells[3].Value = student.AverageScore;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (checkDataInput() )
            {
                if (checkIdSinhVien(txtmssv.Text) == -1)
                {
                    Student student = new Student();
                    student.StudentID =txtmssv.Text;
                    student.FullName = txthoten.Text;
                    student.FacultyID = Convert.ToInt32(comboBox1.SelectedValue.ToString());
                    student.AverageScore = Convert.ToDouble(txtdtb.Text);

                    dbstudent.Students.AddOrUpdate(student);
                    dbstudent.SaveChanges();
                    loadDGV();
                    loadForm();
                    MessageBox.Show($"Thêm sinh viên {student.FullName} vào danh sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else 
                {
                    MessageBox.Show($"Sinh viên có mã {txtmssv.Text} đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void loadForm()
        {
            txtmssv.Clear();txthoten.Clear();txtdtb.Clear();
        }
        private void loadDGV()
        {
            List<Student> newliststudent =dbstudent.Students.ToList();
            FillDataDGV(newliststudent);
        }
        private int checkIdSinhVien(string newIdSinhVien) 
        {
            int length = dgvsv.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (dgvsv.Rows[i].Cells[0].Value != null)
                    if (dgvsv.Rows[i].Cells[0].Value.ToString() == newIdSinhVien)
                            return i;
            }
            return -1;
        }
        private bool checkDataInput()
        {
            if (txtmssv.Text == "" || txthoten.Text == "" || txtdtb.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtmssv.TextLength < 5)
            {
                MessageBox.Show("Mã số sinh viên chưa nhập đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                float kq = 0;
                bool KetQua = float.TryParse(txtdtb.Text, out kq);
                if (!KetQua) 
                {
                    MessageBox.Show("Điểm trung binh sinh viên chưa nhập đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

      
        private void ReloadForm()
        {
            txtmssv.Clear(); txthoten.Clear(); txtdtb.Clear();
        }
        private void ReloadDGV()
        {
            List<Student> newliststudent = dbstudent.Students.ToList();
            FillDataDGV(newliststudent);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (checkDataInput() )
            {
                Student update = dbstudent.Students.FirstOrDefault( p => p.StudentID == txtmssv.Text );
                if (update != null)
                {
                    update.FullName = txthoten.Text;
                    update.FacultyID = Convert.ToInt32(comboBox1.SelectedValue.ToString());
                    update.AverageScore = Convert.ToDouble(txtdtb.Text);

                    dbstudent.Students.AddOrUpdate(update);
                    dbstudent.SaveChanges();
                    ReloadDGV();
                    ReloadForm();
                    MessageBox.Show($"Sửa thông tin sinh viên {update.FullName} thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên cần sửa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

       

        private void btnxoa_Click(object sender, EventArgs e)
        {          
                Student delete = dbstudent.Students.FirstOrDefault(p => p.StudentID == txtmssv.Text);
            if (delete != null)
            {
                DialogResult result = MessageBox.Show($"Bạn có đồng ý xóa sinh viên {delete.FullName}", "Thông báo",MessageBoxButtons.YesNo ,MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dbstudent.Students.Remove(delete);
                    dbstudent.SaveChanges();
                    ReloadForm();
                    ReloadDGV();
                    MessageBox.Show($"Xóa sinh viên {delete.FullName} thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else 
                {
                    return;
                }
            }
        }

        private void dgvsv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dgvsv.Rows[e.RowIndex];
                txtmssv.Text = row.Cells [0].Value.ToString();
                txthoten.Text = row.Cells [1].Value.ToString();               
                comboBox1.Text = row.Cells[2].Value.ToString();
                txtdtb.Text = row.Cells [3].Value.ToString();

            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                
                Application.Exit();
            }
            else
                return;
        }
    }
}
