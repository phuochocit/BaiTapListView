namespace BaiTap
{
    partial class fListView
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
            f_listView = new ListView();
            FirstName = new ColumnHeader();
            LastName = new ColumnHeader();
            Phone = new ColumnHeader();
            txtFirstname = new TextBox();
            txtLastName = new TextBox();
            txtPhone = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            SuspendLayout();
            // 
            // f_listView
            // 
            f_listView.Columns.AddRange(new ColumnHeader[] { FirstName, LastName, Phone });
            f_listView.GridLines = true;
            f_listView.Location = new Point(76, 50);
            f_listView.Name = "f_listView";
            f_listView.Size = new Size(304, 121);
            f_listView.TabIndex = 0;
            f_listView.UseCompatibleStateImageBehavior = false;
            f_listView.View = View.Details;
            // 
            // FirstName
            // 
            FirstName.Text = "FirstName";
            FirstName.Width = 100;
            // 
            // LastName
            // 
            LastName.Text = "LastName";
            LastName.Width = 100;
            // 
            // Phone
            // 
            Phone.Text = "Phone";
            Phone.Width = 100;
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(515, 50);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(210, 27);
            txtFirstname.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(515, 98);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(210, 27);
            txtLastName.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(515, 144);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(210, 27);
            txtPhone.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(140, 260);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(104, 42);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(539, 260);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(104, 42);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(340, 260);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(104, 42);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // fListView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtPhone);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstname);
            Controls.Add(f_listView);
            Name = "fListView";
            Text = "List View";
            Click += fListView_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView f_listView;
        private ColumnHeader FirstName;
        private ColumnHeader LastName;
        private ColumnHeader Phone;
        private TextBox txtFirstname;
        private TextBox txtLastName;
        private TextBox txtPhone;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
    }
}
