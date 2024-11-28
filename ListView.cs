namespace BaiTap
{
    public partial class fListView : Form
    {
        public fListView()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem newitem = new ListViewItem(txtFirstname.Text);
            newitem.SubItems.Add(txtLastName.Text);
            newitem.SubItems.Add(txtPhone.Text);
            f_listView.Items.Add(newitem);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (f_listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một mục để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selectedItem = f_listView.SelectedItems[0];

            selectedItem.Text = txtFirstname.Text;
            selectedItem.SubItems[1].Text = txtLastName.Text;
            selectedItem.SubItems[2].Text = txtPhone.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (f_listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa mục này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                foreach (ListViewItem item in f_listView.SelectedItems)
                {
                    f_listView.Items.Remove(item);
                }
            }
        }

        private void fListView_Click(object sender, EventArgs e)
        {
            if (f_listView.SelectedIndices.Count > 0)
            {
                txtFirstname.Text = f_listView.SelectedItems[0].SubItems[0].Text;
                txtLastName.Text = f_listView.SelectedItems[0].SubItems[1].Text;
                txtPhone.Text = f_listView.SelectedItems[0].SubItems[2].Text;
            }
        }
    }
}
