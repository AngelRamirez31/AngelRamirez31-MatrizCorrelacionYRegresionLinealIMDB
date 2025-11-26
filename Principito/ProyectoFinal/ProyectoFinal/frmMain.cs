using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing; 
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class frmMain : Form
    {
        // CONNECTION STRING
        private string conString = "Server=LAPTOPDEALEX\\ANGELSERVER;Database=IMDBProyecto;Trusted_Connection=True;";

        public frmMain()
        {
            InitializeComponent();
        }
        // Este evento se ejecuta apenas abres el programa
        private void frmMain_Load(object sender, EventArgs e)
        {
            CargarDatosEnTabla(); // Trae los datos de SQL
            MostrarModoTabla();   // Muestra tabla
        }

        // Muestra la tabla y esconde el gráfico
        private void MostrarModoTabla()
        {
            dgvDatos.Visible = true;
            picMain.Visible = false;
            this.Text = "Proyecto IMDB - Explorador de Datos";
        }

        // Muestra el gráfico y esconde la tabla
        private void MostrarModoGrafico()
        {
            dgvDatos.Visible = false;
            picMain.Visible = true;
        }
        private void CargarDatosEnTabla()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    conn.Open();
                    // Traemos los primeros 1000 registros para no saturar la memoria
                    string query = "SELECT TOP 1000 orig_title AS Titulo, budget_x AS Presupuesto, revenue AS Ingresos, score AS Calif, YEAR(date_x) AS Anio FROM IMDBProyecto.dbo.imdb_movies WHERE budget_x > 0";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvDatos.DataSource = dt;
                    dgvDatos.Columns["Presupuesto"].DefaultCellStyle.Format = "C0";
                    dgvDatos.Columns["Ingresos"].DefaultCellStyle.Format = "C0";
                    dgvDatos.Columns["Titulo"].HeaderText = "Título de la Película";
                    dgvDatos.Columns["Calif"].HeaderText = "Calificación (0-100)";
                    dgvDatos.Columns["Anio"].HeaderText = "Año de Estreno";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
            }
        }

        // Botón para regresar a ver la tabla
        private void btnVerDatos_Click(object sender, EventArgs e)
        {
            MostrarModoTabla();
        }

        // Botón para explicar el proyecto 
        private void btnExplicarProyecto_Click(object sender, EventArgs e)
        {
            string titulo = "Objetivo del Proyecto";
            string explicacion = "El objetivo principal de este proyecto es desmenuzar a fondo los datos de la base de datos de IMDB.\n\n" +
                     "Queremos poner a prueba las creencias populares. La mayoría de las personas tiene hipótesis como: 'Entre más dinero gastes, más exitosa será la película' o 'Las películas con mejor calificación siempre ganan más dinero'. ¿Son estas ideas correctas o son solo mitos?\n\n" +
                     "Para descubrir la verdad, utilizamos dos herramientas estadísticas:\n\n" +
                     "1. El Detector de Relaciones (Matriz de Correlación)\n" +
                     "Primero, analizamos si las variables que la gente cree que importan realmente están conectadas entre sí.\n\n" +
                     "2. La Prueba de Fuego (Regresión Lineal)\n" +
                     "Aquí medimos la exactitud de esas hipótesis. Nuestro modelo matemático nos revela cuánto impacta realmente el presupuesto o la calidad en el éxito financiero.\n\n" +
                     "En conclusión: Transformamos suposiciones comunes en hechos comprobados con datos.";

            MessageBox.Show(explicacion, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCorrelacion_Click(object sender, EventArgs e)
        {
            MostrarModoGrafico();
            RunAnalysisAndLoadImage("sp_GetCorrelationMatrix", @"C:\Principito\matriz_correlacion_COMPLETA.png");
        }

        private void btnReg1_Click(object sender, EventArgs e)
        {
            MostrarModoGrafico(); // Ingresos vs Presupuesto
            RunAnalysisAndLoadImage("sp_GetRegression_RevenueVsBudget", @"C:\Principito\regresion_Ingresos_vs_Presupuesto.png");
        }

        private void btnReg2_Click(object sender, EventArgs e)
        {
            MostrarModoGrafico(); // Ingresos vs Score
            RunAnalysisAndLoadImage("sp_GetRegression_RevenueVsScore", @"C:\Principito\regresion_Ingresos_vs_Calificacion.png");
        }

        private void btnReg3_Click(object sender, EventArgs e)
        {
            MostrarModoGrafico(); // Score vs Presupuesto
            RunAnalysisAndLoadImage("sp_GetRegression_ScoreVsBudget", @"C:\Principito\regresion_Calificacion_vs_Presupuesto.png");
        }

        private void btnReg4_Click(object sender, EventArgs e)
        {
            MostrarModoGrafico(); // Ingresos vs Año
            RunAnalysisAndLoadImage("sp_GetRegression_RevenueVsYear", @"C:\Principito\regresion_Ingresos_vs_Anio.png");
        }

        private void btnReg5_Click(object sender, EventArgs e)
        {
            MostrarModoGrafico(); // Score vs Año (Evolución de calidad)
            RunAnalysisAndLoadImage("sp_GetRegression_ScoreVsYear", @"C:\Principito\regresion_Score_vs_Anio.png");
        }

        private void RunAnalysisAndLoadImage(string storedProcedureName, string outputImagePath)
        {
            try
            {
                this.Text = "Procesando análisis con R... por favor espere.";
                this.Cursor = Cursors.WaitCursor;

                // Limpieza de memoria de imagen anterior
                if (picMain.Image != null)
                {
                    picMain.Image.Dispose();
                    picMain.Image = null;
                }
                Application.DoEvents(); // Forzar actualización visual

                // Conexión a SQL
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(storedProcedureName, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandTimeout = 300; // 5 minutos timeout
                        cmd.ExecuteNonQuery();
                    }
                }

                // Carga de la nueva imagen (usando Bitmap para evitar bloqueo de archivo)
                using (var bmpTemp = new Bitmap(outputImagePath))
                {
                    picMain.Image = new Bitmap(bmpTemp);
                }

                this.Text = "Análisis completado.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al procesar: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        
    }
}