<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.One = New System.Windows.Forms.Panel()
        Me.cboNationality = New System.Windows.Forms.ComboBox()
        Me.lblNationality = New System.Windows.Forms.Label()
        Me.nupMonths = New System.Windows.Forms.NumericUpDown()
        Me.nupYears = New System.Windows.Forms.NumericUpDown()
        Me.lblLengthMoths = New System.Windows.Forms.Label()
        Me.lblLengthYears = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtForname = New System.Windows.Forms.TextBox()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblForename = New System.Windows.Forms.Label()
        Me.Navigation = New System.Windows.Forms.Panel()
        Me.btuNavFinish = New System.Windows.Forms.Button()
        Me.btuNavNext = New System.Windows.Forms.Button()
        Me.btuNavBack = New System.Windows.Forms.Button()
        Me.ptbSmallCar = New System.Windows.Forms.PictureBox()
        Me.Two = New System.Windows.Forms.Panel()
        Me.grbCars = New System.Windows.Forms.GroupBox()
        Me.ptbLargeCar = New System.Windows.Forms.PictureBox()
        Me.ptbMediumCar = New System.Windows.Forms.PictureBox()
        Me.cboSize = New System.Windows.Forms.ComboBox()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.Three = New System.Windows.Forms.Panel()
        Me.lblCostsPreview = New System.Windows.Forms.Label()
        Me.cboDuration = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Four = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.rtxtPriceBreakdown = New System.Windows.Forms.RichTextBox()
        Me.lblFinalSize = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblFinalRentalTime = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblFinalNationality = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblFinalDOB = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblFinalSurname = New System.Windows.Forms.Label()
        Me.lblFinalForename = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.One.SuspendLayout()
        CType(Me.nupMonths, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupYears, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Navigation.SuspendLayout()
        CType(Me.ptbSmallCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Two.SuspendLayout()
        Me.grbCars.SuspendLayout()
        CType(Me.ptbLargeCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbMediumCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Three.SuspendLayout()
        Me.Four.SuspendLayout()
        Me.SuspendLayout()
        '
        'One
        '
        Me.One.Controls.Add(Me.cboNationality)
        Me.One.Controls.Add(Me.lblNationality)
        Me.One.Controls.Add(Me.nupMonths)
        Me.One.Controls.Add(Me.nupYears)
        Me.One.Controls.Add(Me.lblLengthMoths)
        Me.One.Controls.Add(Me.lblLengthYears)
        Me.One.Controls.Add(Me.lblLength)
        Me.One.Controls.Add(Me.dtpDOB)
        Me.One.Controls.Add(Me.lblDOB)
        Me.One.Controls.Add(Me.txtSurname)
        Me.One.Controls.Add(Me.txtForname)
        Me.One.Controls.Add(Me.lblSurname)
        Me.One.Controls.Add(Me.lblForename)
        Me.One.Location = New System.Drawing.Point(13, 13)
        Me.One.Name = "One"
        Me.One.Size = New System.Drawing.Size(416, 158)
        Me.One.TabIndex = 0
        '
        'cboNationality
        '
        Me.cboNationality.FormattingEnabled = True
        Me.cboNationality.Items.AddRange(New Object() {"Afghan", "Albanian", "Algerian", "American", "Andorran", "Angolan", "Anguillan", "Argentine", "Armenian", "Australian", "Austrian", "Azerbaijani", "Bahamian", "Bahraini", "Bangladeshi", "Barbadian", "Belarusian", "Belgian", "Belizean", "Beninese", "Bermudian", "Bhutanese", "Bolivian", "Botswanan", "Brazilian", "British", "British Virgin Islander", "Bruneian", "Bulgarian", "Burkinan", "Burmese", "Burundian", "Cambodian", "Cameroonian", "Canadian", "Cape Verdean", "Cayman Islander", "Central African", "Chadian", "Chilean", "Chinese", "Citizen of Antigua and Barbuda", "Citizen of Bosnia and Herzegovina", "Citizen of Guinea-Bissau", "Citizen of Kiribati", "Citizen of Seychelles", "Citizen of the Dominican Republic", "Citizen of Vanuatu", "Colombian", "Comoran", "Congolese (Congo)", "Congolese (DRC)", "Cook Islander", "Costa Rican", "Croatian", "Cuban", "Cymraes", "Cymro", "Cypriot", "Czech", "Danish", "Djiboutian", "Dominican", "Dutch", "East Timorese", "Ecuadorean", "Egyptian", "Emirati", "English", "Equatorial Guinean", "Eritrean", "Estonian", "Ethiopian", "Faroese", "Fijian", "Filipino", "Finnish", "French", "Gabonese", "Gambian", "Georgian", "German", "Ghanaian", "Gibraltarian", "Greek", "Greenlandic", "Grenadian", "Guamanian", "Guatemalan", "Guinean", "Guyanese", "Haitian", "Honduran", "Hong Konger", "Hungarian", "Icelandic", "Indian", "Indonesian", "Iranian", "Iraqi", "Irish", "Israeli", "Italian", "Ivorian", "Jamaican", "Japanese", "Jordanian", "Kazakh", "Kenyan", "Kittitian", "Kosovan", "Kuwaiti", "Kyrgyz", "Lao", "Latvian", "Lebanese", "Liberian", "Libyan", "Liechtenstein citizen", "Lithuanian", "Luxembourger", "Macanese", "Macedonian", "Malagasy", "Malawian", "Malaysian", "Maldivian", "Malian", "Maltese", "Marshallese", "Martiniquais", "Mauritanian", "Mauritian", "Mexican", "Micronesian", "Moldovan", "Monegasque", "Mongolian", "Montenegrin", "Montserratian", "Moroccan", "Mosotho", "Mozambican", "Namibian", "Nauruan", "Nepalese", "New Zealander", "Nicaraguan", "Nigerian", "Nigerien", "Niuean", "North Korean", "Northern Irish", "Norwegian", "Omani", "Pakistani", "Palauan", "Palestinian", "Panamanian", "Papua New Guinean", "Paraguayan", "Peruvian", "Pitcairn Islander", "Polish", "Portuguese", "Prydeinig", "Puerto Rican", "Qatari", "Romanian", "Russian", "Rwandan", "Salvadorean", "Sammarinese", "Samoan", "Sao Tomean", "Saudi Arabian", "Scottish", "Senegalese", "Serbian", "Sierra Leonean", "Singaporean", "Slovak", "Slovenian", "Solomon Islander", "Somali", "South African", "South Korean", "South Sudanese", "Spanish", "Sri Lankan", "St Helenian", "St Lucian", "Stateless", "Sudanese", "Surinamese", "Swazi", "Swedish", "Swiss", "Syrian", "Taiwanese", "Tajik", "Tanzanian", "Thai", "Togolese", "Tongan", "Trinidadian", "Tristanian", "Tunisian", "Turkish", "Turkmen", "Turks and Caicos Islander", "Tuvaluan", "Ugandan", "Ukrainian", "Uruguayan", "Uzbek", "Vatican citizen", "Venezuelan", "Vietnamese", "Vincentian", "Wallisian", "Welsh", "Yemeni", "Zambian", "Zimbabwean"})
        Me.cboNationality.Location = New System.Drawing.Point(225, 31)
        Me.cboNationality.Name = "cboNationality"
        Me.cboNationality.Size = New System.Drawing.Size(121, 21)
        Me.cboNationality.TabIndex = 14
        '
        'lblNationality
        '
        Me.lblNationality.AutoSize = True
        Me.lblNationality.Location = New System.Drawing.Point(163, 34)
        Me.lblNationality.Name = "lblNationality"
        Me.lblNationality.Size = New System.Drawing.Size(56, 13)
        Me.lblNationality.TabIndex = 13
        Me.lblNationality.Text = "Nationality"
        '
        'nupMonths
        '
        Me.nupMonths.Location = New System.Drawing.Point(153, 85)
        Me.nupMonths.Name = "nupMonths"
        Me.nupMonths.Size = New System.Drawing.Size(54, 20)
        Me.nupMonths.TabIndex = 12
        '
        'nupYears
        '
        Me.nupYears.Location = New System.Drawing.Point(45, 85)
        Me.nupYears.Name = "nupYears"
        Me.nupYears.Size = New System.Drawing.Size(54, 20)
        Me.nupYears.TabIndex = 11
        '
        'lblLengthMoths
        '
        Me.lblLengthMoths.AutoSize = True
        Me.lblLengthMoths.Location = New System.Drawing.Point(105, 87)
        Me.lblLengthMoths.Name = "lblLengthMoths"
        Me.lblLengthMoths.Size = New System.Drawing.Size(42, 13)
        Me.lblLengthMoths.TabIndex = 10
        Me.lblLengthMoths.Text = "Months"
        '
        'lblLengthYears
        '
        Me.lblLengthYears.AutoSize = True
        Me.lblLengthYears.Location = New System.Drawing.Point(5, 87)
        Me.lblLengthYears.Name = "lblLengthYears"
        Me.lblLengthYears.Size = New System.Drawing.Size(34, 13)
        Me.lblLengthYears.TabIndex = 7
        Me.lblLengthYears.Text = "Years"
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(5, 65)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(123, 13)
        Me.lblLength.TabIndex = 6
        Me.lblLength.Text = "Length License Held For"
        '
        'dtpDOB
        '
        Me.dtpDOB.Location = New System.Drawing.Point(201, 4)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(200, 20)
        Me.dtpDOB.TabIndex = 5
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(165, 7)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(30, 13)
        Me.lblDOB.TabIndex = 4
        Me.lblDOB.Text = "DOB"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(60, 30)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(100, 20)
        Me.txtSurname.TabIndex = 3
        '
        'txtForname
        '
        Me.txtForname.Location = New System.Drawing.Point(60, 4)
        Me.txtForname.Name = "txtForname"
        Me.txtForname.Size = New System.Drawing.Size(100, 20)
        Me.txtForname.TabIndex = 2
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(5, 33)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(49, 13)
        Me.lblSurname.TabIndex = 1
        Me.lblSurname.Text = "Surname"
        '
        'lblForename
        '
        Me.lblForename.AutoSize = True
        Me.lblForename.Location = New System.Drawing.Point(4, 7)
        Me.lblForename.Name = "lblForename"
        Me.lblForename.Size = New System.Drawing.Size(54, 13)
        Me.lblForename.TabIndex = 0
        Me.lblForename.Text = "Forename"
        '
        'Navigation
        '
        Me.Navigation.Controls.Add(Me.btuNavFinish)
        Me.Navigation.Controls.Add(Me.btuNavNext)
        Me.Navigation.Controls.Add(Me.btuNavBack)
        Me.Navigation.Location = New System.Drawing.Point(175, 177)
        Me.Navigation.Name = "Navigation"
        Me.Navigation.Size = New System.Drawing.Size(254, 30)
        Me.Navigation.TabIndex = 1
        '
        'btuNavFinish
        '
        Me.btuNavFinish.Location = New System.Drawing.Point(168, 4)
        Me.btuNavFinish.Name = "btuNavFinish"
        Me.btuNavFinish.Size = New System.Drawing.Size(75, 23)
        Me.btuNavFinish.TabIndex = 2
        Me.btuNavFinish.Text = "Finish"
        Me.btuNavFinish.UseVisualStyleBackColor = True
        '
        'btuNavNext
        '
        Me.btuNavNext.Location = New System.Drawing.Point(86, 4)
        Me.btuNavNext.Name = "btuNavNext"
        Me.btuNavNext.Size = New System.Drawing.Size(75, 23)
        Me.btuNavNext.TabIndex = 1
        Me.btuNavNext.Text = "Next"
        Me.btuNavNext.UseVisualStyleBackColor = True
        '
        'btuNavBack
        '
        Me.btuNavBack.Location = New System.Drawing.Point(4, 4)
        Me.btuNavBack.Name = "btuNavBack"
        Me.btuNavBack.Size = New System.Drawing.Size(75, 23)
        Me.btuNavBack.TabIndex = 0
        Me.btuNavBack.Text = "Back"
        Me.btuNavBack.UseVisualStyleBackColor = True
        '
        'ptbSmallCar
        '
        Me.ptbSmallCar.Image = CType(resources.GetObject("ptbSmallCar.Image"), System.Drawing.Image)
        Me.ptbSmallCar.Location = New System.Drawing.Point(6, 15)
        Me.ptbSmallCar.Name = "ptbSmallCar"
        Me.ptbSmallCar.Size = New System.Drawing.Size(230, 121)
        Me.ptbSmallCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbSmallCar.TabIndex = 4
        Me.ptbSmallCar.TabStop = False
        '
        'Two
        '
        Me.Two.Controls.Add(Me.grbCars)
        Me.Two.Controls.Add(Me.cboSize)
        Me.Two.Controls.Add(Me.lblSize)
        Me.Two.Location = New System.Drawing.Point(13, 13)
        Me.Two.Name = "Two"
        Me.Two.Size = New System.Drawing.Size(417, 158)
        Me.Two.TabIndex = 2
        '
        'grbCars
        '
        Me.grbCars.Controls.Add(Me.ptbSmallCar)
        Me.grbCars.Controls.Add(Me.ptbLargeCar)
        Me.grbCars.Controls.Add(Me.ptbMediumCar)
        Me.grbCars.Location = New System.Drawing.Point(6, 7)
        Me.grbCars.Name = "grbCars"
        Me.grbCars.Size = New System.Drawing.Size(254, 142)
        Me.grbCars.TabIndex = 7
        Me.grbCars.TabStop = False
        Me.grbCars.Text = "Preview"
        '
        'ptbLargeCar
        '
        Me.ptbLargeCar.Image = CType(resources.GetObject("ptbLargeCar.Image"), System.Drawing.Image)
        Me.ptbLargeCar.Location = New System.Drawing.Point(6, 15)
        Me.ptbLargeCar.Name = "ptbLargeCar"
        Me.ptbLargeCar.Size = New System.Drawing.Size(230, 121)
        Me.ptbLargeCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbLargeCar.TabIndex = 6
        Me.ptbLargeCar.TabStop = False
        '
        'ptbMediumCar
        '
        Me.ptbMediumCar.Image = CType(resources.GetObject("ptbMediumCar.Image"), System.Drawing.Image)
        Me.ptbMediumCar.Location = New System.Drawing.Point(6, 15)
        Me.ptbMediumCar.Name = "ptbMediumCar"
        Me.ptbMediumCar.Size = New System.Drawing.Size(230, 121)
        Me.ptbMediumCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbMediumCar.TabIndex = 5
        Me.ptbMediumCar.TabStop = False
        '
        'cboSize
        '
        Me.cboSize.FormattingEnabled = True
        Me.cboSize.Items.AddRange(New Object() {"Small", "Medium", "Large"})
        Me.cboSize.Location = New System.Drawing.Point(266, 30)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(121, 21)
        Me.cboSize.TabIndex = 1
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(266, 11)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(60, 13)
        Me.lblSize.TabIndex = 0
        Me.lblSize.Text = "Size Of Car"
        '
        'Three
        '
        Me.Three.Controls.Add(Me.lblCostsPreview)
        Me.Three.Controls.Add(Me.cboDuration)
        Me.Three.Controls.Add(Me.Label1)
        Me.Three.Location = New System.Drawing.Point(13, 13)
        Me.Three.Name = "Three"
        Me.Three.Size = New System.Drawing.Size(417, 158)
        Me.Three.TabIndex = 3
        '
        'lblCostsPreview
        '
        Me.lblCostsPreview.AutoSize = True
        Me.lblCostsPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCostsPreview.Location = New System.Drawing.Point(154, 28)
        Me.lblCostsPreview.MaximumSize = New System.Drawing.Size(200, 0)
        Me.lblCostsPreview.MinimumSize = New System.Drawing.Size(200, 0)
        Me.lblCostsPreview.Name = "lblCostsPreview"
        Me.lblCostsPreview.Size = New System.Drawing.Size(200, 15)
        Me.lblCostsPreview.TabIndex = 2
        '
        'cboDuration
        '
        Me.cboDuration.FormattingEnabled = True
        Me.cboDuration.Items.AddRange(New Object() {"1 Day", "1 Week", "1 Month"})
        Me.cboDuration.Location = New System.Drawing.Point(9, 25)
        Me.cboDuration.Name = "cboDuration"
        Me.cboDuration.Size = New System.Drawing.Size(121, 21)
        Me.cboDuration.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Duration Of Rental"
        '
        'Four
        '
        Me.Four.Controls.Add(Me.Label14)
        Me.Four.Controls.Add(Me.rtxtPriceBreakdown)
        Me.Four.Controls.Add(Me.lblFinalSize)
        Me.Four.Controls.Add(Me.Label12)
        Me.Four.Controls.Add(Me.lblFinalRentalTime)
        Me.Four.Controls.Add(Me.Label10)
        Me.Four.Controls.Add(Me.lblFinalNationality)
        Me.Four.Controls.Add(Me.Label8)
        Me.Four.Controls.Add(Me.lblFinalDOB)
        Me.Four.Controls.Add(Me.Label6)
        Me.Four.Controls.Add(Me.lblFinalSurname)
        Me.Four.Controls.Add(Me.lblFinalForename)
        Me.Four.Controls.Add(Me.Label3)
        Me.Four.Controls.Add(Me.Label2)
        Me.Four.Location = New System.Drawing.Point(13, 13)
        Me.Four.Name = "Four"
        Me.Four.Size = New System.Drawing.Size(417, 158)
        Me.Four.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 97)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Price Breakdown"
        '
        'rtxtPriceBreakdown
        '
        Me.rtxtPriceBreakdown.Location = New System.Drawing.Point(100, 94)
        Me.rtxtPriceBreakdown.Name = "rtxtPriceBreakdown"
        Me.rtxtPriceBreakdown.ReadOnly = True
        Me.rtxtPriceBreakdown.Size = New System.Drawing.Size(135, 61)
        Me.rtxtPriceBreakdown.TabIndex = 12
        Me.rtxtPriceBreakdown.Text = ""
        '
        'lblFinalSize
        '
        Me.lblFinalSize.AutoSize = True
        Me.lblFinalSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFinalSize.Location = New System.Drawing.Point(288, 65)
        Me.lblFinalSize.MaximumSize = New System.Drawing.Size(150, 15)
        Me.lblFinalSize.Name = "lblFinalSize"
        Me.lblFinalSize.Size = New System.Drawing.Size(27, 15)
        Me.lblFinalSize.TabIndex = 11
        Me.lblFinalSize.Text = "size"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(222, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Size Of Car"
        '
        'lblFinalRentalTime
        '
        Me.lblFinalRentalTime.AutoSize = True
        Me.lblFinalRentalTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFinalRentalTime.Location = New System.Drawing.Point(107, 65)
        Me.lblFinalRentalTime.MaximumSize = New System.Drawing.Size(120, 15)
        Me.lblFinalRentalTime.Name = "lblFinalRentalTime"
        Me.lblFinalRentalTime.Size = New System.Drawing.Size(57, 15)
        Me.lblFinalRentalTime.TabIndex = 9
        Me.lblFinalRentalTime.Text = "rental time"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Duration Of Rental"
        '
        'lblFinalNationality
        '
        Me.lblFinalNationality.AutoSize = True
        Me.lblFinalNationality.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFinalNationality.Location = New System.Drawing.Point(284, 28)
        Me.lblFinalNationality.MaximumSize = New System.Drawing.Size(150, 15)
        Me.lblFinalNationality.Name = "lblFinalNationality"
        Me.lblFinalNationality.Size = New System.Drawing.Size(56, 15)
        Me.lblFinalNationality.TabIndex = 7
        Me.lblFinalNationality.Text = "nationality"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(222, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Nationality"
        '
        'lblFinalDOB
        '
        Me.lblFinalDOB.AutoSize = True
        Me.lblFinalDOB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFinalDOB.Location = New System.Drawing.Point(284, 9)
        Me.lblFinalDOB.MaximumSize = New System.Drawing.Size(150, 15)
        Me.lblFinalDOB.Name = "lblFinalDOB"
        Me.lblFinalDOB.Size = New System.Drawing.Size(65, 15)
        Me.lblFinalDOB.TabIndex = 5
        Me.lblFinalDOB.Text = "date of birth"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(222, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "DOB"
        '
        'lblFinalSurname
        '
        Me.lblFinalSurname.AutoSize = True
        Me.lblFinalSurname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFinalSurname.Location = New System.Drawing.Point(66, 25)
        Me.lblFinalSurname.MaximumSize = New System.Drawing.Size(150, 15)
        Me.lblFinalSurname.Name = "lblFinalSurname"
        Me.lblFinalSurname.Size = New System.Drawing.Size(49, 15)
        Me.lblFinalSurname.TabIndex = 3
        Me.lblFinalSurname.Text = "surname"
        '
        'lblFinalForename
        '
        Me.lblFinalForename.AutoSize = True
        Me.lblFinalForename.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFinalForename.Location = New System.Drawing.Point(66, 9)
        Me.lblFinalForename.MaximumSize = New System.Drawing.Size(150, 105)
        Me.lblFinalForename.Name = "lblFinalForename"
        Me.lblFinalForename.Size = New System.Drawing.Size(53, 15)
        Me.lblFinalForename.TabIndex = 2
        Me.lblFinalForename.Text = "forename"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Surname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Forename"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 215)
        Me.Controls.Add(Me.Four)
        Me.Controls.Add(Me.Three)
        Me.Controls.Add(Me.Two)
        Me.Controls.Add(Me.Navigation)
        Me.Controls.Add(Me.One)
        Me.Name = "Form1"
        Me.Text = "Car Rental"
        Me.One.ResumeLayout(False)
        Me.One.PerformLayout()
        CType(Me.nupMonths, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupYears, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Navigation.ResumeLayout(False)
        CType(Me.ptbSmallCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Two.ResumeLayout(False)
        Me.Two.PerformLayout()
        Me.grbCars.ResumeLayout(False)
        CType(Me.ptbLargeCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbMediumCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Three.ResumeLayout(False)
        Me.Three.PerformLayout()
        Me.Four.ResumeLayout(False)
        Me.Four.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents One As Panel
    Friend WithEvents lblSurname As Label
    Friend WithEvents lblForename As Label
    Friend WithEvents Navigation As Panel
    Friend WithEvents btuNavFinish As Button
    Friend WithEvents btuNavNext As Button
    Friend WithEvents btuNavBack As Button
    Friend WithEvents nupMonths As NumericUpDown
    Friend WithEvents nupYears As NumericUpDown
    Friend WithEvents lblLengthMoths As Label
    Friend WithEvents lblLengthYears As Label
    Friend WithEvents lblLength As Label
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents lblDOB As Label
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtForname As TextBox
    Friend WithEvents cboNationality As ComboBox
    Friend WithEvents lblNationality As Label
    Friend WithEvents Two As Panel
    Friend WithEvents Three As Panel
    Friend WithEvents Four As Panel
    Friend WithEvents cboSize As ComboBox
    Friend WithEvents lblSize As Label
    Friend WithEvents ptbSmallCar As PictureBox
    Friend WithEvents cboDuration As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ptbLargeCar As PictureBox
    Friend WithEvents ptbMediumCar As PictureBox
    Friend WithEvents grbCars As GroupBox
    Friend WithEvents lblCostsPreview As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblFinalSurname As Label
    Friend WithEvents lblFinalForename As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFinalNationality As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblFinalDOB As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblFinalRentalTime As Label
    Friend WithEvents lblFinalSize As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents rtxtPriceBreakdown As RichTextBox
End Class
