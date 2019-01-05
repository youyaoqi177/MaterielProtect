using DAL;

using System;
using System.Data;
using System.Windows.Forms;

namespace UI
{
    public partial class AddForm : Form
    {

        public AddForm()
        {
            InitializeComponent();
        }
        public AddForm(string n)
        {
            this._n = n;
            InitializeComponent();
        }
        public AddForm(DataGridViewRow drvRow)
        {

            InitializeComponent();
            //加载分类数据
            comboBox1.DataSource = partitionDal.FindPartition();
            comboBox1.DisplayMember = "PName";
            comboBox1.ValueMember = "ID";

            //加载单位数据
            cmbUnit.DataSource = unitDal.FindUnit();
            cmbUnit.DisplayMember = "UName";
            cmbUnit.ValueMember = "ID";
            textBox1.Text = drvRow.Cells[0].Value.ToString();
            tbName.Text = drvRow.Cells[1].Value.ToString();
            tbSe.Text = drvRow.Cells[5].Value.ToString();

            foreach (var item in comboBox1.Items)
            {
                DataRowView row = (DataRowView)item;
                if (row.Row.ItemArray[1].ToString() == drvRow.Cells[2].Value.ToString())
                {
                    comboBox1.SelectedItem = item;
                }
            }

            foreach (var item in cmbUnit.Items)
            {
                DataRowView row = (DataRowView)item;
                if (row.Row.ItemArray[1].ToString() == drvRow.Cells[6].Value.ToString())
                {
                    cmbUnit.SelectedItem = item;
                }
            }
            tbPuPrice.Text = drvRow.Cells[3].Value.ToString();
            tbSaPrice.Text = drvRow.Cells[4].Value.ToString();
            tbNumber.Text = drvRow.Cells[7].Value.ToString();
        }
        private string _n;
        private MaterielPartitionDAL partitionDal = new MaterielPartitionDAL();
        private UnitDAL unitDal = new UnitDAL();
        private MaterielInfoDAL mInfoDal = new MaterielInfoDAL();
        private int i = 0;

        private void butAdd_Click(object sender, EventArgs e)
        {



            //表单数据检验
            if (tbName.Text.Trim() == null || tbName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("名称不能为空");
                tbName.Focus();
                return;
            }
            if (tbPuPrice.Text.Trim() == null || tbPuPrice.Text.Trim() == string.Empty)
            {
                MessageBox.Show("数据不能为空");
                tbPuPrice.Focus();
                return;
            }
            if (tbSaPrice.Text.Trim() == null || tbSaPrice.Text.Trim() == string.Empty)
            {
                MessageBox.Show("数据不能为空");
                tbSaPrice.Focus();
                return;
            }
            if (tbNumber.Text.Trim() == null || tbNumber.Text.Trim() == string.Empty)
            {
                MessageBox.Show("数据不能为空");
                tbNumber.Focus();
                return;
            }


            //获取分类ID值
            DataRowView drv1 = (DataRowView)comboBox1.SelectedItem;
            MaterielPartition mp = new MaterielPartition()
            {
                PID = Convert.ToInt32(drv1["ID"]),
                PName = Convert.ToString(drv1["PName"])
            };
            //获取单位ID值
            DataRowView drv2 = (DataRowView)cmbUnit.SelectedItem;
            Unit unit = new Unit()
            {
                UID = Convert.ToInt32(drv2["ID"]),
                UName = Convert.ToString(drv2["UName"])
            };

            //判断是添加还是修改
            if (_n == "add")
            {
                //数据保存到实体类中
                MaterielInfo mInfo = new MaterielInfo()
                {
                    ID = textBox1.Text,
                    MName = tbName.Text,
                    Partition = mp,
                    PuPrice = Convert.ToDecimal(tbPuPrice.Text),
                    SaPrice = Convert.ToDecimal(tbSaPrice.Text),
                    unit = unit,
                    Specifications = tbSe.Text,
                    FirstDate = DateTime.Now,
                    LastDate = DateTime.Now,
                    Number = Convert.ToInt32(tbNumber.Text)
                };
                bool flag = false;
                try
                {
                    flag = mInfoDal.InsertInfo(mInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (flag == true)
                {
                    MessageBox.Show("数据添加成功");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("数据添加失败");
                    this.Focus();
                }

            }
            else
            {
                //数据保存到实体类中
                MaterielInfo mInfo = new MaterielInfo()
                {
                    MName = tbName.Text,
                    Partition = mp,
                    PuPrice = Convert.ToDecimal(tbPuPrice.Text),
                    SaPrice = Convert.ToDecimal(tbSaPrice.Text),
                    unit = unit,
                    Specifications = tbSe.Text,
                    LastDate = DateTime.Now,
                    Number = Convert.ToInt32(tbNumber.Text)
                };
                try
                {
                    bool flag = mInfoDal.UpdateInfo(mInfo, textBox1.Text);
                    if (flag == true)
                    {
                        MessageBox.Show("数据添加成功");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("数据添加失败");
                        this.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        /// <summary>
        /// 自动设置编号
        /// </summary>
        /// <returns></returns>
        private string GetCurrentMID()
        {
            long maxID = mInfoDal.GetMaxMaterielID();
            if (maxID == 0)
            {
                i++;
                string str = i.ToString().PadLeft(3, '0');
                return DateTime.Now.ToString("yyyyMMdd") + str;
            }
            else
            {
                uint maxIDMouth = Convert.ToUInt32(maxID.ToString().Substring(0, 8));
                if (maxIDMouth != Convert.ToUInt32(DateTime.Now.ToString("yyyyMMdd")))
                {
                    i++;
                    string str = i.ToString().PadLeft(3, '0');
                    return DateTime.Now.ToString("yyyyMMdd") + str;
                }
                else
                {
                    return Convert.ToString(maxID + 1);
                }
            }


        }
        private void AddForm_Load(object sender, EventArgs e)
        {
            if (_n == "add")
            {


                //加载分类数据
                comboBox1.DataSource = partitionDal.FindPartition();
                comboBox1.DisplayMember = "PName";
                comboBox1.ValueMember = "ID";
                comboBox1.SelectedIndex = 0;

                //加载单位数据
                cmbUnit.DataSource = unitDal.FindUnit();
                cmbUnit.DisplayMember = "UName";
                cmbUnit.ValueMember = "ID";
                cmbUnit.SelectedIndex = 0;

                //显示编号
                textBox1.Text = GetCurrentMID();
            }
        }

        private void tbPuPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断按键是不是要输入的类型。

            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)

            {
                e.Handled = true;
                MessageBox.Show("请输入数字或小数");
            }


            //小数点的处理。
            if ((int)e.KeyChar == 46)                           //小数点

            {
                if (tbPuPrice.Text.Length <= 0)
                    e.Handled = true;   //小数点不能在第一位

                else
                {

                    float f;

                    float oldf;

                    bool b1 = false, b2 = false;

                    b1 = float.TryParse(tbPuPrice.Text, out oldf);

                    b2 = float.TryParse(tbPuPrice.Text + e.KeyChar.ToString(), out f);

                    if (b2 == false)

                    {

                        if (b1 == true)

                            e.Handled = true;

                        else

                            e.Handled = false;

                    }

                }

            }



        }

        private void tbSaPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断按键是不是要输入的类型。

            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)

            {
                e.Handled = true;
                MessageBox.Show("请输入数字或小数");
            }


            //小数点的处理。

            if ((int)e.KeyChar == 46)                           //小数点

            {

                if (tbSaPrice.Text.Length <= 0)//小数点不能在第一位

                {
                    e.Handled = true;

                }

                else

                {

                    float f;

                    float oldf;

                    bool b1 = false, b2 = false;

                    b1 = float.TryParse(tbSaPrice.Text, out oldf);

                    b2 = float.TryParse(tbSaPrice.Text + e.KeyChar.ToString(), out f);

                    if (b2 == false)

                    {

                        if (b1 == true)

                            e.Handled = true;

                        else

                            e.Handled = false;

                    }


                }


            }

        }

        private void tbNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断按键是不是要输入的类型。

            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("请输入数字");
            }




        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
