<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        radOne = New RadioButton()
        radYear = New RadioButton()
        GroupBox2 = New GroupBox()
        chkCloud = New CheckBox()
        chkSite = New CheckBox()
        chkTech = New CheckBox()
        GroupBox3 = New GroupBox()
        lblCostOptional = New Label()
        lblCostLicensing = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnCalculate = New Button()
        btnClear = New Button()
        btnExit = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(radOne)
        GroupBox1.Controls.Add(radYear)
        GroupBox1.Location = New Point(71, 45)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(276, 190)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Licensing Options"
        ' 
        ' radOne
        ' 
        radOne.AutoSize = True
        radOne.Location = New Point(27, 102)
        radOne.Name = "radOne"
        radOne.Size = New Size(156, 24)
        radOne.TabIndex = 7
        radOne.Text = "One-time purchase"
        radOne.UseVisualStyleBackColor = False
        ' 
        ' radYear
        ' 
        radYear.AutoSize = True
        radYear.BackColor = SystemColors.Control
        radYear.Checked = True
        radYear.Location = New Point(27, 50)
        radYear.Name = "radYear"
        radYear.Size = New Size(118, 24)
        radYear.TabIndex = 6
        radYear.TabStop = True
        radYear.Text = "Yearly license"
        radYear.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(chkCloud)
        GroupBox2.Controls.Add(chkSite)
        GroupBox2.Controls.Add(chkTech)
        GroupBox2.Location = New Point(399, 45)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(359, 190)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Optional Features (yearly)"
        ' 
        ' chkCloud
        ' 
        chkCloud.AutoSize = True
        chkCloud.Location = New Point(24, 138)
        chkCloud.Name = "chkCloud"
        chkCloud.Size = New Size(122, 24)
        chkCloud.TabIndex = 10
        chkCloud.Text = "Cloud Backup"
        chkCloud.UseVisualStyleBackColor = True
        ' 
        ' chkSite
        ' 
        chkSite.AutoSize = True
        chkSite.Location = New Point(24, 90)
        chkSite.Name = "chkSite"
        chkSite.Size = New Size(136, 24)
        chkSite.TabIndex = 9
        chkSite.Text = "On-site Training"
        chkSite.UseVisualStyleBackColor = True
        ' 
        ' chkTech
        ' 
        chkTech.AutoSize = True
        chkTech.Location = New Point(24, 50)
        chkTech.Name = "chkTech"
        chkTech.Size = New Size(201, 24)
        chkTech.TabIndex = 8
        chkTech.Text = "Level-3 Technical Support"
        chkTech.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = SystemColors.Control
        GroupBox3.Controls.Add(lblCostOptional)
        GroupBox3.Controls.Add(lblCostLicensing)
        GroupBox3.Controls.Add(Label2)
        GroupBox3.Controls.Add(Label1)
        GroupBox3.Location = New Point(177, 241)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(398, 115)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        ' 
        ' lblCostOptional
        ' 
        lblCostOptional.BorderStyle = BorderStyle.Fixed3D
        lblCostOptional.Location = New Point(277, 76)
        lblCostOptional.Name = "lblCostOptional"
        lblCostOptional.Size = New Size(96, 25)
        lblCostOptional.TabIndex = 3
        ' 
        ' lblCostLicensing
        ' 
        lblCostLicensing.BorderStyle = BorderStyle.Fixed3D
        lblCostLicensing.Location = New Point(277, 35)
        lblCostLicensing.Name = "lblCostLicensing"
        lblCostLicensing.Size = New Size(96, 25)
        lblCostLicensing.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(49, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(176, 20)
        Label2.TabIndex = 1
        Label2.Text = "Cost of optional features:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(44, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(182, 20)
        Label1.TabIndex = 0
        Label1.Text = "Cost of software licensing:"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(187, 389)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(87, 28)
        btnCalculate.TabIndex = 3
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(327, 389)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(84, 28)
        btnClear.TabIndex = 4
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(467, 389)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(83, 28)
        btnExit.TabIndex = 5
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnCalculate)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Software sales"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCostOptional As Label
    Friend WithEvents lblCostLicensing As Label
    Friend WithEvents radOne As RadioButton
    Friend WithEvents radYear As RadioButton
    Friend WithEvents chkCloud As CheckBox
    Friend WithEvents chkSite As CheckBox
    Friend WithEvents chkTech As CheckBox
End Class
