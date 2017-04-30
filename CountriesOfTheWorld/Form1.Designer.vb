<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCountriesOfTheWorld
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelChooseCountry = New System.Windows.Forms.Label()
        Me.ListBoxCountries = New System.Windows.Forms.ListBox()
        Me.LabelCountryName = New System.Windows.Forms.Label()
        Me.PictureBoxFlag = New System.Windows.Forms.PictureBox()
        Me.LabelPopulation = New System.Windows.Forms.Label()
        Me.TextBoxPopulationValue = New System.Windows.Forms.TextBox()
        Me.LabelTotalAreaIn = New System.Windows.Forms.Label()
        Me.ComboBoxMiKM = New System.Windows.Forms.ComboBox()
        Me.LabelTotalAreaValue = New System.Windows.Forms.Label()
        Me.LabelPopDensity = New System.Windows.Forms.Label()
        Me.LabelPopDensityValue = New System.Windows.Forms.Label()
        Me.LabelPercentWorldPop = New System.Windows.Forms.Label()
        Me.LabelPercentWorldPopValue = New System.Windows.Forms.Label()
        Me.ButtonUpdateWorldPop = New System.Windows.Forms.Button()
        CType(Me.PictureBoxFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelChooseCountry
        '
        Me.LabelChooseCountry.AutoSize = True
        Me.LabelChooseCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelChooseCountry.Location = New System.Drawing.Point(12, 9)
        Me.LabelChooseCountry.Name = "LabelChooseCountry"
        Me.LabelChooseCountry.Size = New System.Drawing.Size(180, 13)
        Me.LabelChooseCountry.TabIndex = 0
        Me.LabelChooseCountry.Text = "Choose a country from the list:"
        '
        'ListBoxCountries
        '
        Me.ListBoxCountries.FormattingEnabled = True
        Me.ListBoxCountries.Location = New System.Drawing.Point(12, 31)
        Me.ListBoxCountries.Name = "ListBoxCountries"
        Me.ListBoxCountries.Size = New System.Drawing.Size(177, 368)
        Me.ListBoxCountries.TabIndex = 1
        '
        'LabelCountryName
        '
        Me.LabelCountryName.AutoSize = True
        Me.LabelCountryName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCountryName.Location = New System.Drawing.Point(198, 19)
        Me.LabelCountryName.Name = "LabelCountryName"
        Me.LabelCountryName.Size = New System.Drawing.Size(122, 20)
        Me.LabelCountryName.TabIndex = 2
        Me.LabelCountryName.Text = "Country Name"
        '
        'PictureBoxFlag
        '
        Me.PictureBoxFlag.Location = New System.Drawing.Point(202, 63)
        Me.PictureBoxFlag.Name = "PictureBoxFlag"
        Me.PictureBoxFlag.Size = New System.Drawing.Size(246, 161)
        Me.PictureBoxFlag.TabIndex = 3
        Me.PictureBoxFlag.TabStop = False
        '
        'LabelPopulation
        '
        Me.LabelPopulation.AutoSize = True
        Me.LabelPopulation.Location = New System.Drawing.Point(296, 244)
        Me.LabelPopulation.Name = "LabelPopulation"
        Me.LabelPopulation.Size = New System.Drawing.Size(60, 13)
        Me.LabelPopulation.TabIndex = 4
        Me.LabelPopulation.Text = "Population:"
        '
        'TextBoxPopulationValue
        '
        Me.TextBoxPopulationValue.Location = New System.Drawing.Point(362, 241)
        Me.TextBoxPopulationValue.Name = "TextBoxPopulationValue"
        Me.TextBoxPopulationValue.Size = New System.Drawing.Size(95, 20)
        Me.TextBoxPopulationValue.TabIndex = 5
        Me.TextBoxPopulationValue.Text = "0,000"
        '
        'LabelTotalAreaIn
        '
        Me.LabelTotalAreaIn.AutoSize = True
        Me.LabelTotalAreaIn.Location = New System.Drawing.Point(219, 272)
        Me.LabelTotalAreaIn.Name = "LabelTotalAreaIn"
        Me.LabelTotalAreaIn.Size = New System.Drawing.Size(67, 13)
        Me.LabelTotalAreaIn.TabIndex = 6
        Me.LabelTotalAreaIn.Text = "Total Area in"
        '
        'ComboBoxMiKM
        '
        Me.ComboBoxMiKM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMiKM.FormattingEnabled = True
        Me.ComboBoxMiKM.Items.AddRange(New Object() {"Sq. Mi.", "Sq. KM"})
        Me.ComboBoxMiKM.Location = New System.Drawing.Point(292, 269)
        Me.ComboBoxMiKM.Name = "ComboBoxMiKM"
        Me.ComboBoxMiKM.Size = New System.Drawing.Size(64, 21)
        Me.ComboBoxMiKM.TabIndex = 7
        '
        'LabelTotalAreaValue
        '
        Me.LabelTotalAreaValue.AutoSize = True
        Me.LabelTotalAreaValue.Location = New System.Drawing.Point(362, 272)
        Me.LabelTotalAreaValue.Name = "LabelTotalAreaValue"
        Me.LabelTotalAreaValue.Size = New System.Drawing.Size(49, 13)
        Me.LabelTotalAreaValue.TabIndex = 8
        Me.LabelTotalAreaValue.Text = "0,000.00"
        '
        'LabelPopDensity
        '
        Me.LabelPopDensity.AutoSize = True
        Me.LabelPopDensity.Location = New System.Drawing.Point(204, 302)
        Me.LabelPopDensity.Name = "LabelPopDensity"
        Me.LabelPopDensity.Size = New System.Drawing.Size(152, 13)
        Me.LabelPopDensity.TabIndex = 9
        Me.LabelPopDensity.Text = "Population Density per Sq. Mi.:"
        '
        'LabelPopDensityValue
        '
        Me.LabelPopDensityValue.AutoSize = True
        Me.LabelPopDensityValue.Location = New System.Drawing.Point(362, 302)
        Me.LabelPopDensityValue.Name = "LabelPopDensityValue"
        Me.LabelPopDensityValue.Size = New System.Drawing.Size(49, 13)
        Me.LabelPopDensityValue.TabIndex = 10
        Me.LabelPopDensityValue.Text = "0,000.00"
        '
        'LabelPercentWorldPop
        '
        Me.LabelPercentWorldPop.AutoSize = True
        Me.LabelPercentWorldPop.Location = New System.Drawing.Point(195, 332)
        Me.LabelPercentWorldPop.Name = "LabelPercentWorldPop"
        Me.LabelPercentWorldPop.Size = New System.Drawing.Size(161, 13)
        Me.LabelPercentWorldPop.TabIndex = 11
        Me.LabelPercentWorldPop.Text = "Percentage of World Population:"
        '
        'LabelPercentWorldPopValue
        '
        Me.LabelPercentWorldPopValue.AutoSize = True
        Me.LabelPercentWorldPopValue.Location = New System.Drawing.Point(362, 332)
        Me.LabelPercentWorldPopValue.Name = "LabelPercentWorldPopValue"
        Me.LabelPercentWorldPopValue.Size = New System.Drawing.Size(45, 13)
        Me.LabelPercentWorldPopValue.TabIndex = 12
        Me.LabelPercentWorldPopValue.Text = "00.00 %"
        '
        'ButtonUpdateWorldPop
        '
        Me.ButtonUpdateWorldPop.Location = New System.Drawing.Point(350, 367)
        Me.ButtonUpdateWorldPop.Name = "ButtonUpdateWorldPop"
        Me.ButtonUpdateWorldPop.Size = New System.Drawing.Size(107, 23)
        Me.ButtonUpdateWorldPop.TabIndex = 13
        Me.ButtonUpdateWorldPop.Text = "Update Population"
        Me.ButtonUpdateWorldPop.UseVisualStyleBackColor = True
        '
        'FormCountriesOfTheWorld
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 411)
        Me.Controls.Add(Me.ButtonUpdateWorldPop)
        Me.Controls.Add(Me.LabelPercentWorldPopValue)
        Me.Controls.Add(Me.LabelPercentWorldPop)
        Me.Controls.Add(Me.LabelPopDensityValue)
        Me.Controls.Add(Me.LabelPopDensity)
        Me.Controls.Add(Me.LabelTotalAreaValue)
        Me.Controls.Add(Me.ComboBoxMiKM)
        Me.Controls.Add(Me.LabelTotalAreaIn)
        Me.Controls.Add(Me.TextBoxPopulationValue)
        Me.Controls.Add(Me.LabelPopulation)
        Me.Controls.Add(Me.PictureBoxFlag)
        Me.Controls.Add(Me.LabelCountryName)
        Me.Controls.Add(Me.ListBoxCountries)
        Me.Controls.Add(Me.LabelChooseCountry)
        Me.Name = "FormCountriesOfTheWorld"
        Me.Text = "Countries of the World"
        CType(Me.PictureBoxFlag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelChooseCountry As System.Windows.Forms.Label
    Friend WithEvents ListBoxCountries As System.Windows.Forms.ListBox
    Friend WithEvents LabelCountryName As System.Windows.Forms.Label
    Friend WithEvents PictureBoxFlag As System.Windows.Forms.PictureBox
    Friend WithEvents LabelPopulation As System.Windows.Forms.Label
    Friend WithEvents TextBoxPopulationValue As System.Windows.Forms.TextBox
    Friend WithEvents LabelTotalAreaIn As System.Windows.Forms.Label
    Friend WithEvents ComboBoxMiKM As System.Windows.Forms.ComboBox
    Friend WithEvents LabelTotalAreaValue As System.Windows.Forms.Label
    Friend WithEvents LabelPopDensity As System.Windows.Forms.Label
    Friend WithEvents LabelPopDensityValue As System.Windows.Forms.Label
    Friend WithEvents LabelPercentWorldPop As System.Windows.Forms.Label
    Friend WithEvents LabelPercentWorldPopValue As System.Windows.Forms.Label
    Friend WithEvents ButtonUpdateWorldPop As System.Windows.Forms.Button

End Class
