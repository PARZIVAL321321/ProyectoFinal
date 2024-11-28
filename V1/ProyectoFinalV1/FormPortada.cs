namespace ProyectoFinalV1
{
    public partial class FormPortada : Form
    {
        public FormPortada()
        {
            InitializeComponent();
        }


        // Una vez que se haya apretado el boton de "Log-In" mostramos el siguiente form
        private void button_LogIn_Click(object sender, EventArgs e)
        {
            // Creamos un objeto del siguiente form a mostrar
            FormLogIn form = new FormLogIn();

            // Ocultamos el form actual en el que estamos (FormPortada)
            this.Hide();

            // Mostramos ahora el siguiente form (FormLogIn)
            form.Show();
        }
    }
}