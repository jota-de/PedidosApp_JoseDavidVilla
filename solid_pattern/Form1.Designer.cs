namespace solid_pattern
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.chkUrgente = new System.Windows.Forms.CheckBox();
            this.nudPeso = new System.Windows.Forms.NumericUpDown();
            this.nudDistancia = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelProducto = new System.Windows.Forms.Label();
            this.labelPeso = new System.Windows.Forms.Label();
            this.labelDistancia = new System.Windows.Forms.Label();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.cmbEntrega = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(470, 290);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblResultado);
            this.tabPage1.Controls.Add(this.nudPeso);
            this.tabPage1.Controls.Add(this.txtCliente);
            this.tabPage1.Controls.Add(this.labelDistancia);
            this.tabPage1.Controls.Add(this.cmbProducto);
            this.tabPage1.Controls.Add(this.labelPeso);
            this.tabPage1.Controls.Add(this.chkUrgente);
            this.tabPage1.Controls.Add(this.labelProducto);
            this.tabPage1.Controls.Add(this.nudDistancia);
            this.tabPage1.Controls.Add(this.labelCliente);
            this.tabPage1.Controls.Add(this.btnCalcular);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(462, 264);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pedido";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cmbEntrega);
            this.tabPage2.Controls.Add(this.dgvPedidos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(462, 264);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista pedidos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(203, 39);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 0;
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(203, 66);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(121, 21);
            this.cmbProducto.TabIndex = 1;
            // 
            // chkUrgente
            // 
            this.chkUrgente.AutoSize = true;
            this.chkUrgente.Location = new System.Drawing.Point(203, 105);
            this.chkUrgente.Name = "chkUrgente";
            this.chkUrgente.Size = new System.Drawing.Size(76, 17);
            this.chkUrgente.TabIndex = 2;
            this.chkUrgente.Text = "¿Urgente?";
            this.chkUrgente.UseVisualStyleBackColor = true;
            // 
            // nudPeso
            // 
            this.nudPeso.Location = new System.Drawing.Point(203, 133);
            this.nudPeso.Name = "nudPeso";
            this.nudPeso.Size = new System.Drawing.Size(120, 20);
            this.nudPeso.TabIndex = 3;
            // 
            // nudDistancia
            // 
            this.nudDistancia.Location = new System.Drawing.Point(203, 159);
            this.nudDistancia.Name = "nudDistancia";
            this.nudDistancia.Size = new System.Drawing.Size(120, 20);
            this.nudDistancia.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(204, 189);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(140, 45);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(39, 13);
            this.labelCliente.TabIndex = 7;
            this.labelCliente.Text = "Cliente";
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Location = new System.Drawing.Point(140, 74);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(50, 13);
            this.labelProducto.TabIndex = 8;
            this.labelProducto.Text = "Producto";
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Location = new System.Drawing.Point(140, 140);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(31, 13);
            this.labelPeso.TabIndex = 10;
            this.labelPeso.Text = "Peso";
            // 
            // labelDistancia
            // 
            this.labelDistancia.AutoSize = true;
            this.labelDistancia.Location = new System.Drawing.Point(140, 166);
            this.labelDistancia.Name = "labelDistancia";
            this.labelDistancia.Size = new System.Drawing.Size(51, 13);
            this.labelDistancia.TabIndex = 11;
            this.labelDistancia.Text = "Distancia";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(6, 71);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.Size = new System.Drawing.Size(450, 159);
            this.dgvPedidos.TabIndex = 13;
            // 
            // cmbEntrega
            // 
            this.cmbEntrega.FormattingEnabled = true;
            this.cmbEntrega.Location = new System.Drawing.Point(80, 32);
            this.cmbEntrega.Name = "cmbEntrega";
            this.cmbEntrega.Size = new System.Drawing.Size(121, 21);
            this.cmbEntrega.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Filtrar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(139, 227);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(14, 20);
            this.lblResultado.TabIndex = 12;
            this.lblResultado.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 305);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown nudPeso;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label labelDistancia;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.CheckBox chkUrgente;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.NumericUpDown nudDistancia;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEntrega;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label lblResultado;
    }
}

