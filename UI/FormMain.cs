using DAL;

using System;
using System.Data;
using System.Windows.Forms;

namespace UI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private MaterielPartitionDAL partitionDal = new MaterielPartitionDAL();
        private MaterielInfoDAL infoDal = new MaterielInfoDAL();
        private static AddForm addForm;

        /// <summary>
        /// 显示主窗体数据
        /// </summary>
        private void ShowMasager()
        {
            //显示分类数据
            listBox1.DataSource = partitionDal.FindPartition();
            listBox1.DisplayMember = "PName";
            listBox1.ValueMember = "ID";
            //listBox1.SelectedIndex = 0;

            //这里给list赋值的是一个DataRowView 类型的数据
            DataRowView drView = (DataRowView)listBox1.SelectedItem;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = partitionDal.FindByPartition(Convert.ToInt32(drView["ID"]));

        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            ShowMasager();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = partitionDal.FindByPartition(Convert.ToInt32(listBox1.SelectedValue));
        }
        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow drvRow = dataGridView1.CurrentRow;
            if (addForm == null || addForm.IsDisposed)
            {
                addForm = new AddForm(drvRow);
                addForm.Show();

            }
            addForm.Focus();



        }
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow drvRow = dataGridView1.CurrentRow;
            string mid = drvRow.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("确定删除数据吗？", "确认框", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bool flag = infoDal.DeleteInfo(mid);
                if (flag)
                {
                    MessageBox.Show("数据已删除");

                }
                else
                {
                    MessageBox.Show("数据删除失败");

                }
            }

        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            ShowMasager();
            if (this.dataGridView1.SelectedRows.Count == 0)
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
                button3.Enabled = true;
            }
        }
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddOpen_Click(object sender, EventArgs e)
        {
            //打开窗体
            if (addForm == null || addForm.IsDisposed)
            {
                addForm = new AddForm("add");
                addForm.Show();
            }
            addForm.Focus();

            //添加界面的属性
            addForm.Text = "添加页面";

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 0)
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
                button3.Enabled = true;
            }
        }
    }
}
