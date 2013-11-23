using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pe_Khoksung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = ("คำตอบที่คุณเลือก : " + Environment.NewLine);
            str = str + "ท่านเคยเคลมสินค้าไซเซลหรือไม่ : ";
            if (radioButton1.Checked == true)
            {
                str = str + "เคย" + Environment.NewLine;
            }
            else
            {
                str = str + "ไม่เคย" + Environment.NewLine;
            }
            str = str + "ท่านเคลมสินค้าไซเซลผ่านช่องทางใด : ";
            if (radioButton3.Checked == true)
            {
                str = str + "ร้านค้าที่ท่านซื้อสินค้า " + Environment.NewLine;
            }
            else if (radioButton4.Checked == true)
            {
                str = str + "(ZyXEL Authorized Service Point)" + Environment.NewLine;
            }
            else if (radioButton5.Checked == true)
            {
                str = str + "ตัวแทนจำหน่ายค้าส่ง (Distributor) " + Environment.NewLine;
            }
            else if (radioButton6.Checked == true)
            {
                str = str + "ตัวแทนจำหน่ายค้าส่ง (Distributor) " + Environment.NewLine;
            }
            else if (radioButton7.Checked == true)
            {
                str = str + "ส่งพัสดุไปรษณีย์มายังสำนักงานใหญ่ไซเซล " + Environment.NewLine;
            }
            else
            {
                str = str + "ส่งเคลมด้วยตนเองที่สำนักงานใหญ่ไซเซล " + Environment.NewLine;
            }
            str = str + "ท่านได้รับสินค้าเคลมหลังจากส่งเคลมภายในกี่วันโดยเฉลี่ย : ";
            if (radioButton9.Checked == true)
            {
                str = str + "ได้รับสินค้าคืนทันที" + Environment.NewLine;
            }
            else if (radioButton10.Checked == true)
            {
                str = str + "ภายใน 1-3 วัน" + Environment.NewLine;

            }
            else if (radioButton11.Checked == true)
            {
                str = str + "ภายใน 4-7 วัน" + Environment.NewLine;
            }
            else
            {
                str = str + "มากกว่า 7 วัน" + Environment.NewLine;
            }
            str = str + "ท่านพอใจกับบริการเคลมสินค้าไซเซลโดยรวมในระดับใด : ";
            if (radioButton13.Checked == true)
            {
                str = str + "มากที่สุด" + Environment.NewLine;

            }
            else if (radioButton14.Checked == true)
            {
                str = str + "มาก" + Environment.NewLine;

            }
            else if (radioButton15.Checked == true)
            {
                str = str + "ปานกลาว" + Environment.NewLine;
            }
            else if (radioButton16.Checked == true)
            {
                str = str + "น้อย" + Environment.NewLine;

            }
            else
            {
                str = str + "น้อยทีสุด" + Environment.NewLine;
            }
            MessageBox.Show(str, "แสดงผลที่คุณเลือกตอบ");
        }
    }
}
