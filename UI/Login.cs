﻿
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

namespace UI
{
    public partial class Login : Form
    {

        string cultureInfo = Thread.CurrentThread.CurrentUICulture.Name;
        ResourceManager idioma;
        public void populateLanguageCombobox()
        {
            List<Language> dataSource = new List<Language>();
            dataSource.Add(new Language() { Name = "ingles", Value = "en-US" });
            dataSource.Add(new Language() { Name = "español", Value = "es-ES" });
            this.comboBox1.DataSource = dataSource;
            this.comboBox1.DataSource = dataSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.ValueMember = "Value";
        }
        public Login()
        {
            InitializeComponent();
            populateLanguageCombobox();
            idioma = FacadeService.Translate(cultureInfo);
            Translate();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario { Nombre = "SuperAdmin", Password = "123123123123" };

            LoginService.Register(user);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario { Nombre = textBox1.Text.Trim(), Password = textBox2.Text.Trim() };

            bool logged = LoginService.Login(user);

            if (true) //logged is the variable to determine this condition
            {
                HabitacionesHome formulario2 = new HabitacionesHome();
                formulario2.Show(); // Abre el formulario 2
                this.Hide();
            }
            else
            {
                MessageBox.Show("Verifica las credenciales");
            }

        }

        private void Translate()
        {
            this.text1.Text = idioma.GetString("Bienvenido");
            this.text2.Text = idioma.GetString("Usuario");
            this.text3.Text = idioma.GetString("Contrasenia");
            this.text4.Text = idioma.GetString("Idioma");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Language language = (Language)comboBox1.SelectedItem;
            idioma = FacadeService.Translate(language.Value);
            Translate();
        }
  
    }
}
