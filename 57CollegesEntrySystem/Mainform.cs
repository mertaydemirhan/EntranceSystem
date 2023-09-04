using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _57CollegesEntrySystem
{
    public partial class EntrySystem : Form
    {

        public readonly string ServerAdress = ConfigurationManager.AppSettings["ServerAdress"];
        public readonly string DatabaseName = ConfigurationManager.AppSettings["DatabaseName"];
        public readonly string UsrName = ConfigurationManager.AppSettings["UsrName"];
        public readonly string Pw = ConfigurationManager.AppSettings["Pw"];
        SqlConnection baglanti;
        SqlCommand komut;

        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public int _ticks;

        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        public EntrySystem()
        {
            InitializeComponent();
            //FormBorderStyle = FormBorderStyle.None;
            TopMost = true;
            timer1.Start();
        }

        protected override void WndProc(ref Message m)
        {
            const int RESIZE_HANDLE_SIZE = 10;

            switch (m.Msg)
            {
                case 0x0084/*NCHITTEST*/ :
                    base.WndProc(ref m);

                    if ((int)m.Result == 0x01/*HTCLIENT*/)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = this.PointToClient(screenPoint);
                        if (clientPoint.Y <= RESIZE_HANDLE_SIZE)
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)13/*HTTOPLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)12/*HTTOP*/ ;
                            else
                                m.Result = (IntPtr)14/*HTTOPRIGHT*/ ;
                        }
                        else if (clientPoint.Y <= (Size.Height - RESIZE_HANDLE_SIZE))
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)10/*HTLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)2/*HTCAPTION*/ ;
                            else
                                m.Result = (IntPtr)11/*HTRIGHT*/ ;
                        }
                        else
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)16/*HTBOTTOMLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)15/*HTBOTTOM*/ ;
                            else
                                m.Result = (IntPtr)17/*HTBOTTOMRIGHT*/ ;
                        }
                    }
                    return;
            }
            base.WndProc(ref m);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- use 0x20000
                return cp;
            }
        }

        public void Ekle()
        {
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            komut = new SqlCommand
            {
                Connection = baglanti,
                CommandText = $"INSERT INTO EntryLog (UserCardID,EntryDate,UserID) VALUES ({ID.Text.Trim()},GETDATE(),(select DBO.GetCardID('"+ID.Text.Trim()+"')))"
            };

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void EntrySystem_Load(object sender, EventArgs e)
        {

            SetWindowPos(this.Handle, HWND_TOPMOST, 100, 100, 300, 300, TOPMOST_FLAGS);
            griddoldur();
            RefreshGridEditPage();
            ID.Focus();

        }

        private void RefreshGridEditPage()
        {
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            da = new SqlDataAdapter("Select * From EntrySystem.DBO.Users where IsActive=1", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Personel");
            DGVPersonalList.DataSource = ds.Tables["Personel"];
            baglanti.Close();
            DGVPersonalList.Columns[0].Visible = false;
            DGVPersonalList.Columns[3].Visible = false;
        }

        public void griddoldur()
        {
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            da = new SqlDataAdapter("Select * From EntrySystem.DBO.GetValues", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Personel");
            DGVPersonal.DataSource = ds.Tables["Personel"];
            baglanti.Close();
            DGVPersonal.Columns[0].Visible = false;
            DGVPersonal.Columns[1].Visible = false;
            DGVPersonal.Columns[2].Visible = false;
            DGVPersonal.Columns[3].HeaderText = "Name";
            DGVPersonal.Columns[4].HeaderText = "Entry Time";
            DGVPersonal.Columns[5].HeaderText = "Exit Time";
            ID.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
                string cmdTxt = $"UPDATE dbo.EntryLog SET IsDeleted=1 Where ID={DGVPersonal.CurrentRow.Cells[0].Value}";
                komut = new SqlCommand(cmdTxt, baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                griddoldur();
            }
            catch (Exception)
            {
                MessageBox.Show("This record cannot be deleted", "Delete Stopped", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ID.Text = null;
            ID.Focus();
        }

        public IList<string> UserCheck(string userId)
        {
            bool Checkvalue = false;
            List<string> ret = new List<string>();
            try
            {                
                
                foreach (DataGridViewRow row in DGVPersonal.Rows)
                {
                    if (DGVPersonal.Rows.Count <= 1) { ret.Add("False"); return ret; }
                    if (row.Cells["UserCardID"].Value == null)
                    {
                        ret.Add("False"); 
                        return ret;
                    }
                    //if(string.IsNullOrEmpty(row.Cells[2].Value.ToString())) { ret.Add("False"); return ret; } //"UserCardID"
                    if (row.Cells[2].Value.ToString() == userId)
                        {
                            Checkvalue = true;
                            ret.Add(Checkvalue.ToString());
                            ret.Add(row.Cells["ID"].Value.ToString());

                            break;
                        }
                    

                }
                if (ret.Count == 0) ret.Add("False");
                return ret;
            }catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return ret;
        }

        private void ID_KeyDown(object sender, KeyEventArgs e)
        {
            this.BringToFront();
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(ID.Text.Trim()))
                {
                    MessageBox.Show("Personal card number cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                IList<string> ExistUser = UserCheck(ID.Text.Trim());

                if (ExistUser[0] == "True")
                {
                    try
                    {
                        baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
                        string cmdTxt = $"UPDATE dbo.EntryLog SET OutDate=GETDATE() Where ID={ExistUser[1]}";
                        komut = new SqlCommand(cmdTxt, baglanti);
                        baglanti.Open();
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        griddoldur();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("This record cannot be deleted", "Delete Stopped", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
                        string cmdTxt = $"INSERT INTO dbo.EntryLog(UserCardID,UserID,EntryDate) VALUES('{ID.Text.Trim()}',(select ID from Users where UserCardID='{ID.Text.Trim()}'),GETDATE())";
                        komut = new SqlCommand(cmdTxt, baglanti);
                        baglanti.Open();
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        griddoldur();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("There is no Personal for this card id", "Entry failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                ID.Text = null;
                ID.Focus();
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            griddoldur();
            ID.Focus();
        }


        private void ID_Leave(object sender, EventArgs e)
        {
           // ID.Focus();
        }

        private void TimeCheckBuddy() // Saat 00:00 da kim var kim yoksa herkesi çıkış yaptır....
        {
            if (DGVPersonal.Rows[0].Cells[0].Value.ToString() != "")
            {
                baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
                string cmdTxt = $"UPDATE dbo.EntryLog SET OutDate=CONVERT(datetime,'{Convert.ToDateTime("18:00:00.000")}',103) Where OUTDATE IS NULL and convert(date,EntryDate,103)=CONVERT(date,GETDATE(),103)";
                komut = new SqlCommand(cmdTxt, baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                griddoldur();
            } 
                       
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblSaat.Text = DateTime.Now.ToString("HH:mm:ss");
            if(lblSaat.Text == "23:00:00") TimeCheckBuddy();

            _ticks++;

            if (_ticks % 20 == 0) {
                this.BringToFront();
                Activate();
                
                ID.Focus();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshGridEditPage();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCardID.Text.Trim()))
            {
                try
                {
                    baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
                    string cmdTxt = $"UPDATE dbo.Users SET UserCardID='{txtCardID.Text.Trim()}' Where ID={DGVPersonalList.CurrentRow.Cells[0].Value}";
                    komut = new SqlCommand(cmdTxt, baglanti);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    RefreshGridEditPage();
                }
                catch (Exception)
                {
                    MessageBox.Show("This card id cannot be updated", "Update Stopped", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!string.IsNullOrEmpty(txtPersonalName.Text.Trim()))
            {
                try
                {
                    baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
                    string cmdTxt = "UPDATE dbo.Users SET UserName='" + txtPersonalName.Text.Trim() + $"' Where ID={DGVPersonalList.CurrentRow.Cells[0].Value}";
                    komut = new SqlCommand(cmdTxt, baglanti);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    RefreshGridEditPage();
                }
                catch (Exception)
                {
                    MessageBox.Show("This personal name cannot be updated", "Update Stopped", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteEdit_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
                string cmdTxt = $"UPDATE dbo.Users SET IsActive=0 Where ID={DGVPersonalList.CurrentRow.Cells[0].Value}";
                komut = new SqlCommand(cmdTxt, baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                RefreshGridEditPage();
            }
            catch (Exception)
            {
                MessageBox.Show("This record cannot be deleted", "Delete Stopped", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddPersonal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPersonalNameAdd.Text.Trim()) || string.IsNullOrEmpty(txtPersonalCardNoAdd.Text.Trim()))
            {
                MessageBox.Show("Personal Name or Personal card number cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            try
            {
                int isActive = 0;
                if (chkActive.Checked) isActive = 1;
                baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
                string cmdTxt = "INSERT INTO dbo.Users(UserName,UserCardID,IsActive) VALUES('" + txtPersonalNameAdd.Text.Trim() + $"','{txtPersonalCardNoAdd.Text.Trim()}',{isActive})";
                komut = new SqlCommand(cmdTxt, baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                txtPersonalNameAdd.Text = null;
                txtPersonalCardNoAdd.Text = null;
                RefreshGridEditPage();


            }
            catch (Exception)
            {
                MessageBox.Show("There is something wrong. Please try again", "Adding  failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
