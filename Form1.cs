namespace Winform.userDefineFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string firstname;
        string lastname;
        string username;
        string password;
        private void checkfirstname()
        {
            firstname = textBox1.Text;
            if (string.IsNullOrWhiteSpace(firstname))
            {
                MessageBox.Show("กำหนดไม่ไห้เป้นค่าว่าง");
                textBox1.Focus();
                return;
            }
            if (firstname.Length < 2)
            {
                MessageBox.Show("กำหนดไห้ชื่อต้องมีความยาวอย่างน้อย 2 ตัวอักษร");
                textBox1.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //checkfirstname();
            //checklastname();
            firstname = textBox1.Text;
            lastname = textBox5.Text;
            checkName(firstname);
            checkName(lastname);
            checkusername();
            checkpassword(textBox3, textBox4);
        }
        private void checklastname()
        {
            lastname = textBox5.Text;
            if (string.IsNullOrWhiteSpace(lastname))
            {
                MessageBox.Show("กำหนดไม่ไห้เป้นค่าว่าง");
                textBox1.Focus();
                return;
            }
            if (lastname.Length < 2)
            {
                MessageBox.Show("กำหนดไห้นามสกุลต้องมีความยาวอย่างน้อย 2 ตัวอักษร");
                textBox1.Focus();
            }

        }
        private void checkusername()
        {
            username = textBox2.Text;
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("กำหนดไม่ไห้เป้นค่าว่าง");
                textBox1.Focus();
                return;
            }
            if (username.Length > 20)
            {
                MessageBox.Show("กำหนดไห้ชื่อผู้ใชงานต้องมีความยาวอย่างน้อย 20 ตัวอักษร");
                textBox1.Focus();
            }
        }

        private void checkName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("กำหนดไม่ไห้เป้นค่าว่าง");
                textBox1.Focus();
                return;
            }
            if (name.Length < 2)
            {
                MessageBox.Show("กำหนดไห้ชื่อต้องมีความยาวอย่างน้อย 2 ตัวอักษร");
                textBox1.Focus();
            }
        }

        private void checkpassword(TextBox pessword, TextBox confirmPassword)
        {
            password = textBox3.Text;
            if (string.IsNullOrWhiteSpace(pessword.Text) || string.IsNullOrWhiteSpace(confirmPassword.Text))
            {
                MessageBox.Show("กำหนดไม่ไห้เป้นค่าว่าง");
                textBox1.Focus();
                return;
            }
            if (password.Length < 8)
			{
                MessageBox.Show("กำหนดไห้รหัสผ่านต้องมีความยาวอย่างน้อย 8 ตัวอักษร");
                textBox1.Focus();
            }
            if (pessword.Text != confirmPassword.Text)
            {
                MessageBox.Show("รหัสผ่านไม่ตรงกัน");
                textBox1.Focus();
            }
        }

    }
}




