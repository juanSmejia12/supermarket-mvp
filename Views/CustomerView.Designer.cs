namespace Supermarket_mvp.Views
{
    partial class CustomerView
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageCustomerList = new TabPage();
            DgCustomer = new DataGridView();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageCustomerDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            label5 = new Label();
            TxtCustomerId = new TextBox();
            label3 = new Label();
            BtnNew = new Button();
            BtnSearch = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnClose = new Button();
            label4 = new Label();
            TxtDocumentNumber = new TextBox();
            label8 = new Label();
            TxtFirstName = new TextBox();
            label9 = new Label();
            TxtLastName = new TextBox();
            label10 = new Label();
            TxtAddress = new TextBox();
            label6 = new Label();
            DtpBirthday = new DateTimePicker();
            label7 = new Label();
            TxtPhoneNumber = new TextBox();
            label11 = new Label();
            TxtEmail = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCustomerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomer).BeginInit();
            tabPageCustomerDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(907, 140);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cliente;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(180, 40);
            label1.Name = "label1";
            label1.Size = new Size(205, 54);
            label1.TabIndex = 1;
            label1.Text = "Customer";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCustomerList);
            tabControl1.Controls.Add(tabPageCustomerDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 140);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(907, 511);
            tabControl1.TabIndex = 3;
            // 
            // tabPageCustomerList
            // 
            tabPageCustomerList.Controls.Add(BtnClose);
            tabPageCustomerList.Controls.Add(BtnDelete);
            tabPageCustomerList.Controls.Add(BtnEdit);
            tabPageCustomerList.Controls.Add(BtnSearch);
            tabPageCustomerList.Controls.Add(BtnNew);
            tabPageCustomerList.Controls.Add(DgCustomer);
            tabPageCustomerList.Controls.Add(TxtSearch);
            tabPageCustomerList.Controls.Add(label2);
            tabPageCustomerList.Location = new Point(4, 34);
            tabPageCustomerList.Name = "tabPageCustomerList";
            tabPageCustomerList.Padding = new Padding(3);
            tabPageCustomerList.Size = new Size(899, 473);
            tabPageCustomerList.TabIndex = 0;
            tabPageCustomerList.Text = "Customer List";
            tabPageCustomerList.UseVisualStyleBackColor = true;
            // 
            // DgCustomer
            // 
            DgCustomer.AllowUserToAddRows = false;
            DgCustomer.AllowUserToDeleteRows = false;
            DgCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCustomer.Location = new Point(3, 71);
            DgCustomer.Name = "DgCustomer";
            DgCustomer.ReadOnly = true;
            DgCustomer.RowHeadersWidth = 62;
            DgCustomer.Size = new Size(754, 394);
            DgCustomer.TabIndex = 5;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(9, 34);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(724, 31);
            TxtSearch.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 6);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 2;
            label2.Text = "Search Product";
            // 
            // tabPageCustomerDetail
            // 
            tabPageCustomerDetail.Controls.Add(TxtEmail);
            tabPageCustomerDetail.Controls.Add(label11);
            tabPageCustomerDetail.Controls.Add(TxtPhoneNumber);
            tabPageCustomerDetail.Controls.Add(label7);
            tabPageCustomerDetail.Controls.Add(DtpBirthday);
            tabPageCustomerDetail.Controls.Add(label6);
            tabPageCustomerDetail.Controls.Add(TxtAddress);
            tabPageCustomerDetail.Controls.Add(label10);
            tabPageCustomerDetail.Controls.Add(TxtLastName);
            tabPageCustomerDetail.Controls.Add(label9);
            tabPageCustomerDetail.Controls.Add(TxtFirstName);
            tabPageCustomerDetail.Controls.Add(label8);
            tabPageCustomerDetail.Controls.Add(TxtDocumentNumber);
            tabPageCustomerDetail.Controls.Add(label4);
            tabPageCustomerDetail.Controls.Add(BtnCancel);
            tabPageCustomerDetail.Controls.Add(BtnSave);
            tabPageCustomerDetail.Controls.Add(label5);
            tabPageCustomerDetail.Controls.Add(TxtCustomerId);
            tabPageCustomerDetail.Controls.Add(label3);
            tabPageCustomerDetail.Location = new Point(4, 34);
            tabPageCustomerDetail.Name = "tabPageCustomerDetail";
            tabPageCustomerDetail.Padding = new Padding(3);
            tabPageCustomerDetail.Size = new Size(899, 473);
            tabPageCustomerDetail.TabIndex = 1;
            tabPageCustomerDetail.Text = "Customer Detail";
            tabPageCustomerDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(176, 411);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(112, 53);
            BtnCancel.TabIndex = 15;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(20, 411);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(112, 53);
            BtnSave.TabIndex = 8;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 173);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 9;
            // 
            // TxtCustomerId
            // 
            TxtCustomerId.Location = new Point(8, 31);
            TxtCustomerId.Name = "TxtCustomerId";
            TxtCustomerId.ReadOnly = true;
            TxtCustomerId.Size = new Size(209, 31);
            TxtCustomerId.TabIndex = 3;
            TxtCustomerId.Text = "0";
            TxtCustomerId.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 6);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 2;
            label3.Text = "Customer Id";
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(763, 71);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(128, 59);
            BtnNew.TabIndex = 7;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(739, 14);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(43, 51);
            BtnSearch.TabIndex = 8;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(763, 136);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(128, 59);
            BtnEdit.TabIndex = 9;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(763, 201);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(128, 59);
            BtnDelete.TabIndex = 10;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(763, 266);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(128, 59);
            BtnClose.TabIndex = 11;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 86);
            label4.Name = "label4";
            label4.Size = new Size(165, 25);
            label4.TabIndex = 16;
            label4.Text = "Document Number";
            // 
            // TxtDocumentNumber
            // 
            TxtDocumentNumber.Location = new Point(10, 114);
            TxtDocumentNumber.Name = "TxtDocumentNumber";
            TxtDocumentNumber.PlaceholderText = "Document Number";
            TxtDocumentNumber.Size = new Size(412, 31);
            TxtDocumentNumber.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(465, 86);
            label8.Name = "label8";
            label8.Size = new Size(97, 25);
            label8.TabIndex = 18;
            label8.Text = "First Name";
            // 
            // TxtFirstName
            // 
            TxtFirstName.Location = new Point(465, 114);
            TxtFirstName.Name = "TxtFirstName";
            TxtFirstName.PlaceholderText = "First Name";
            TxtFirstName.Size = new Size(412, 31);
            TxtFirstName.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 170);
            label9.Name = "label9";
            label9.Size = new Size(95, 25);
            label9.TabIndex = 20;
            label9.Text = "Last Name";
            // 
            // TxtLastName
            // 
            TxtLastName.Location = new Point(13, 198);
            TxtLastName.Name = "TxtLastName";
            TxtLastName.PlaceholderText = "Last Number";
            TxtLastName.Size = new Size(412, 31);
            TxtLastName.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(465, 173);
            label10.Name = "label10";
            label10.Size = new Size(77, 25);
            label10.TabIndex = 22;
            label10.Text = "Address";
            // 
            // TxtAddress
            // 
            TxtAddress.Location = new Point(465, 198);
            TxtAddress.Name = "TxtAddress";
            TxtAddress.PlaceholderText = "Address";
            TxtAddress.Size = new Size(412, 31);
            TxtAddress.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 255);
            label6.Name = "label6";
            label6.Size = new Size(77, 25);
            label6.TabIndex = 24;
            label6.Text = "Birthday";
            // 
            // DtpBirthday
            // 
            DtpBirthday.Format = DateTimePickerFormat.Custom;
            DtpBirthday.Location = new Point(13, 283);
            DtpBirthday.Name = "DtpBirthday";
            DtpBirthday.Size = new Size(300, 31);
            DtpBirthday.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(465, 255);
            label7.Name = "label7";
            label7.Size = new Size(132, 25);
            label7.TabIndex = 26;
            label7.Text = "Phone Number";
            // 
            // TxtPhoneNumber
            // 
            TxtPhoneNumber.Location = new Point(465, 285);
            TxtPhoneNumber.Name = "TxtPhoneNumber";
            TxtPhoneNumber.PlaceholderText = "Phone Number";
            TxtPhoneNumber.Size = new Size(412, 31);
            TxtPhoneNumber.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 346);
            label11.Name = "label11";
            label11.Size = new Size(54, 25);
            label11.TabIndex = 28;
            label11.Text = "Email";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(13, 374);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.PlaceholderText = "Email";
            TxtEmail.Size = new Size(412, 31);
            TxtEmail.TabIndex = 29;
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 651);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CustomerView";
            Text = "CustomerView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCustomerList.ResumeLayout(false);
            tabPageCustomerList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomer).EndInit();
            tabPageCustomerDetail.ResumeLayout(false);
            tabPageCustomerDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageCustomerList;
        private DataGridView DgCustomer;
        private TextBox TxtSearch;
        private Label label2;
        private TabPage tabPageCustomerDetail;
        private Button BtnCancel;
        private Button BtnSave;
        private Label label5;
        private TextBox TxtCustomerId;
        private Label label3;
        private Button BtnNew;
        private Button BtnSearch;
        private Button BtnEdit;
        private Button BtnDelete;
        private Button BtnClose;
        private TextBox TxtFirstName;
        private Label label8;
        private TextBox TxtDocumentNumber;
        private Label label4;
        private TextBox TxtEmail;
        private Label label11;
        private TextBox TxtPhoneNumber;
        private Label label7;
        private DateTimePicker DtpBirthday;
        private Label label6;
        private TextBox TxtAddress;
        private Label label10;
        private TextBox TxtLastName;
        private Label label9;
    }
}