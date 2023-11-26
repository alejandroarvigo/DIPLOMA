
using Services.Domain.Language;
using Services.Domain.Security.Composite;
using Services.Facade;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Resources;
using System.Threading;
using System.Windows.Forms;
using Domain;
using Domain.Enums;
using BLL;
using Services.DAL.i18n;
using System.Globalization;

namespace UI
{
    public partial class Login : Form, IObserver
    {
        ResourceManager idioma;

        public Login()
        {
            InitializeComponent();
            ObserverLanguage.Current.AgregarObservador(this);
            Translate();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario { Nombre = "SuperAdmin", Password = "123123123123" };

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (!verificarCampos()) return;

                Usuario user = new Usuario { NameUsuario = textBox1.Text.Trim(), Password = textBox2.Text.Trim() };

                Usuario userLogged = LoginService.Current.Login(user);

                if (userLogged != null)
                {
                    MenuPrincipal RoomHomeScreen = new MenuPrincipal(userLogged);
                    RoomHomeScreen.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Translate()
        {
            idioma = FacadeService.Translate(Thread.CurrentThread.CurrentCulture.Name);
            this.text1.Text = idioma.GetString("Bienvenido");
            this.text2.Text = idioma.GetString("Usuario");
            this.text3.Text = idioma.GetString("Contrasenia");

        }

   

        private bool verificarCampos()
        {
            if ((textBox1.Text.Length == 0) || (textBox2.Text.Length == 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        public void Actualizar()
        {
            Translate();
        }
    }
}
