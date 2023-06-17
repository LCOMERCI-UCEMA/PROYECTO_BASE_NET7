namespace UCEMA.Imputar_Pago.NET7
{
   partial class frmPrincipal : Form
   {
      public frmPrincipal()
      {
         InitializeComponent();
      }

      private void frmPrincipal_Load(object sender, EventArgs e)
      {
         this.KeyPreview = true;
         //this.KeyDown += new KeyEventHandler(frmPrincipal_KeyDown); // Si ya está bindeado desde el designer, acá no hace falta
      }

      private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
      {
         switch (e.KeyCode)
         {
            case Keys.Escape:
               {
                  DialogResult res = MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                  if (res == DialogResult.Yes)
                  {
                     Application.Exit();
                  }
                  break;
               }
         }
      }

      private async void btnTestDB_Click(object sender, EventArgs e)
      {
         LoadingON(btnTestDB);
         dgvResultados.DataSource = null;
         Refresh();
         dgvResultados.DataSource = await Task.Run(() =>
         {
            return Logica.Script.TraerDatos();
         });
         LoadingOFF(btnTestDB);
      }
   }
}