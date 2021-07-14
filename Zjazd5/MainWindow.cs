using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Zjazd5
{
    public partial class mainWindow : Form
    {
        List<User> Users = new List<User>();

        static int Id = 1;

        public mainWindow()
        {
            InitializeComponent();
        }


        private void butReg_Click(object sender, EventArgs e)
        {
            string message = "Udało się poprawnie dodać użytkownika do bazy";
            string caption = "Popraw dane";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;


            if (string.IsNullOrEmpty(textBoxReg.Text) == false)
            {
                if ((string.IsNullOrEmpty(textBoxRegPass.Text) && string.IsNullOrEmpty(textBoxRegPassConf.Text)) == false)
                {
                    if (string.Equals(textBoxRegPass.Text, textBoxRegPassConf.Text) == true)
                    {
                        if (checkBoxRodo.CheckState == CheckState.Checked)
                        {
                            Users.Add(new User() { Id = Id++, Login = textBoxReg.Text, Password = textBoxRegPass.Text });

                            caption = "Pomyślnie zakończono";
                            result = MessageBox.Show(message, caption, buttons);
                            textBoxReg.Clear();
                            textBoxRegPass.Clear();
                            textBoxRegPassConf.Clear();
                            checkBoxRodo.CheckState = CheckState.Unchecked;

                        }
                        else
                        {
                            message = "Brakuje zgody na przetwarzanie danych osobwych";
                            result = MessageBox.Show(message, caption, buttons);
                        }
                    }
                    else
                    {
                        message = "Hasła nie są takie same";
                        result = MessageBox.Show(message, caption, buttons);
                    }

                }
                else
                {
                    message = "Hasło nie może być puste";
                    result = MessageBox.Show(message, caption, buttons);
                }
            }
            else
            {
                message = "Login nie może być pusty";
                result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void butLog_Click(object sender, EventArgs e)
        {
            string message = "Poprawnie zalogowano";
            string caption = "Sukces";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;


            if (CheckUser())
            {
                result = MessageBox.Show(message, caption, buttons);
                textBoxLog.Clear();
                textBoxLogPass.Clear();

            }
            else
            {
                message = "Błędne dane logowania, popraw dane";
                caption = "Popraw dane";
                result = MessageBox.Show(message, caption, buttons);
                textBoxLog.Clear();
                textBoxLogPass.Clear();
            }

        }

        private bool CheckUser()
        {
            var check = Users.ToList().Where(x => x.Login == textBoxLog.Text && x.Password == textBoxLogPass.Text);
            if (check.ToList().Capacity > 0) return true;
            else return false;
        }
    }
}
