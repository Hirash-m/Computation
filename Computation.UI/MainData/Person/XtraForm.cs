using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Application.Contracts.Person;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using OfficeOpenXml;

namespace Computation.UI.MainData.Person
{
    public partial class XtraForm : DevExpress.XtraEditors.XtraForm
    {
        private OpenFileDialog openFileDialog1;
        private BindingList<PersonView> personDataSource = new BindingList<PersonView>(); // Use BindingList

        public XtraForm()
        {
            InitializeComponent();
            InitializeOpenFileDialog();

            // Set gridView1's DataSource to the BindingList
            gridControl1.DataSource = personDataSource;
        }

        private void InitializeOpenFileDialog()
        {
            openFileDialog1 = new OpenFileDialog()
            {
                FileName = "Select an Excel file",
                Filter = "Excel files (*.xlsx)|*.xlsx",
                Title = "Open Excel file"
            };
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = openFileDialog1.FileName;
                    using (var package = new ExcelPackage(new FileInfo(filePath)))
                    {
                        if (package.Workbook.Worksheets.Count == 0)
                        {
                            throw new Exception("Excel file is empty or corrupt.");
                        }

                        var worksheet = package.Workbook.Worksheets[0];
                        var rowCount = worksheet.Dimension.End.Row;
                        var columnCount = worksheet.Dimension.End.Column;

                        // Define column mapping (adjust property names as needed)
                        var propertyMappings = new Dictionary<string, string>()
                        {
                            { worksheet.Cells[1, 1].Value?.ToString(), "Family" }, // Assuming headers in row 1
                            { worksheet.Cells[1, 2].Value?.ToString(), "Name" },
                            // Add more mappings for other properties
                        };

                        // Clear existing data (not strictly necessary with a BindingList)
                        personDataSource.Clear();

                        for (int row = 2; row <= rowCount; row++)
                        {
                            var person = new PersonView();

                            for (int col = 1; col <= columnCount; col++)
                            {
                                if (propertyMappings.TryGetValue(worksheet.Cells[1, col].Value?.ToString(), out string propertyName))
                                {
                                    // Set property value based on mapping
                                    person.GetType().GetProperty(propertyName)?.SetValue(person, worksheet.Cells[row, col].Value);
                                }
                            }

                            // Add the PersonView object to the BindingList
                            personDataSource.Add(person);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
    }
}
