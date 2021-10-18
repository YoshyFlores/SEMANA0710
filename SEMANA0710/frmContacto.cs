using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace SEMANA0710
{
    public partial class frmContacto : Form
    {
        private string action = "";
        public frmContacto()
        {
            InitializeComponent();
        }

        private void frmContacto_Load(object sender, EventArgs e)
        {
            //deja un tab
            tabs.TabPages.Remove(tabForm);
            //carga los datos en el datagridview
            //deshabilita los controles
            fillDataGridView();
            controlsDisable();

        }
        public void fillDataGridView()
        {
            Contacto contacto = new Contacto();
            clearDataGridView();

            dtgDataContacto.Columns.Add("contactoId", "NUMERO ID");
            dtgDataContacto.Columns.Add("nombre", "NOMBRE");
            dtgDataContacto.Columns.Add("contactoCasa_Trabajo_", "CONTACTO TRABAJO CASA");
            dtgDataContacto.Columns.Add("empresaT", "EMPRESA TRABAJO");

            //Llamando al metodo get
            MySqlDataReader dataReader = contacto.getContacto();

            //leer el resultado y mostrarlo en el datagridView
            while (dataReader.Read())
            {
                dtgDataContacto.Rows.Add(
                        dataReader.GetValue(0),
                        dataReader.GetValue(1),
                        dataReader.GetValue(2),
                        dataReader.GetValue(3));
            }
        }

        public void clearDataGridView()
        {
            dtgDataContacto.Columns.Clear();
            dtgDataContacto.Rows.Clear();

        }
        public void controlsDisable()
        {
            txtId.Enabled = false;
            txtnombre.Enabled = false;
            txtcasa.Enabled = false;
            txtempresaT.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }
        public void controlsEnable()
        {
            txtId.Enabled = true;
            txtnombre.Enabled = true;
            txtcasa.Enabled = true;
            txtempresaT.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

        }
        public void clearControls()
        {
            txtId.Text = "";
            txtnombre.Text = "";
            txtcasa.Text = "";
            txtempresaT.Text = "";

        }

        private void dtgDataContacto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tabs.TabPages.Remove(tabData);//ocultar el tab de el datagridview
            tabs.TabPages.Add(tabForm); //mostrar el formulario para los datos
            tabs.TabPages[0].Text = "EDITAR CONTACTO";

            action = "editar";
            controlsEnable();

            txtId.Visible = true;
            //se modifico
            txtId.ReadOnly = false;
            lblnumero.Visible = true;

            //cargar datos en controles

        }
       
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            ///Realizar el procedimiento de guardar
            //programar para guardardatos
            if (txtId.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Debe escribir el número", "VALIDACION",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtId.Focus(); //enviamos el enfoque a la caja de texto

            }
            else
            {
                Contacto contacto = new Contacto(); //instancia de la clase Libro
                                                    //evaluar la accion
                if (action == "Editar")
                {
                    contacto._contactoId = Convert.ToInt32(txtId.ToString());
                    contacto._contactoCasa_Trabajo = Convert.ToInt32(txtcasa.Text);

                }

              //  contacto._contactoId = txtId;
               
                contacto._nombre = txtnombre.Text;
              
               // contacto._contactoCasa_Trabajo =txtcasa;
                contacto._empresaT = txtempresaT.Text;

                string mensaje = "Esta seguro que desea guardar el registro?";
                if (MetroFramework.MetroMessageBox.Show(this, mensaje, "CONFIRMACION",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //LLAMAR AL METODO PARA GUARDAR
                    if (contacto.newEditContacto(action))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Los datos se han guardado exitosamente!",
                            "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Los datos  no se han guardado!",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    clearControls();
                    controlsDisable();
                    fillDataGridView();
                    tabs.TabPages.Remove(tabForm);
                    tabs.TabPages.Add(tabData);
                    tabs.TabPages[0].Text = "LISTA DE CONTACTOS";
                }
            }
        }



        private void btnsalir_Click(object sender, EventArgs e)
        {
            //codigo del boton salir
            string mensaje = "¿Está seguró que desea salir?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void btnNuevocontacto_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Está seguró que desea cancelar?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clearControls();
                controlsDisable();


                tabs.TabPages.Remove(tabForm);
                tabs.TabPages.Add(tabData);
                tabs.TabPages[0].Text = "LISTA DE CONTACTOS";
            }
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            tabs.TabPages.Remove(tabData);
            tabs.TabPages.Add(tabForm);
            tabs.TabPages[0].Text = "EDITAR CONTACTO";
            controlsEnable();

            txtId.Visible = true;
            txtId.ReadOnly = true;
            lblnumero.Visible = true;

            txtId.Text = dtgDataContacto.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = dtgDataContacto.CurrentRow.Cells[1].Value.ToString();
            txtcasa.Text = dtgDataContacto.CurrentRow.Cells[2].Value.ToString();
            txtempresaT.Text = dtgDataContacto.CurrentRow.Cells[3].Value.ToString();


            //enviar aaccion
            action = "edit";

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Esta seguro que desea eliminar el contacto?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "CONFIRMACION",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Contacto contacto = new Contacto();
                contacto._contactoId = Convert.ToInt32(dtgDataContacto.CurrentRow.Cells[0].Value);

                //llamado al metodo deleteBook() de la clase Book
                if (contacto.eliminarContacto())
                {
                    MetroFramework.MetroMessageBox.Show(this, "Los datos se han eliminado exitosamente!",
                        "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //actualizar datagridview
                    fillDataGridView();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Los datos  no se han podido eliminar",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        
        private void metroLink1_Click(object sender, EventArgs e)
        {
            tabs.TabPages.Add(tabForm);//mostrar el formulario
            tabs.TabPages.Remove(tabData); //ocultar el  tab del dataagridview
            tabs.TabPages[0].Text = "CONTACTO NUEVO"; //agregar texto al tab

            txtId.Visible = true;
            lblnumero.Visible = true;
            txtId.Focus(); //enviar enfoque al titulo
            action = "new";
            controlsEnable();
            clearControls();
        }
    }
}


    
      