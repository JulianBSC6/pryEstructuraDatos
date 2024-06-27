using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    public partial class frmBaseDatosRepasoOperaciones : Form
    {
        public frmBaseDatosRepasoOperaciones()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVentanaPrincipal volver = new frmVentanaPrincipal();
            volver.Show();
        }
        
        private void btnListar_Click(object sender, EventArgs e)
        {
            String VarSQL = "SELECT * FROM LIBRO";
            clsBaseDatos objBD = new clsBaseDatos();

            switch (cmbOperaciones.SelectedIndex) 
            {
                case 0:
                    lblResultado.Text = cmbOperaciones.Text + ": " + "Idiomas";

                    VarSQL = "SELECT Nombre AS Idiomas " + "FROM Idioma " + "ORDER BY 1 DESC";
                    break;
                case 1:
                    lblResultado.Text = cmbOperaciones.Text + ": " + "Trae tabla libro e idioma a la vez.";

                    VarSQL = "SELECT * " + "FROM Libro, Idioma " + "WHERE Libro.IdIdioma = Idioma.IdIdioma";
                    break;
                case 2:
                    lblResultado.Text = cmbOperaciones.Text + ": " + "Libros donde el idioma sea igual a 4";
                    VarSQL = "select * from libro where ididioma " +
                            "in " +
                            "(select distinct ididioma from libro where ididioma = 4)";
                    break;
                case 3:
                    lblResultado.Text = cmbOperaciones.Text + ": " + "Libros donde la cantidad es mayor a 10";
                    
                    VarSQL =
                        "select * from libro where cantidad " +
                        "in " +
                        "(select distinct cantidad from libro where cantidad > 10)";
                    break;
                case 4:
                    lblResultado.Text = cmbOperaciones.Text + ": " + "Ordena los libros de mayor a menor segun el precio";

                    VarSQL ="select idlibro, titulo, idautor, precio from libro order by precio desc";
                    break;
                case 5:
                    lblResultado.Text = cmbOperaciones.Text + ": " + "Ordena los libros de menor a mayor segun el precio";

                    VarSQL = "select idlibro, titulo, idautor, precio from libro order by precio asc";
                    break;
                case 6:
                    lblResultado.Text = cmbOperaciones.Text + ": " + "Autores que hayan escrito algún libro del stock.";

                    VarSQL = "SELECT * " + "FROM Autor " + "WHERE IdAutor " + "IN (SELECT IdAutor FROM Libro)";

                    break;
                case 7:
                    lblResultado.Text = cmbOperaciones.Text + ": " + "Idioma de los cuales no hay ningún libro.";

                    VarSQL = "SELECT * " + "FROM Idioma " + "WHERE IdIdioma " + "NOT IN (SELECT IdIdioma FROM Libro)";

                    break;
                case 8:
                    lblResultado.Text = cmbOperaciones.Text + ": " + "Consulta que realiza una combinación implícita (combinación de estilo antiguo) entre las tablas LIBRO y AUTOR";

                    VarSQL =
                        "SELECT Titulo, Año, Nombre " +
                        "FROM LIBRO, AUTOR " +
                        "WHERE Libro.idAutor = Autor.idAutor ";
                    break;
                case 9:
                    lblResultado.Text = cmbOperaciones.Text + ": " + "Consulta que realiza una combinación implícita (combinación de estilo antiguo) entre las tablas LIBRO y PAIS";

                    VarSQL =
                        "SELECT Titulo, Año, Nombre as Pais " +
                        "FROM LIBRO, PAIS " +
                        "WHERE Libro.idPais = Pais.idPais";
                    break; 
                case 10:
                    lblResultado.Text = cmbOperaciones.Text + ": " + "Libros cuyo IdAutor sea 18.";

                    VarSQL = "SELECT * " + "FROM Libro " + "WHERE IdAutor = 18";
                    break;
                case 11:
                    lblResultado.Text = cmbOperaciones.Text + ": " + "Libros cuyo precio sea mayor a 600.";

                    VarSQL = "SELECT * " + "FROM Libro " + "WHERE Precio " + "IN " +
                             "(SELECT DISTINCT Precio " + "FROM Libro " +
                             "WHERE Precio > 600)";
                    break;
                case 12:
                    lblResultado.Text = cmbOperaciones.Text + ": " + "Proyecta una tabla con multiples atributo/columna para ver los numeros de indetificacion de autores y sus nombres de la tabla Autores";

                    VarSQL =
                        "select idautor as ID, Nombre from Autor ";
                    break;
                case 13:
                    lblResultado.Text = cmbOperaciones.Text + ": " + "Libros cuyo IdPais sea 4.";

                    VarSQL = "SELECT * " + "FROM Libro " + "WHERE IdPais = 4";
                    break;
                case 14:
                    lblResultado.Text = cmbOperaciones.Text + ": " + "Selecciona los los libros que cuyo precio es igual a 700 ";

                    VarSQL =
                        "select idlibro, titulo, precio from libro where precio = 700 ";
                    break;
                case 15:
                    lblResultado.Text = cmbOperaciones.Text + ": " + "Libros cuya cantidad en stock sea mayor a 6.";

                    VarSQL = "SELECT * " + "FROM Libro " + "WHERE Cantidad " + "IN " +
                             "(SELECT DISTINCT Cantidad " + "FROM Libro " +
                             "WHERE Cantidad > 6)";
                    break;
                case 16:
                    lblResultado.Text = cmbOperaciones.Text + ": " + "Libros cuyo precio sea mayor a 700 y haya más de 4 en stock.";

                    VarSQL = "SELECT * " + "FROM " + "(SELECT * " + "FROM Libro " +
                             "AS T1 " + "WHERE T1.Precio > 700) " + "AS T2 " +
                             "WHERE T2.Cantidad > 4";
                    break;
                case 17:
                    lblResultado.Text = cmbOperaciones.Text + ": " + "Libros cuyo precio sea mayor a 200 y haya más de 5 en stock.";

                    VarSQL = "SELECT * " + "FROM " + "(SELECT * " + "FROM Libro " +
                             "AS T1 " + "WHERE T1.Precio > 200) " + "AS T2 " +
                             "WHERE T2.Cantidad > 5";
                    break;
                case 18:
                    lblResultado.Text = cmbOperaciones.Text + ": " + "Elimina los libros mayores a 7";

                    VarSQL =
                        "select * from libro where idlibro " +
                        "not in " +
                        "(select distinct idlibro from libro where idlibro > 7) ";
                    break;
                case 19:
                    lblResultado.Text = cmbOperaciones.Text + ": " + "Proyecta una tabla con un solo atributo/columna para ver solamente los titulos de los libros";

                    VarSQL =
                        "select titulo from libro ";
                    break;
                case 20:
                    lblResultado.Text = cmbOperaciones.Text + ": " + "Proyecta una tabla con un solo atributo/columna para ver solamente los años de lanzamiento de los libros";

                    VarSQL =
                        "select año from libro ";
                    break;
            }
            objBD.Listar(dgvGrilla, VarSQL);
        }
    }
}
