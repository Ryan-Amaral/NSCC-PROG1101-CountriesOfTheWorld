Option Strict On

Imports System.IO

Public Class FormCountriesOfTheWorld

    'the stats for the countries
    Dim countryNames() As String
    Dim countryPopulations() As Long
    Dim countrySizesMiles() As Double

    'keeps track of the current selected country
    Dim currentCountryId As Integer

    'display country info after first click
    Dim firstClick As Boolean = True

    Const COUNTRIES_TXT As String = "countries.txt"
    Const FLAGS_PATH As String = "flags\"

    'multiply miles by an amount to get km
    Const KM_MULTIPLIER As Double = 1.609344

    Const MILES As String = "Sq. Mi."
    Const KILOMETERS As String = "Sq. KM"

    Const POP_DENSITY_DEFAULT_STRING As String = "Population Density per "

    'store area of selected country for access from multiple subs
    Dim currentArea As Double

    ''' <summary>
    ''' When the form loads, hide some of the controls and displays the countries
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub FormCountriesOfTheWorld_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'hide the controls
        ControlsVisibilty(False)

        'load the stats into arrays
        LoadCountriesFromFile(COUNTRIES_TXT)

        'load the country names into the listbox
        LoadCountriesListBox()

    End Sub

    ''' <summary>
    ''' Hides or shows the controls
    ''' </summary>
    ''' <param name="isEnabled"></param>
    ''' <remarks></remarks>
    Private Sub ControlsVisibilty(isEnabled As Boolean)

        LabelCountryName.Visible = isEnabled
        PictureBoxFlag.Visible = isEnabled
        LabelPopulation.Visible = isEnabled
        TextBoxPopulationValue.Visible = isEnabled
        LabelTotalAreaIn.Visible = isEnabled
        ComboBoxMiKM.Visible = isEnabled
        LabelTotalAreaValue.Visible = isEnabled
        LabelPopDensity.Visible = isEnabled
        LabelPopDensityValue.Visible = isEnabled
        LabelPercentWorldPop.Visible = isEnabled
        LabelPercentWorldPopValue.Visible = isEnabled
        ButtonUpdateWorldPop.Visible = isEnabled

    End Sub

    ''' <summary>
    ''' Load the stats for the countries from a text file into arrays
    ''' </summary>
    ''' <param name="dataFile"></param>
    ''' <remarks></remarks>
    Private Sub LoadCountriesFromFile(dataFile As String)

        'open the text file
        Dim reader As StreamReader = File.OpenText(dataFile)

        'a string to temporarily hold a line of text
        Dim tempString() As String

        Dim index As Integer = 0

        'read through each line
        While reader.EndOfStream = False

            'store the values of the line
            tempString = reader.ReadLine().Split(","c)

            'update the country names
            ReDim Preserve countryNames(index)
            countryNames(index) = tempString(0)

            'update the country populations
            ReDim Preserve countryPopulations(index)
            countryPopulations(index) = Convert.ToInt64(tempString(1))

            'update the country sizes in miles
            ReDim Preserve countrySizesMiles(index)
            countrySizesMiles(index) = Convert.ToDouble(tempString(2))

            index += 1

        End While

        reader.Close()

    End Sub

    ''' <summary>
    ''' Save any changes in population to the text file
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SaveCountriesToFile()

        'create the new text file
        Dim writer As StreamWriter = File.CreateText(COUNTRIES_TXT)

        'write data from arrays into the file
        For line = 0 To countryNames.Length - 1
            writer.WriteLine(countryNames(line) & "," & _
                             countryPopulations(line) & "," & _
                             countrySizesMiles(line))
        Next

        writer.Close()

    End Sub

    ''' <summary>
    ''' Load the country names into the listbox
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadCountriesListBox()

        ListBoxCountries.Items.AddRange(countryNames)

    End Sub

    ''' <summary>
    ''' When a new country is selected display the stats for that country
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ListBoxCountries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxCountries.SelectedIndexChanged

        'show the controls for the countries if it is the first country clicked
        If firstClick = True Then
            firstClick = False
            ControlsVisibilty(True)
            'show default option on the combo box
            ComboBoxMiKM.Text = MILES
        End If

        'set the current country selected index
        currentCountryId = ListBoxCountries.SelectedIndex

        DisplayCountryData()

    End Sub

    ''' <summary>
    ''' Displays the data of the selected country
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DisplayCountryData()

        'show flag
        DisplayCountryFlag()

        'show area
        DisplayAreaData()

        'show all population stats
        DisplayPopulationData()

    End Sub

    ''' <summary>
    ''' Shows the flag of the current country
    ''' </summary>
    ''' <remarks></remarks>
    Sub DisplayCountryFlag()

        'convert spaces to underscores to get appropriate file name
        Dim flagFileName = countryNames(currentCountryId).Replace(" "c, "_"c)
        flagFileName &= ".png"
        PictureBoxFlag.Image = Image.FromFile(FLAGS_PATH & flagFileName)

    End Sub

    ''' <summary>
    ''' Displays the area of the country and stores its area in a global variable
    ''' </summary>
    ''' <remarks></remarks>
    Sub DisplayAreaData()

        'get the current country's area
        If ComboBoxMiKM.SelectedItem.ToString() = KILOMETERS Then
            currentArea = CalculateAreaInKM(countrySizesMiles(currentCountryId))
        Else
            currentArea = countrySizesMiles(currentCountryId)
        End If

        'display the area
        LabelTotalAreaValue.Text = currentArea.ToString("N2")

    End Sub

    ''' <summary>
    ''' Displays all info about the population of a country
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DisplayPopulationData()

        'the population of the country
        TextBoxPopulationValue.Text = countryPopulations(currentCountryId).ToString("N0")

        'the population density of the country
        LabelPopDensityValue.Text = (countryPopulations(currentCountryId) / currentArea).ToString("N2")

        'the percent of world population of this country
        LabelPercentWorldPopValue.Text = ((countryPopulations(currentCountryId) / CalculateTotalWorldPopulation()) * 100).ToString("N2") & " %"

    End Sub

    ''' <summary>
    ''' Calculates and returns the total world population
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CalculateTotalWorldPopulation() As Long

        Dim total As Long = 0

        'add each country's population to the total
        For index = 0 To countryPopulations.Length - 1
            total += countryPopulations(index)
        Next

        Return total

    End Function

    ''' <summary>
    ''' convert square miles into square km
    ''' </summary>
    ''' <param name="countryAreaInMiles"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CalculateAreaInKM(countryAreaInMiles As Double) As Double

        'the square root of the miles multiplied by the km multiplier is square km
        Dim kmArea As Double = Math.Pow(Math.Sqrt(countryAreaInMiles) * KM_MULTIPLIER, 2)
        Return kmArea

    End Function

    ''' <summary>
    ''' Change between metric and imperial when index is changed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ComboBoxMiKM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMiKM.SelectedIndexChanged

        'update the display string
        If ComboBoxMiKM.SelectedItem.ToString() = MILES Then
            LabelPopDensity.Text = POP_DENSITY_DEFAULT_STRING & MILES & ":"
        Else
            LabelPopDensity.Text = POP_DENSITY_DEFAULT_STRING & KILOMETERS & ":"
        End If

        're-display the area and population data
        DisplayAreaData()
        DisplayPopulationData()

    End Sub

    ''' <summary>
    ''' Update the population stats if this button is clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ButtonUpdateWorldPop_Click(sender As Object, e As EventArgs) Handles ButtonUpdateWorldPop.Click

        'remove commas from the string
        Dim populationText As String = TextBoxPopulationValue.Text.Replace(",", "")

        'check if string is numeric or not
        If IsNumeric(populationText) Then

            If populationText.Length > 15 Then
                MessageBox.Show("Input is too large")
            ElseIf populationText.Contains("."c) Or Convert.ToInt64(populationText) < 0 Then 'numeric but incorrect format
                MessageBox.Show("Please enter a valid whole number that is greater than or equal to 0")
            Else 'correct format, save and display changes
                countryPopulations(currentCountryId) = Convert.ToInt64(populationText)
                DisplayPopulationData()
                SaveCountriesToFile()
                MessageBox.Show("Saved changes to file")
            End If

        Else 'input is not numeric
            MessageBox.Show("Please enter a valid whole number")
        End If

    End Sub

End Class
