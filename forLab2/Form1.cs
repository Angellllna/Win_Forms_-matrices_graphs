using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace forLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool TryFillGrid(DataGridView grid, string fileName = "")
        {
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.FileName = fileName;

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return false;

            grid.Rows.Clear();
            var reader = new StreamReader(openFileDialog.FileName);
            var firstLine = reader.ReadLine();
            var row = firstLine?.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int columnCount = row?.Length ?? 0;
            if (columnCount == 0)
            {
                MessageBox.Show($"{openFileDialog.FileName} or its first line is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            grid.ColumnCount = columnCount;
            grid.Rows.Add(row);

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                
                row = Regex.Split(line, @"\s+");
                if (row.Length != columnCount)
                {
                    int lineId = grid.RowCount + 1;
                    grid.Rows.Clear();
                    grid.Columns.Clear();
                    MessageBox.Show($"Invalid data in {openFileDialog.FileName}, line {lineId}", "Error");
                    return false;
                }
                columnCount = row.Length;
                grid.Rows.Add(row);
            }

            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            return true;
        }
        private void LoadButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select data for the first matrix", "Information", MessageBoxButtons.OK);
            var isValid1 = TryFillGrid(matrixGrid, "matrix1.txt");
            var isValid2 = false;
            
            ResultButton.Enabled = СhartButton.Enabled = isValid1 && isValid2;
            saveFirstButton.Enabled = true;
        }

        private bool TryParseGrid(DataGridView grid, out int[,] matrix)
        {
            matrix = new int[grid.RowCount, grid.ColumnCount];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    try
                    {
                        matrix[i, j] = Convert.ToInt32(grid[j, i].Value);
                    }
                    catch
                    {
                        MessageBox.Show($"Invalid value in cell ({i}, {j}) of {grid.Name}");
                        grid[j, i].Selected = true;
                        return false;
                    }
                }
            }
            return true;
        }
        private void SaveFirstButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
                if (button == saveFirstButton)
                { 
                    SaveGrid(matrixGrid);
                    ResultButton.Enabled = true;
                    СhartButton.Enabled = true;
                }


        }
        private void SaveGrid(DataGridView grid)
        {
            saveFileDialog.InitialDirectory = Application.StartupPath;

            saveFileDialog.FileName = "";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (DataGridViewRow row in grid.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            writer.Write(cell.Value.ToString() + "\t");
                        }
                        writer.WriteLine();
                    }
                }
            }
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            if (TryParseGrid(matrixGrid, out var matrix) )
            {
                var m = matrix.GetLength(0);
                var n = matrix.GetLength(1);
                /*
                if ((m != m2 || n != n2) &&
                    MessageBox.Show("Do you want to continue?", "Matrices have different dimension",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                    d = matrix[i, j] - matrix[i, j-1] 
                    matrix[i, j] == (matrix[i, j-1] + d) ? true : false
                    
                */

                for (int i = 0; i < m; i++)
                {
                    var selectionRequired = true;
                    var d = matrix[i, n-1] - matrix[i, n-2];
                    for (int j = 1; j < n; j++)
                    {
                            if (matrix[i, j] != (matrix[i, j - 1] + d))
                            {
                                selectionRequired = false;
                                break;
                            }
                            
                    }
                    matrixGrid.Rows[i].DefaultCellStyle.BackColor = selectionRequired ? Color.Aqua : Color.White;
                    //matrix1Grid.Columns[j].DefaultCellStyle.Font = selectionRequired ? 
                    //    new Font(matrix1Grid.DefaultCellStyle.Font, FontStyle.Bold) : 
                    //    new Font(matrix1Grid.DefaultCellStyle.Font, FontStyle.Regular);
                }
            }
        }

        private void СhartButton_Click(object sender, EventArgs e)
        {
            if (TryParseGrid(matrixGrid, out var matrix1))
            {
                var chartForm = new Form2(matrix1);
                chartForm.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
