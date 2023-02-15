
namespace WindowsFormsApp1
{
    partial class Conversion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.salirbutton = new System.Windows.Forms.Button();
            this.confirmarbutton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.borrarlistabutton = new System.Windows.Forms.Button();
            this.tiempotextBox = new System.Windows.Forms.TextBox();
            this.velocidadtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelarbutton = new System.Windows.Forms.Button();
            this.distanciadataGridView = new System.Windows.Forms.DataGridView();
            this.colvelocidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coldistancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colconversion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distanciadataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // salirbutton
            // 
            this.salirbutton.Location = new System.Drawing.Point(70, 345);
            this.salirbutton.Name = "salirbutton";
            this.salirbutton.Size = new System.Drawing.Size(75, 23);
            this.salirbutton.TabIndex = 0;
            this.salirbutton.Text = "SALIR";
            this.salirbutton.UseVisualStyleBackColor = true;
            this.salirbutton.Click += new System.EventHandler(this.salirbutton_Click);
            // 
            // confirmarbutton
            // 
            this.confirmarbutton.Location = new System.Drawing.Point(31, 198);
            this.confirmarbutton.Name = "confirmarbutton";
            this.confirmarbutton.Size = new System.Drawing.Size(83, 23);
            this.confirmarbutton.TabIndex = 1;
            this.confirmarbutton.Text = "CONFIRMAR";
            this.confirmarbutton.UseVisualStyleBackColor = true;
            this.confirmarbutton.Click += new System.EventHandler(this.confirmarbutton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.MistyRose;
            this.splitContainer1.Panel1.Controls.Add(this.borrarlistabutton);
            this.splitContainer1.Panel1.Controls.Add(this.tiempotextBox);
            this.splitContainer1.Panel1.Controls.Add(this.velocidadtextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cancelarbutton);
            this.splitContainer1.Panel1.Controls.Add(this.confirmarbutton);
            this.splitContainer1.Panel1.Controls.Add(this.salirbutton);
            this.splitContainer1.Panel1.UseWaitCursor = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.distanciadataGridView);
            this.splitContainer1.Panel2.UseWaitCursor = true;
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 2;
            this.splitContainer1.UseWaitCursor = true;
            // 
            // borrarlistabutton
            // 
            this.borrarlistabutton.Location = new System.Drawing.Point(109, 288);
            this.borrarlistabutton.Name = "borrarlistabutton";
            this.borrarlistabutton.Size = new System.Drawing.Size(75, 23);
            this.borrarlistabutton.TabIndex = 7;
            this.borrarlistabutton.Text = "Borrar Lista";
            this.borrarlistabutton.UseVisualStyleBackColor = true;
            this.borrarlistabutton.Click += new System.EventHandler(this.borrarlistabutton_Click);
            // 
            // tiempotextBox
            // 
            this.tiempotextBox.Location = new System.Drawing.Point(109, 109);
            this.tiempotextBox.Name = "tiempotextBox";
            this.tiempotextBox.Size = new System.Drawing.Size(100, 20);
            this.tiempotextBox.TabIndex = 6;
            // 
            // velocidadtextBox
            // 
            this.velocidadtextBox.Location = new System.Drawing.Point(109, 43);
            this.velocidadtextBox.Name = "velocidadtextBox";
            this.velocidadtextBox.Size = new System.Drawing.Size(100, 20);
            this.velocidadtextBox.TabIndex = 5;
            this.velocidadtextBox.TextChanged += new System.EventHandler(this.velocidadtextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tiempo ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Velocidad m/s";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cancelarbutton
            // 
            this.cancelarbutton.Location = new System.Drawing.Point(165, 198);
            this.cancelarbutton.Name = "cancelarbutton";
            this.cancelarbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelarbutton.TabIndex = 2;
            this.cancelarbutton.Text = "CANCELAR";
            this.cancelarbutton.UseVisualStyleBackColor = true;
            this.cancelarbutton.Click += new System.EventHandler(this.cancelarbutton_Click);
            // 
            // distanciadataGridView
            // 
            this.distanciadataGridView.AllowUserToAddRows = false;
            this.distanciadataGridView.AllowUserToDeleteRows = false;
            this.distanciadataGridView.BackgroundColor = System.Drawing.Color.Wheat;
            this.distanciadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.distanciadataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colvelocidad,
            this.coltiempo,
            this.Coldistancia,
            this.colconversion});
            this.distanciadataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.distanciadataGridView.Location = new System.Drawing.Point(0, 0);
            this.distanciadataGridView.Name = "distanciadataGridView";
            this.distanciadataGridView.ReadOnly = true;
            this.distanciadataGridView.Size = new System.Drawing.Size(530, 450);
            this.distanciadataGridView.TabIndex = 0;
            this.distanciadataGridView.UseWaitCursor = true;
            this.distanciadataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colvelocidad
            // 
            this.colvelocidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colvelocidad.HeaderText = "Velocidad m/s";
            this.colvelocidad.Name = "colvelocidad";
            this.colvelocidad.ReadOnly = true;
            // 
            // coltiempo
            // 
            this.coltiempo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coltiempo.HeaderText = "Tiempo";
            this.coltiempo.Name = "coltiempo";
            this.coltiempo.ReadOnly = true;
            // 
            // Coldistancia
            // 
            this.Coldistancia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Coldistancia.HeaderText = "Distancia m";
            this.Coldistancia.Name = "Coldistancia";
            this.Coldistancia.ReadOnly = true;
            // 
            // colconversion
            // 
            this.colconversion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colconversion.HeaderText = "Conversión km";
            this.colconversion.Name = "colconversion";
            this.colconversion.ReadOnly = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Conversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Conversion";
            this.Text = "Conversión de m a km";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.distanciadataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button salirbutton;
        private System.Windows.Forms.Button confirmarbutton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button borrarlistabutton;
        private System.Windows.Forms.TextBox tiempotextBox;
        private System.Windows.Forms.TextBox velocidadtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelarbutton;
        private System.Windows.Forms.DataGridView distanciadataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn colvelocidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coldistancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colconversion;
    }
}

