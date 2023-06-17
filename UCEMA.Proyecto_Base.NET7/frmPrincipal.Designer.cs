namespace UCEMA.Imputar_Pago.NET7
{
   partial class frmPrincipal
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
         dgvResultados = new DataGridView();
         picLoading = new PictureBox();
         statusInformation = new StatusStrip();
         dlgAbrirArchivo = new OpenFileDialog();
         btnTestDB = new Button();
         ((System.ComponentModel.ISupportInitialize) dgvResultados).BeginInit();
         ((System.ComponentModel.ISupportInitialize) picLoading).BeginInit();
         SuspendLayout();
         // 
         // dgvResultados
         // 
         dgvResultados.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
         dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle1.BackColor = Color.Firebrick;
         dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
         dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
         dataGridViewCellStyle1.SelectionBackColor = Color.IndianRed;
         dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
         dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
         dgvResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
         dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dgvResultados.Location = new Point(12, 12);
         dgvResultados.Name = "dgvResultados";
         dgvResultados.RowTemplate.Height = 25;
         dgvResultados.Size = new Size(731, 429);
         dgvResultados.TabIndex = 0;
         // 
         // picLoading
         // 
         picLoading.Anchor =  AnchorStyles.Top | AnchorStyles.Right;
         picLoading.Image = Proyecto_Base.NET7.Properties.Resources.loading;
         picLoading.Location = new Point(751, 58);
         picLoading.Name = "picLoading";
         picLoading.Size = new Size(40, 40);
         picLoading.SizeMode = PictureBoxSizeMode.StretchImage;
         picLoading.TabIndex = 1;
         picLoading.TabStop = false;
         picLoading.Visible = false;
         // 
         // statusInformation
         // 
         statusInformation.Location = new Point(0, 444);
         statusInformation.Name = "statusInformation";
         statusInformation.Size = new Size(800, 22);
         statusInformation.TabIndex = 2;
         statusInformation.Text = "statusStrip1";
         // 
         // btnTestDB
         // 
         btnTestDB.Anchor =  AnchorStyles.Top | AnchorStyles.Right;
         btnTestDB.Location = new Point(751, 12);
         btnTestDB.Name = "btnTestDB";
         btnTestDB.Size = new Size(40, 40);
         btnTestDB.TabIndex = 3;
         btnTestDB.Text = "&DB";
         btnTestDB.UseVisualStyleBackColor = true;
         btnTestDB.Click += btnTestDB_Click;
         // 
         // frmPrincipal
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(800, 466);
         Controls.Add(btnTestDB);
         Controls.Add(statusInformation);
         Controls.Add(picLoading);
         Controls.Add(dgvResultados);
         Icon = (Icon) resources.GetObject("$this.Icon");
         KeyPreview = true;
         Name = "frmPrincipal";
         StartPosition = FormStartPosition.CenterScreen;
         Text = "Proyecto Base - UCEMA";
         Load += frmPrincipal_Load;
         KeyDown += frmPrincipal_KeyDown;
         ((System.ComponentModel.ISupportInitialize) dgvResultados).EndInit();
         ((System.ComponentModel.ISupportInitialize) picLoading).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private DataGridView dgvResultados;
      private PictureBox picLoading;
      private StatusStrip statusInformation;
      private OpenFileDialog dlgAbrirArchivo;
      private Button btnTestDB;
   }
}