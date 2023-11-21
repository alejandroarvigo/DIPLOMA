using Services.DAL.i18n;
using Services.Domain.Language;
using Services.Domain.Security.Composite;
using Services.Facade;
using System;
using System.Collections.Generic;
using System.Resources;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class MenuPrincipal : Form, IObserver
    {
        private Usuario user;
        ResourceManager idioma;

        public MenuPrincipal(Usuario usuario)
        {
            InitializeComponent();
            this.user = usuario;
            ObserverLanguage.Current.AgregarObservador(this);
            populateLanguageCombobox();

        }

        private void ConstruirMenu()
        {

            idioma = FacadeService.Translate(Thread.CurrentThread.CurrentCulture.Name);
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Dock = DockStyle.Fill;

            foreach (Patente patente in user.Permisos)
            {
                Button button = new Button();
                button.Text = idioma.GetString(patente.FormName);
                button.Name = $"{patente.FormName}";
                button.Click += (sender, e) => AbrirFormulario(patente.FormName);
                button.Width = 120;
                button.Margin = new Padding(20);
                flowLayoutPanel.Controls.Add(button);
            }

            this.Controls.Add(flowLayoutPanel);
        }

        private void AbrirFormulario(string formName)
        {

            try
            {
                Type formType = Type.GetType($"UI.{formName}");

                if (formType != null)
                {
                    Form formulario = (Form)Activator.CreateInstance(formType);
                    formulario.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"No se pudo encontrar el formulario con el nombre: {formName}");
                }
            }
            catch (Exception ex)
            {
                FacadeService.ManageException(ex);
                MessageBox.Show($"Error al abrir el formulario: {ex.Message}");
            }
        }

        public void populateLanguageCombobox()
        {
            List<Language> dataSource = new List<Language>();
            dataSource.Add(new Language() { Name = "ingles", Value = "en-US" });
            dataSource.Add(new Language() { Name = "español", Value = "es-ES" });
            this.comboBox1.DataSource = dataSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.ValueMember = "Value";

            Language defaultLanguage = dataSource.FirstOrDefault(lang => lang.Value == user.DefaultLangague);
            if (defaultLanguage != null)
            {
                this.comboBox1.SelectedValue = defaultLanguage.Value;
            }

        }

        public void Actualizar()
        {
            Translate();
        }


        private void Translate()
        {
            foreach (Control control in this.Controls.OfType<Control>().ToList())
            {
                if (control != comboBox1 && control != lblSelect)
                {
                    this.Controls.Remove(control);
                    control.Dispose();
                }
            }

            ConstruirMenu();
        }
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Language language = (Language)comboBox1.SelectedItem;

            Thread.CurrentThread.CurrentCulture = new CultureInfo(language.Value);

            ObserverLanguage.Current.NotificarObservadores();

        }
    }
}
