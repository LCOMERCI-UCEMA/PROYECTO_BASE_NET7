using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormControl = System.Windows.Forms.Control;

namespace UCEMA.Imputar_Pago.NET7
{
   partial class frmPrincipal : Form
   {
      private void LoadingON() {
         picLoading.Visible = true;
      }
      
      private void LoadingON(FormControl controlParaDeshab )
      {
         controlParaDeshab.Enabled = false;
         LoadingON();
      }

      private void LoadingON(FormControl[] controlesParaDeshab )
      {
         if (controlesParaDeshab.Length > 0)
         {  
            foreach (FormControl control in controlesParaDeshab)
            {
               control.Enabled = false;
            }
         }
         LoadingON();
      }


      private void LoadingOFF()
      {
         picLoading.Visible = false;
      }

      private void LoadingOFF(FormControl controlDeshab)
      {
         controlDeshab.Enabled = true;
         LoadingOFF();
      }

      private void LoadingOFF(FormControl[] controlesDeshab)
      {
         if (controlesDeshab.Length > 0)
         {
            foreach (FormControl control in controlesDeshab)
            {
               control.Enabled = true;
            }
         }
         LoadingOFF();
      }
   }
}