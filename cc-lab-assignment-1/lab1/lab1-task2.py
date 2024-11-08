import System

import System.Windows.Forms

class MyForm(System.Windows.Forms.Form):
    def __init__(self):
        # Initialize components
        self.dataGridView = System.Windows.Forms.DataGridView()
        self.addButton = System.Windows.Forms.Button()

        self.dataGridView.Dock = System.Windows.Forms.DockStyle.Top
        self.dataGridView.Height = 200
        self.dataGridView.ColumnCount = 3

        # Set column headers
        self.dataGridView.Columns[0].Name = "Column 1"
        self.dataGridView.Columns[1].Name = "Column 2"
        self.dataGridView.Columns[2].Name = "Column 3"

        self.addButton.Text = "Add Row"
        self.addButton.Dock = System.Windows.Forms.DockStyle.Bottom
        self.addButton.Click += self.AddButton_Click

        # Add controls to the form
        self.Controls.Add(self.dataGridView)
        self.Controls.Add(self.addButton)

    def AddButton_Click(self, sender, e):
        # Example data to add
        row = ["Value 1", "Value 2", "Value 3"]
        self.dataGridView.Rows.Add(row)

    @staticmethod
    def Main():
        System.Windows.Forms.Application.EnableVisualStyles()
        System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(False)
        System.Windows.Forms.Application.Run(MyForm())

MyForm.Main()
