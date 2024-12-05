namespace Actividad_Aprendizaje_U3
{
    partial class Form1
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
            TabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lstPila = new ListBox();
            btnCima = new Button();
            btnDesapilar = new Button();
            btnApilar = new Button();
            txtPila = new TextBox();
            tabPage2 = new TabPage();
            lstCola = new ListBox();
            btnFrente = new Button();
            txtCola = new TextBox();
            btnDesencolar = new Button();
            btnEncolar = new Button();
            tabPage3 = new TabPage();
            lstLista = new ListBox();
            btnEliminar = new Button();
            txtLista = new TextBox();
            btnAgregarFinal = new Button();
            btnAgregarInicio = new Button();
            TabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(tabPage1);
            TabControl1.Controls.Add(tabPage2);
            TabControl1.Controls.Add(tabPage3);
            TabControl1.Location = new Point(12, 12);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(351, 426);
            TabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lstPila);
            tabPage1.Controls.Add(btnCima);
            tabPage1.Controls.Add(btnDesapilar);
            tabPage1.Controls.Add(btnApilar);
            tabPage1.Controls.Add(txtPila);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(343, 393);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pila";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstPila
            // 
            lstPila.FormattingEnabled = true;
            lstPila.Location = new Point(169, 19);
            lstPila.Name = "lstPila";
            lstPila.Size = new Size(150, 184);
            lstPila.TabIndex = 4;
            // 
            // btnCima
            // 
            btnCima.Location = new Point(41, 164);
            btnCima.Name = "btnCima";
            btnCima.Size = new Size(94, 29);
            btnCima.TabIndex = 3;
            btnCima.Text = "Cima";
            btnCima.UseVisualStyleBackColor = true;
            btnCima.Click += btnCima_Click;
            // 
            // btnDesapilar
            // 
            btnDesapilar.Location = new Point(41, 116);
            btnDesapilar.Name = "btnDesapilar";
            btnDesapilar.Size = new Size(94, 29);
            btnDesapilar.TabIndex = 2;
            btnDesapilar.Text = "Desapilar";
            btnDesapilar.UseVisualStyleBackColor = true;
            btnDesapilar.Click += btnDesapilar_Click;
            // 
            // btnApilar
            // 
            btnApilar.Location = new Point(41, 67);
            btnApilar.Name = "btnApilar";
            btnApilar.Size = new Size(94, 29);
            btnApilar.TabIndex = 1;
            btnApilar.Text = "Apilar";
            btnApilar.UseVisualStyleBackColor = true;
            btnApilar.Click += btnApilar_Click;
            // 
            // txtPila
            // 
            txtPila.Location = new Point(21, 19);
            txtPila.Name = "txtPila";
            txtPila.Size = new Size(125, 27);
            txtPila.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lstCola);
            tabPage2.Controls.Add(btnFrente);
            tabPage2.Controls.Add(txtCola);
            tabPage2.Controls.Add(btnDesencolar);
            tabPage2.Controls.Add(btnEncolar);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(343, 393);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cola";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstCola
            // 
            lstCola.FormattingEnabled = true;
            lstCola.Location = new Point(169, 22);
            lstCola.Name = "lstCola";
            lstCola.Size = new Size(150, 184);
            lstCola.TabIndex = 9;
            // 
            // btnFrente
            // 
            btnFrente.Location = new Point(41, 167);
            btnFrente.Name = "btnFrente";
            btnFrente.Size = new Size(94, 29);
            btnFrente.TabIndex = 8;
            btnFrente.Text = "Frente";
            btnFrente.UseVisualStyleBackColor = true;
            btnFrente.Click += btnFrente_Click;
            // 
            // txtCola
            // 
            txtCola.Location = new Point(21, 22);
            txtCola.Name = "txtCola";
            txtCola.Size = new Size(125, 27);
            txtCola.TabIndex = 5;
            // 
            // btnDesencolar
            // 
            btnDesencolar.Location = new Point(41, 119);
            btnDesencolar.Name = "btnDesencolar";
            btnDesencolar.Size = new Size(94, 29);
            btnDesencolar.TabIndex = 7;
            btnDesencolar.Text = "Desencolar";
            btnDesencolar.UseVisualStyleBackColor = true;
            btnDesencolar.Click += btnDesencolar_Click;
            // 
            // btnEncolar
            // 
            btnEncolar.Location = new Point(41, 70);
            btnEncolar.Name = "btnEncolar";
            btnEncolar.Size = new Size(94, 29);
            btnEncolar.TabIndex = 6;
            btnEncolar.Text = "Encolar";
            btnEncolar.UseVisualStyleBackColor = true;
            btnEncolar.Click += btnEncolar_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(lstLista);
            tabPage3.Controls.Add(btnEliminar);
            tabPage3.Controls.Add(txtLista);
            tabPage3.Controls.Add(btnAgregarFinal);
            tabPage3.Controls.Add(btnAgregarInicio);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(343, 393);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Lista";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // lstLista
            // 
            lstLista.FormattingEnabled = true;
            lstLista.Location = new Point(168, 26);
            lstLista.Name = "lstLista";
            lstLista.Size = new Size(150, 184);
            lstLista.TabIndex = 9;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(40, 171);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtLista
            // 
            txtLista.Location = new Point(20, 26);
            txtLista.Name = "txtLista";
            txtLista.Size = new Size(125, 27);
            txtLista.TabIndex = 5;
            // 
            // btnAgregarFinal
            // 
            btnAgregarFinal.Location = new Point(40, 123);
            btnAgregarFinal.Name = "btnAgregarFinal";
            btnAgregarFinal.Size = new Size(94, 29);
            btnAgregarFinal.TabIndex = 7;
            btnAgregarFinal.Text = "Agg Final";
            btnAgregarFinal.UseVisualStyleBackColor = true;
            btnAgregarFinal.Click += btnAgregarFinal_Click;
            // 
            // btnAgregarInicio
            // 
            btnAgregarInicio.Location = new Point(40, 74);
            btnAgregarInicio.Name = "btnAgregarInicio";
            btnAgregarInicio.Size = new Size(94, 29);
            btnAgregarInicio.TabIndex = 6;
            btnAgregarInicio.Text = "Agg Inicio";
            btnAgregarInicio.UseVisualStyleBackColor = true;
            btnAgregarInicio.Click += btnAgregarInicio_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 450);
            Controls.Add(TabControl1);
            Name = "Form1";
            Text = "Form1";
            TabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtPila;
        private TabPage tabPage3;
        private Button btnCima;
        private Button btnDesapilar;
        private Button btnApilar;
        private ListBox lstPila;
        private ListBox lstCola;
        private Button btnFrente;
        private TextBox txtCola;
        private Button btnDesencolar;
        private Button btnEncolar;
        private ListBox lstLista;
        private Button btnEliminar;
        private TextBox txtLista;
        private Button btnAgregarFinal;
        private Button btnAgregarInicio;
    }
}
