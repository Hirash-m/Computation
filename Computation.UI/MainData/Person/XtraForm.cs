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
                            { worksheet.Cells[1, 1].Value?.ToString(), "Name" }, // Assuming headers in row 1
                            { worksheet.Cells[1, 2].Value?.ToString(), "Family" },
                            { worksheet.Cells[1, 3].Value?.ToString(), "NationalCode" },
                            { worksheet.Cells[1, 4].Value?.ToString(), "Email" },
                            
                            // Add more mappings for other properties
                        };


                        // Clear existing data (not strictly necessary with a BindingList)
                        personDataSource.Clear();

                        for (int row = 2; row <= rowCount; row++)
                        {
                            var person = new PersonView();

                            for (int col = 1; col <= columnCount; col++)
                            {
                                // Convert values in columns A and B to string
                                if (col == 1 || col == 2 || col == 3)
                                {
                                    var cellValue = worksheet.Cells[row, col].Value;
                                    if (cellValue != null)
                                    {
                                        worksheet.Cells[row, col].Value = cellValue.ToString();
                                    }
                                }
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            // Add data to the database and remove from grid

            for (int i = 0; i < personDataSource.Count; i++)
            {
                var person = personDataSource[i];
                if (string.IsNullOrWhiteSpace(person.Name))
                {
                    person.Name = " ";
                }
                if (string.IsNullOrWhiteSpace(person.Family))
                {
                    person.Family = " ";
                }
                try
                {
                    using (var unit = new UnitOfWork())
                    {
                        unit.PersonApp.PersonAdd(new PersonAdd
                        {
                            Name = person.Name,
                            Family = person.Family,
                            NationalCode = person.NationalCode,
                            Email = person.Email
                            // Set other properties as needed
                        });
                        unit.Save();
                        gridView1.SetRowCellValue(i, "BackColor", Color.Green);
                    }
                }
                catch (Exception ex)
                {

                    gridView1.SetRowCellValue(i, "BackColor", Color.Red);

                    continue; // Continue to the next iteration even if an error occurs
                }
            }
            

        }



    }
}


