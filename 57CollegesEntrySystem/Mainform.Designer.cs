
namespace _57CollegesEntrySystem
{
    partial class EntrySystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntrySystem));
            this.ID = new System.Windows.Forms.TextBox();
            this.DGVPersonal = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpEdit = new System.Windows.Forms.GroupBox();
            this.btnDeleteEdit = new System.Windows.Forms.Button();
            this.DGVPersonalList = new System.Windows.Forms.DataGridView();
            this.grpUserInfo = new System.Windows.Forms.GroupBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtPersonalName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCardID = new System.Windows.Forms.TextBox();
            this.btnRefreshEdit = new System.Windows.Forms.Button();
            this.grpAddNew = new System.Windows.Forms.GroupBox();
            this.btnAddPersonal = new System.Windows.Forms.Button();
            this.txtPersonalCardNoAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPersonalNameAdd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.lblTarih = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSaat = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPersonal)).BeginInit();
            this.grpEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPersonalList)).BeginInit();
            this.grpUserInfo.SuspendLayout();
            this.grpAddNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(12, 12);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(347, 38);
            this.ID.TabIndex = 0;
            this.ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_KeyDown);
            this.ID.Leave += new System.EventHandler(this.ID_Leave);
            // 
            // DGVPersonal
            // 
            this.DGVPersonal.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGVPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPersonal.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGVPersonal.Location = new System.Drawing.Point(12, 100);
            this.DGVPersonal.Name = "DGVPersonal";
            this.DGVPersonal.ReadOnly = true;
            this.DGVPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPersonal.Size = new System.Drawing.Size(347, 358);
            this.DGVPersonal.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(176, 56);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(183, 38);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Seçili hareketi Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(12, 56);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(158, 38);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grpEdit
            // 
            this.grpEdit.Controls.Add(this.btnDeleteEdit);
            this.grpEdit.Controls.Add(this.DGVPersonalList);
            this.grpEdit.Controls.Add(this.grpUserInfo);
            this.grpEdit.Controls.Add(this.btnRefreshEdit);
            this.grpEdit.Location = new System.Drawing.Point(365, 12);
            this.grpEdit.Name = "grpEdit";
            this.grpEdit.Size = new System.Drawing.Size(514, 446);
            this.grpEdit.TabIndex = 5;
            this.grpEdit.TabStop = false;
            this.grpEdit.Text = "Kullanıcı Düzenle";
            // 
            // btnDeleteEdit
            // 
            this.btnDeleteEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteEdit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteEdit.Location = new System.Drawing.Point(343, 19);
            this.btnDeleteEdit.Name = "btnDeleteEdit";
            this.btnDeleteEdit.Size = new System.Drawing.Size(151, 151);
            this.btnDeleteEdit.TabIndex = 11;
            this.btnDeleteEdit.Text = "Seçili kaydı Sil";
            this.btnDeleteEdit.UseVisualStyleBackColor = true;
            this.btnDeleteEdit.Click += new System.EventHandler(this.btnDeleteEdit_Click);
            // 
            // DGVPersonalList
            // 
            this.DGVPersonalList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGVPersonalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPersonalList.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGVPersonalList.Location = new System.Drawing.Point(9, 187);
            this.DGVPersonalList.Name = "DGVPersonalList";
            this.DGVPersonalList.ReadOnly = true;
            this.DGVPersonalList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPersonalList.Size = new System.Drawing.Size(318, 238);
            this.DGVPersonalList.TabIndex = 10;
            // 
            // grpUserInfo
            // 
            this.grpUserInfo.Controls.Add(this.btnApply);
            this.grpUserInfo.Controls.Add(this.txtPersonalName);
            this.grpUserInfo.Controls.Add(this.label2);
            this.grpUserInfo.Controls.Add(this.label1);
            this.grpUserInfo.Controls.Add(this.txtCardID);
            this.grpUserInfo.Location = new System.Drawing.Point(9, 15);
            this.grpUserInfo.Name = "grpUserInfo";
            this.grpUserInfo.Size = new System.Drawing.Size(318, 155);
            this.grpUserInfo.TabIndex = 12;
            this.grpUserInfo.TabStop = false;
            this.grpUserInfo.Text = "Değiştirilecek Bilgi";
            // 
            // btnApply
            // 
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApply.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnApply.Location = new System.Drawing.Point(193, 41);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(110, 96);
            this.btnApply.TabIndex = 8;
            this.btnApply.Text = "Değişikliği Uygula";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtPersonalName
            // 
            this.txtPersonalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonalName.Location = new System.Drawing.Point(9, 99);
            this.txtPersonalName.Name = "txtPersonalName";
            this.txtPersonalName.Size = new System.Drawing.Size(164, 38);
            this.txtPersonalName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seçili kayıt ismini değiştir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seçili kullanıcının kart numarasını güncelle";
            // 
            // txtCardID
            // 
            this.txtCardID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardID.Location = new System.Drawing.Point(9, 37);
            this.txtCardID.Name = "txtCardID";
            this.txtCardID.Size = new System.Drawing.Size(164, 38);
            this.txtCardID.TabIndex = 3;
            // 
            // btnRefreshEdit
            // 
            this.btnRefreshEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefreshEdit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnRefreshEdit.Location = new System.Drawing.Point(343, 187);
            this.btnRefreshEdit.Name = "btnRefreshEdit";
            this.btnRefreshEdit.Size = new System.Drawing.Size(151, 238);
            this.btnRefreshEdit.TabIndex = 13;
            this.btnRefreshEdit.Text = "Yenile";
            this.btnRefreshEdit.UseVisualStyleBackColor = true;
            this.btnRefreshEdit.Click += new System.EventHandler(this.button2_Click);
            // 
            // grpAddNew
            // 
            this.grpAddNew.Controls.Add(this.btnAddPersonal);
            this.grpAddNew.Controls.Add(this.txtPersonalCardNoAdd);
            this.grpAddNew.Controls.Add(this.label3);
            this.grpAddNew.Controls.Add(this.txtPersonalNameAdd);
            this.grpAddNew.Controls.Add(this.label4);
            this.grpAddNew.Controls.Add(this.chkActive);
            this.grpAddNew.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.grpAddNew.Location = new System.Drawing.Point(885, 255);
            this.grpAddNew.Name = "grpAddNew";
            this.grpAddNew.Size = new System.Drawing.Size(299, 203);
            this.grpAddNew.TabIndex = 6;
            this.grpAddNew.TabStop = false;
            this.grpAddNew.Text = "Yeni Personel Ekle";
            // 
            // btnAddPersonal
            // 
            this.btnAddPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPersonal.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddPersonal.Location = new System.Drawing.Point(9, 159);
            this.btnAddPersonal.Name = "btnAddPersonal";
            this.btnAddPersonal.Size = new System.Drawing.Size(270, 38);
            this.btnAddPersonal.TabIndex = 5;
            this.btnAddPersonal.Text = "Personel Ekle";
            this.btnAddPersonal.UseVisualStyleBackColor = true;
            this.btnAddPersonal.Click += new System.EventHandler(this.btnAddPersonal_Click);
            // 
            // txtPersonalCardNoAdd
            // 
            this.txtPersonalCardNoAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonalCardNoAdd.Location = new System.Drawing.Point(9, 118);
            this.txtPersonalCardNoAdd.Name = "txtPersonalCardNoAdd";
            this.txtPersonalCardNoAdd.Size = new System.Drawing.Size(183, 22);
            this.txtPersonalCardNoAdd.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Personel Kart Numarası";
            // 
            // txtPersonalNameAdd
            // 
            this.txtPersonalNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonalNameAdd.Location = new System.Drawing.Point(9, 65);
            this.txtPersonalNameAdd.Name = "txtPersonalNameAdd";
            this.txtPersonalNameAdd.Size = new System.Drawing.Size(177, 22);
            this.txtPersonalNameAdd.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(11, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Personel Adı";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActive.Location = new System.Drawing.Point(9, 20);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(102, 22);
            this.chkActive.TabIndex = 0;
            this.chkActive.Text = "Durumu Aktif";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarih.Location = new System.Drawing.Point(925, 43);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(65, 35);
            this.lblTarih.TabIndex = 7;
            this.lblTarih.Text = "Tarih";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaat.Location = new System.Drawing.Point(934, 88);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(56, 35);
            this.lblSaat.TabIndex = 8;
            this.lblSaat.Text = "Saat";
            // 
            // EntrySystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1193, 474);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.grpAddNew);
            this.Controls.Add(this.grpEdit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.DGVPersonal);
            this.Controls.Add(this.ID);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntrySystem";
            this.Text = "57 Colleges Entry System";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EntrySystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPersonal)).EndInit();
            this.grpEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPersonalList)).EndInit();
            this.grpUserInfo.ResumeLayout(false);
            this.grpUserInfo.PerformLayout();
            this.grpAddNew.ResumeLayout(false);
            this.grpAddNew.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.DataGridView DGVPersonal;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox grpEdit;
        private System.Windows.Forms.Button btnDeleteEdit;
        private System.Windows.Forms.DataGridView DGVPersonalList;
        private System.Windows.Forms.GroupBox grpUserInfo;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtPersonalName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCardID;
        private System.Windows.Forms.Button btnRefreshEdit;
        private System.Windows.Forms.GroupBox grpAddNew;
        private System.Windows.Forms.Button btnAddPersonal;
        private System.Windows.Forms.TextBox txtPersonalCardNoAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPersonalNameAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkActive;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTarih;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSaat;
    }
}

