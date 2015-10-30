<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GasEfficiencyCalculatorFrame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GasEfficiencyCalculatorFrame))
        Me.Title = New System.Windows.Forms.Label()
        Me.RegularGasPriceLabel = New System.Windows.Forms.Label()
        Me.PremiumGasPriceLabel = New System.Windows.Forms.Label()
        Me.RegularGasPriceInput = New System.Windows.Forms.TextBox()
        Me.PremiumGasPriceInput = New System.Windows.Forms.TextBox()
        Me.CalculateEfficiencyButton = New System.Windows.Forms.Button()
        Me.AnswerLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Title.Location = New System.Drawing.Point(12, 9)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(319, 31)
        Me.Title.TabIndex = 0
        Me.Title.Text = "Gas Efficiency Calculator"
        '
        'RegularGasPriceLabel
        '
        Me.RegularGasPriceLabel.AutoSize = True
        Me.RegularGasPriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.RegularGasPriceLabel.Location = New System.Drawing.Point(33, 74)
        Me.RegularGasPriceLabel.Name = "RegularGasPriceLabel"
        Me.RegularGasPriceLabel.Size = New System.Drawing.Size(138, 20)
        Me.RegularGasPriceLabel.TabIndex = 1
        Me.RegularGasPriceLabel.Text = "Regular Gas Price"
        '
        'PremiumGasPriceLabel
        '
        Me.PremiumGasPriceLabel.AutoSize = True
        Me.PremiumGasPriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.PremiumGasPriceLabel.Location = New System.Drawing.Point(33, 121)
        Me.PremiumGasPriceLabel.Name = "PremiumGasPriceLabel"
        Me.PremiumGasPriceLabel.Size = New System.Drawing.Size(144, 20)
        Me.PremiumGasPriceLabel.TabIndex = 2
        Me.PremiumGasPriceLabel.Text = "Premium Gas Price"
        '
        'RegularGasPriceInput
        '
        Me.RegularGasPriceInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.RegularGasPriceInput.Location = New System.Drawing.Point(198, 74)
        Me.RegularGasPriceInput.Name = "RegularGasPriceInput"
        Me.RegularGasPriceInput.Size = New System.Drawing.Size(100, 26)
        Me.RegularGasPriceInput.TabIndex = 0
        '
        'PremiumGasPriceInput
        '
        Me.PremiumGasPriceInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.PremiumGasPriceInput.Location = New System.Drawing.Point(198, 118)
        Me.PremiumGasPriceInput.Name = "PremiumGasPriceInput"
        Me.PremiumGasPriceInput.Size = New System.Drawing.Size(100, 26)
        Me.PremiumGasPriceInput.TabIndex = 1
        '
        'CalculateEfficiencyButton
        '
        Me.CalculateEfficiencyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CalculateEfficiencyButton.Location = New System.Drawing.Point(80, 164)
        Me.CalculateEfficiencyButton.Name = "CalculateEfficiencyButton"
        Me.CalculateEfficiencyButton.Size = New System.Drawing.Size(172, 31)
        Me.CalculateEfficiencyButton.TabIndex = 2
        Me.CalculateEfficiencyButton.Text = "Calculate Efficiency"
        Me.CalculateEfficiencyButton.UseVisualStyleBackColor = True
        '
        'AnswerLabel
        '
        Me.AnswerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AnswerLabel.AutoSize = True
        Me.AnswerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.AnswerLabel.Location = New System.Drawing.Point(48, 218)
        Me.AnswerLabel.Name = "AnswerLabel"
        Me.AnswerLabel.Size = New System.Drawing.Size(0, 20)
        Me.AnswerLabel.TabIndex = 6
        Me.AnswerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GasEfficiencyCalculatorFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 278)
        Me.Controls.Add(Me.AnswerLabel)
        Me.Controls.Add(Me.CalculateEfficiencyButton)
        Me.Controls.Add(Me.PremiumGasPriceInput)
        Me.Controls.Add(Me.RegularGasPriceInput)
        Me.Controls.Add(Me.PremiumGasPriceLabel)
        Me.Controls.Add(Me.RegularGasPriceLabel)
        Me.Controls.Add(Me.Title)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GasEfficiencyCalculatorFrame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gas Efficiency Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents RegularGasPriceLabel As System.Windows.Forms.Label
    Friend WithEvents PremiumGasPriceLabel As System.Windows.Forms.Label
    Friend WithEvents RegularGasPriceInput As System.Windows.Forms.TextBox
    Friend WithEvents PremiumGasPriceInput As System.Windows.Forms.TextBox
    Friend WithEvents CalculateEfficiencyButton As System.Windows.Forms.Button
    Friend WithEvents AnswerLabel As System.Windows.Forms.Label

End Class
