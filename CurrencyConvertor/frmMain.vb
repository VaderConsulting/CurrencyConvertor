Public Class frmMain
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents cmbCurrencyFrom As System.Windows.Forms.ComboBox
    Friend WithEvents lblCurrencyFrom As System.Windows.Forms.Label
    Friend WithEvents lblCurrencyTo As System.Windows.Forms.Label
    Friend WithEvents cmbCurrencyTo As System.Windows.Forms.ComboBox
    Friend WithEvents txtCurrencyFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrencyTo As System.Windows.Forms.TextBox
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmbCurrencyFrom = New System.Windows.Forms.ComboBox
        Me.lblCurrencyFrom = New System.Windows.Forms.Label
        Me.lblCurrencyTo = New System.Windows.Forms.Label
        Me.cmbCurrencyTo = New System.Windows.Forms.ComboBox
        Me.txtCurrencyFrom = New System.Windows.Forms.TextBox
        Me.txtCurrencyTo = New System.Windows.Forms.TextBox
        Me.btnConvert = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmbCurrencyFrom
        '
        Me.cmbCurrencyFrom.Location = New System.Drawing.Point(8, 32)
        Me.cmbCurrencyFrom.Name = "cmbCurrencyFrom"
        Me.cmbCurrencyFrom.Size = New System.Drawing.Size(96, 21)
        Me.cmbCurrencyFrom.Sorted = True
        Me.cmbCurrencyFrom.TabIndex = 0
        '
        'lblCurrencyFrom
        '
        Me.lblCurrencyFrom.Location = New System.Drawing.Point(8, 8)
        Me.lblCurrencyFrom.Name = "lblCurrencyFrom"
        Me.lblCurrencyFrom.Size = New System.Drawing.Size(96, 16)
        Me.lblCurrencyFrom.TabIndex = 1
        Me.lblCurrencyFrom.Text = "From"
        Me.lblCurrencyFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCurrencyTo
        '
        Me.lblCurrencyTo.Location = New System.Drawing.Point(112, 8)
        Me.lblCurrencyTo.Name = "lblCurrencyTo"
        Me.lblCurrencyTo.Size = New System.Drawing.Size(96, 16)
        Me.lblCurrencyTo.TabIndex = 3
        Me.lblCurrencyTo.Text = "To"
        Me.lblCurrencyTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbCurrencyTo
        '
        Me.cmbCurrencyTo.Location = New System.Drawing.Point(112, 32)
        Me.cmbCurrencyTo.Name = "cmbCurrencyTo"
        Me.cmbCurrencyTo.Size = New System.Drawing.Size(96, 21)
        Me.cmbCurrencyTo.Sorted = True
        Me.cmbCurrencyTo.TabIndex = 1
        '
        'txtCurrencyFrom
        '
        Me.txtCurrencyFrom.Location = New System.Drawing.Point(8, 64)
        Me.txtCurrencyFrom.Name = "txtCurrencyFrom"
        Me.txtCurrencyFrom.Size = New System.Drawing.Size(96, 20)
        Me.txtCurrencyFrom.TabIndex = 2
        Me.txtCurrencyFrom.Text = ""
        '
        'txtCurrencyTo
        '
        Me.txtCurrencyTo.Location = New System.Drawing.Point(112, 64)
        Me.txtCurrencyTo.Name = "txtCurrencyTo"
        Me.txtCurrencyTo.Size = New System.Drawing.Size(96, 20)
        Me.txtCurrencyTo.TabIndex = 3
        Me.txtCurrencyTo.Text = ""
        '
        'btnConvert
        '
        Me.btnConvert.Enabled = False
        Me.btnConvert.Location = New System.Drawing.Point(112, 96)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(96, 24)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Convert"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(216, 126)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtCurrencyTo)
        Me.Controls.Add(Me.txtCurrencyFrom)
        Me.Controls.Add(Me.lblCurrencyTo)
        Me.Controls.Add(Me.cmbCurrencyTo)
        Me.Controls.Add(Me.lblCurrencyFrom)
        Me.Controls.Add(Me.cmbCurrencyFrom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Currency Convertor"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oCurrency As CurrencyConvertor.net.webservicex.www.Currency
        ' http://www.webservicex.net/WS/default.aspx
        Dim strNames() As String
        Dim iCurrency As Integer
        Dim colCurrencies As New Specialized.NameValueCollection

        ' Display the form
        Me.Refresh()

        ' Retrieve currency names
        strNames = oCurrency.GetNames(GetType(CurrencyConvertor.net.webservicex.www.Currency))

        ' Populate combo boxes
        For iCurrency = 0 To UBound(strNames)
            Me.cmbCurrencyFrom.Items.Add(strNames(iCurrency))
            Me.cmbCurrencyTo.Items.Add(strNames(iCurrency))
            colCurrencies.Add(strNames(iCurrency), CStr(iCurrency))
        Next

    End Sub

    Private Sub txtCurrencyFrom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCurrencyFrom.TextChanged
        If IsNumeric(txtCurrencyFrom.Text) Then
            btnConvert.Enabled = True
        Else
            btnConvert.Enabled = False
        End If
    End Sub

    Private Sub btnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        Dim oConvertor As New CurrencyConvertor.net.webservicex.www.CurrencyConvertor
        Dim oCurrency As CurrencyConvertor.net.webservicex.www.Currency
        Dim dblRate As Double
        Dim iFrom As Integer
        Dim s

        For Each s In [Enum].GetNames(GetType(CurrencyConvertor.net.webservicex.www.Currency))
            Console.WriteLine(s & " " & oCurrency.Parse(GetType(System.Enum), s))
        Next s



        dblRate = oConvertor.ConversionRate(Me.cmbCurrencyFrom.Text, Me.cmbCurrencyTo.Text)
    End Sub
End Class
