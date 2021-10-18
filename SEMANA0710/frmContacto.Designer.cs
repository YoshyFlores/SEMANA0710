
namespace SEMANA0710
{
    partial class frmContacto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabForm = new System.Windows.Forms.TabPage();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.txtempresaT = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblnumero = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcasa = new System.Windows.Forms.MaskedTextBox();
            this.txtId = new System.Windows.Forms.MaskedTextBox();
            this.tabData = new System.Windows.Forms.TabPage();
            this.metroScrollBar1 = new MetroFramework.Controls.MetroScrollBar();
            this.dtgDataContacto = new System.Windows.Forms.DataGridView();
            this.actions = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.Editar = new System.Windows.Forms.ToolStripMenuItem();
            this.Eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.tabs.SuspendLayout();
            this.tabForm.SuspendLayout();
            this.tabData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDataContacto)).BeginInit();
            this.actions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número";
            // 
            // tabs
            // 
            this.tabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabs.Controls.Add(this.tabForm);
            this.tabs.Controls.Add(this.tabData);
            this.tabs.Location = new System.Drawing.Point(12, 69);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(554, 402);
            this.tabs.TabIndex = 12;
            this.tabs.Tag = "";
            // 
            // tabForm
            // 
            this.tabForm.BackColor = System.Drawing.Color.PeachPuff;
            this.tabForm.Controls.Add(this.btnsalir);
            this.tabForm.Controls.Add(this.btnCancelar);
            this.tabForm.Controls.Add(this.btnGuardar);
            this.tabForm.Controls.Add(this.txtempresaT);
            this.tabForm.Controls.Add(this.txtnombre);
            this.tabForm.Controls.Add(this.label5);
            this.tabForm.Controls.Add(this.label4);
            this.tabForm.Controls.Add(this.lblnumero);
            this.tabForm.Controls.Add(this.label7);
            this.tabForm.Controls.Add(this.txtcasa);
            this.tabForm.Controls.Add(this.txtId);
            this.tabForm.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tabForm.Location = new System.Drawing.Point(4, 30);
            this.tabForm.Name = "tabForm";
            this.tabForm.Padding = new System.Windows.Forms.Padding(3);
            this.tabForm.Size = new System.Drawing.Size(546, 368);
            this.tabForm.TabIndex = 0;
            this.tabForm.Text = "Agregar contacto nuevo";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(385, 100);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(82, 42);
            this.btnsalir.TabIndex = 23;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(276, 261);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 49);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Salmon;
            this.btnGuardar.Location = new System.Drawing.Point(68, 261);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 49);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtempresaT
            // 
            this.txtempresaT.Location = new System.Drawing.Point(231, 189);
            this.txtempresaT.Name = "txtempresaT";
            this.txtempresaT.Size = new System.Drawing.Size(100, 24);
            this.txtempresaT.TabIndex = 20;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(231, 96);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 24);
            this.txtnombre.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Empresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Teléfono de casa";
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.Location = new System.Drawing.Point(64, 48);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(74, 20);
            this.lblnumero.TabIndex = 16;
            this.lblnumero.Text = "Número";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nombre";
            // 
            // txtcasa
            // 
            this.txtcasa.Location = new System.Drawing.Point(231, 145);
            this.txtcasa.Mask = "0000-0000";
            this.txtcasa.Name = "txtcasa";
            this.txtcasa.Size = new System.Drawing.Size(100, 24);
            this.txtcasa.TabIndex = 13;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(231, 49);
            this.txtId.Mask = "0000-0000";
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 24);
            this.txtId.TabIndex = 12;
            // 
            // tabData
            // 
            this.tabData.BackColor = System.Drawing.Color.Snow;
            this.tabData.Controls.Add(this.metroScrollBar1);
            this.tabData.Controls.Add(this.dtgDataContacto);
            this.tabData.Location = new System.Drawing.Point(4, 30);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(3);
            this.tabData.Size = new System.Drawing.Size(546, 368);
            this.tabData.TabIndex = 1;
            this.tabData.Text = "Lista de contactos";
            // 
            // metroScrollBar1
            // 
            this.metroScrollBar1.LargeChange = 10;
            this.metroScrollBar1.Location = new System.Drawing.Point(686, 118);
            this.metroScrollBar1.Maximum = 100;
            this.metroScrollBar1.Minimum = 0;
            this.metroScrollBar1.MouseWheelBarPartitions = 10;
            this.metroScrollBar1.Name = "metroScrollBar1";
            this.metroScrollBar1.Orientation = MetroFramework.Controls.MetroScrollOrientation.Vertical;
            this.metroScrollBar1.ScrollbarSize = 10;
            this.metroScrollBar1.Size = new System.Drawing.Size(10, 200);
            this.metroScrollBar1.TabIndex = 12;
            this.metroScrollBar1.UseSelectable = true;
            // 
            // dtgDataContacto
            // 
            this.dtgDataContacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDataContacto.ContextMenuStrip = this.actions;
            this.dtgDataContacto.Location = new System.Drawing.Point(22, 83);
            this.dtgDataContacto.Name = "dtgDataContacto";
            this.dtgDataContacto.RowHeadersWidth = 51;
            this.dtgDataContacto.RowTemplate.Height = 24;
            this.dtgDataContacto.Size = new System.Drawing.Size(474, 239);
            this.dtgDataContacto.TabIndex = 10;
            this.dtgDataContacto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDataContacto_CellContentClick);
            // 
            // actions
            // 
            this.actions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.actions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Editar,
            this.Eliminar});
            this.actions.Name = "actions";
            this.actions.Size = new System.Drawing.Size(133, 52);
            // 
            // Editar
            // 
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(132, 24);
            this.Editar.Text = "Editar";
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(132, 24);
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLink1.Location = new System.Drawing.Point(425, 26);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(124, 37);
            this.metroLink1.TabIndex = 14;
            this.metroLink1.Text = "Nuevo contacto";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // frmContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(592, 488);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmContacto";
            this.Text = "frmContacto";
            this.Load += new System.EventHandler(this.frmContacto_Load);
            this.tabs.ResumeLayout(false);
            this.tabForm.ResumeLayout(false);
            this.tabForm.PerformLayout();
            this.tabData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDataContacto)).EndInit();
            this.actions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabForm;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.TextBox txtempresaT;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtcasa;
        private System.Windows.Forms.MaskedTextBox txtId;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroScrollBar metroScrollBar1;
        private System.Windows.Forms.DataGridView dtgDataContacto;
        private System.Windows.Forms.Button btnsalir;
        private MetroFramework.Controls.MetroContextMenu actions;
        private System.Windows.Forms.ToolStripMenuItem Editar;
        private System.Windows.Forms.ToolStripMenuItem Eliminar;
        private MetroFramework.Controls.MetroLink metroLink1;
    }
}