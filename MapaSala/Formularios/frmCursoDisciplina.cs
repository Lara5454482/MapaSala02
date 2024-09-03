using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapaSala.DAO;

namespace MapaSala.Formularios
{
    public partial class FrmCursoDisciplina : Form
    {
        disciplinaDAO disciplinaDAO = new disciplinaDAO();
        cursoDAO cursoDAO = new cursoDAO();

        public FrmCursoDisciplina()
        {
            InitializeComponent();



            cbDisciplinas.DataSource = disciplinaDAO.PreencherComboBox();
            cbDisciplinas.DisplayMember = "Nome";
            cbDisciplinas.ValueMember = "Id";

            cbCursos.DataSource = cursoDAO.PreencherComboBox();
            cbCursos.DisplayMember = "Nome";
            cbCursos.ValueMember = "Id";


        }
    }
}