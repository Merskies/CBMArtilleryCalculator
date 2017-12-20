<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArtyCalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmArtyCalculator))
        Me.lblProgramName = New System.Windows.Forms.Label()
        Me.lblDistancetoTarget = New System.Windows.Forms.Label()
        Me.lblTargetAzimuth = New System.Windows.Forms.Label()
        Me.lblDistancetoArty = New System.Windows.Forms.Label()
        Me.lblArtyAzimuth = New System.Windows.Forms.Label()
        Me.txtDistancetoTarget = New System.Windows.Forms.TextBox()
        Me.txtTargetAzimuth = New System.Windows.Forms.TextBox()
        Me.txtDistancetoArty = New System.Windows.Forms.TextBox()
        Me.txtArtyAzimuth = New System.Windows.Forms.TextBox()
        Me.rBtnMortar = New System.Windows.Forms.RadioButton()
        Me.rBtnHowitzer = New System.Windows.Forms.RadioButton()
        Me.rBtnFieldArtillery = New System.Windows.Forms.RadioButton()
        Me.rBtnGunBoat = New System.Windows.Forms.RadioButton()
        Me.rBtnTank = New System.Windows.Forms.RadioButton()
        Me.txtMinimum = New System.Windows.Forms.TextBox()
        Me.txtMaximum = New System.Windows.Forms.TextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.grpBoxArty = New System.Windows.Forms.GroupBox()
        Me.grpBoxLock = New System.Windows.Forms.GroupBox()
        Me.cbArtyAzimuth = New System.Windows.Forms.CheckBox()
        Me.cbDistancetoArty = New System.Windows.Forms.CheckBox()
        Me.cbTargetAzimuth = New System.Windows.Forms.CheckBox()
        Me.cbDistancetoTarget = New System.Windows.Forms.CheckBox()
        Me.dgvSaves = New System.Windows.Forms.DataGridView()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.BtnDisplay = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.lblTargetIndex = New System.Windows.Forms.Label()
        Me.lblTargetName = New System.Windows.Forms.Label()
        Me.lblAzimuth = New System.Windows.Forms.Label()
        Me.lblDistance = New System.Windows.Forms.Label()
        Me.grpBoxArty.SuspendLayout()
        Me.grpBoxLock.SuspendLayout()
        CType(Me.dgvSaves, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProgramName
        '
        Me.lblProgramName.AutoSize = True
        Me.lblProgramName.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgramName.Location = New System.Drawing.Point(12, 9)
        Me.lblProgramName.Name = "lblProgramName"
        Me.lblProgramName.Size = New System.Drawing.Size(420, 37)
        Me.lblProgramName.TabIndex = 0
        Me.lblProgramName.Text = "The CBM Artillery Calculator"
        '
        'lblDistancetoTarget
        '
        Me.lblDistancetoTarget.AutoSize = True
        Me.lblDistancetoTarget.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistancetoTarget.Location = New System.Drawing.Point(12, 86)
        Me.lblDistancetoTarget.Name = "lblDistancetoTarget"
        Me.lblDistancetoTarget.Size = New System.Drawing.Size(140, 20)
        Me.lblDistancetoTarget.TabIndex = 0
        Me.lblDistancetoTarget.Text = "Distance to Target"
        '
        'lblTargetAzimuth
        '
        Me.lblTargetAzimuth.AutoSize = True
        Me.lblTargetAzimuth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTargetAzimuth.Location = New System.Drawing.Point(12, 128)
        Me.lblTargetAzimuth.Name = "lblTargetAzimuth"
        Me.lblTargetAzimuth.Size = New System.Drawing.Size(117, 20)
        Me.lblTargetAzimuth.TabIndex = 0
        Me.lblTargetAzimuth.Text = "Target Azimuth"
        '
        'lblDistancetoArty
        '
        Me.lblDistancetoArty.AutoSize = True
        Me.lblDistancetoArty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistancetoArty.Location = New System.Drawing.Point(12, 170)
        Me.lblDistancetoArty.Name = "lblDistancetoArty"
        Me.lblDistancetoArty.Size = New System.Drawing.Size(122, 20)
        Me.lblDistancetoArty.TabIndex = 0
        Me.lblDistancetoArty.Text = "Distance to Arty"
        '
        'lblArtyAzimuth
        '
        Me.lblArtyAzimuth.AutoSize = True
        Me.lblArtyAzimuth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtyAzimuth.Location = New System.Drawing.Point(12, 212)
        Me.lblArtyAzimuth.Name = "lblArtyAzimuth"
        Me.lblArtyAzimuth.Size = New System.Drawing.Size(99, 20)
        Me.lblArtyAzimuth.TabIndex = 0
        Me.lblArtyAzimuth.Text = "Arty Azimuth"
        '
        'txtDistancetoTarget
        '
        Me.txtDistancetoTarget.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDistancetoTarget.Location = New System.Drawing.Point(158, 86)
        Me.txtDistancetoTarget.Name = "txtDistancetoTarget"
        Me.txtDistancetoTarget.Size = New System.Drawing.Size(194, 26)
        Me.txtDistancetoTarget.TabIndex = 0
        '
        'txtTargetAzimuth
        '
        Me.txtTargetAzimuth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTargetAzimuth.Location = New System.Drawing.Point(158, 128)
        Me.txtTargetAzimuth.Name = "txtTargetAzimuth"
        Me.txtTargetAzimuth.Size = New System.Drawing.Size(194, 26)
        Me.txtTargetAzimuth.TabIndex = 1
        '
        'txtDistancetoArty
        '
        Me.txtDistancetoArty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDistancetoArty.Location = New System.Drawing.Point(158, 170)
        Me.txtDistancetoArty.Name = "txtDistancetoArty"
        Me.txtDistancetoArty.Size = New System.Drawing.Size(194, 26)
        Me.txtDistancetoArty.TabIndex = 2
        '
        'txtArtyAzimuth
        '
        Me.txtArtyAzimuth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArtyAzimuth.Location = New System.Drawing.Point(158, 212)
        Me.txtArtyAzimuth.Name = "txtArtyAzimuth"
        Me.txtArtyAzimuth.Size = New System.Drawing.Size(194, 26)
        Me.txtArtyAzimuth.TabIndex = 3
        '
        'rBtnMortar
        '
        Me.rBtnMortar.AutoSize = True
        Me.rBtnMortar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rBtnMortar.Location = New System.Drawing.Point(6, 19)
        Me.rBtnMortar.Name = "rBtnMortar"
        Me.rBtnMortar.Size = New System.Drawing.Size(73, 24)
        Me.rBtnMortar.TabIndex = 9999
        Me.rBtnMortar.Text = "Mortar"
        Me.rBtnMortar.UseVisualStyleBackColor = True
        '
        'rBtnHowitzer
        '
        Me.rBtnHowitzer.AutoSize = True
        Me.rBtnHowitzer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rBtnHowitzer.Location = New System.Drawing.Point(6, 49)
        Me.rBtnHowitzer.Name = "rBtnHowitzer"
        Me.rBtnHowitzer.Size = New System.Drawing.Size(89, 24)
        Me.rBtnHowitzer.TabIndex = 9999
        Me.rBtnHowitzer.Text = "Howitzer"
        Me.rBtnHowitzer.UseVisualStyleBackColor = True
        '
        'rBtnFieldArtillery
        '
        Me.rBtnFieldArtillery.AutoSize = True
        Me.rBtnFieldArtillery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rBtnFieldArtillery.Location = New System.Drawing.Point(6, 79)
        Me.rBtnFieldArtillery.Name = "rBtnFieldArtillery"
        Me.rBtnFieldArtillery.Size = New System.Drawing.Size(116, 24)
        Me.rBtnFieldArtillery.TabIndex = 9999
        Me.rBtnFieldArtillery.Text = "Field Artillery"
        Me.rBtnFieldArtillery.UseVisualStyleBackColor = True
        '
        'rBtnGunBoat
        '
        Me.rBtnGunBoat.AutoSize = True
        Me.rBtnGunBoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rBtnGunBoat.Location = New System.Drawing.Point(6, 109)
        Me.rBtnGunBoat.Name = "rBtnGunBoat"
        Me.rBtnGunBoat.Size = New System.Drawing.Size(96, 24)
        Me.rBtnGunBoat.TabIndex = 9999
        Me.rBtnGunBoat.Text = "Gun Boat"
        Me.rBtnGunBoat.UseVisualStyleBackColor = True
        '
        'rBtnTank
        '
        Me.rBtnTank.AutoSize = True
        Me.rBtnTank.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rBtnTank.Location = New System.Drawing.Point(6, 139)
        Me.rBtnTank.Name = "rBtnTank"
        Me.rBtnTank.Size = New System.Drawing.Size(62, 24)
        Me.rBtnTank.TabIndex = 9999
        Me.rBtnTank.Text = "Tank"
        Me.rBtnTank.UseVisualStyleBackColor = True
        '
        'txtMinimum
        '
        Me.txtMinimum.Enabled = False
        Me.txtMinimum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinimum.Location = New System.Drawing.Point(158, 265)
        Me.txtMinimum.Name = "txtMinimum"
        Me.txtMinimum.ReadOnly = True
        Me.txtMinimum.Size = New System.Drawing.Size(194, 26)
        Me.txtMinimum.TabIndex = 3
        Me.txtMinimum.TabStop = False
        '
        'txtMaximum
        '
        Me.txtMaximum.Enabled = False
        Me.txtMaximum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaximum.Location = New System.Drawing.Point(358, 265)
        Me.txtMaximum.Name = "txtMaximum"
        Me.txtMaximum.ReadOnly = True
        Me.txtMaximum.Size = New System.Drawing.Size(194, 26)
        Me.txtMaximum.TabIndex = 3
        Me.txtMaximum.TabStop = False
        '
        'txtOutput
        '
        Me.txtOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutput.Location = New System.Drawing.Point(16, 324)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(872, 50)
        Me.txtOutput.TabIndex = 5
        Me.txtOutput.TabStop = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(16, 248)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(136, 70)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'grpBoxArty
        '
        Me.grpBoxArty.Controls.Add(Me.rBtnMortar)
        Me.grpBoxArty.Controls.Add(Me.rBtnHowitzer)
        Me.grpBoxArty.Controls.Add(Me.rBtnFieldArtillery)
        Me.grpBoxArty.Controls.Add(Me.rBtnGunBoat)
        Me.grpBoxArty.Controls.Add(Me.rBtnTank)
        Me.grpBoxArty.Cursor = System.Windows.Forms.Cursors.Default
        Me.grpBoxArty.Location = New System.Drawing.Point(430, 66)
        Me.grpBoxArty.Name = "grpBoxArty"
        Me.grpBoxArty.Size = New System.Drawing.Size(122, 193)
        Me.grpBoxArty.TabIndex = 9999
        Me.grpBoxArty.TabStop = False
        Me.grpBoxArty.Text = "Choose Your Artillery"
        '
        'grpBoxLock
        '
        Me.grpBoxLock.Controls.Add(Me.cbArtyAzimuth)
        Me.grpBoxLock.Controls.Add(Me.cbDistancetoArty)
        Me.grpBoxLock.Controls.Add(Me.cbTargetAzimuth)
        Me.grpBoxLock.Controls.Add(Me.cbDistancetoTarget)
        Me.grpBoxLock.Location = New System.Drawing.Point(360, 66)
        Me.grpBoxLock.Name = "grpBoxLock"
        Me.grpBoxLock.Size = New System.Drawing.Size(64, 193)
        Me.grpBoxLock.TabIndex = 9999
        Me.grpBoxLock.TabStop = False
        Me.grpBoxLock.Text = "Lock"
        '
        'cbArtyAzimuth
        '
        Me.cbArtyAzimuth.AutoSize = True
        Me.cbArtyAzimuth.Location = New System.Drawing.Point(25, 151)
        Me.cbArtyAzimuth.Name = "cbArtyAzimuth"
        Me.cbArtyAzimuth.Size = New System.Drawing.Size(15, 14)
        Me.cbArtyAzimuth.TabIndex = 9999
        Me.cbArtyAzimuth.TabStop = False
        Me.cbArtyAzimuth.UseVisualStyleBackColor = True
        '
        'cbDistancetoArty
        '
        Me.cbDistancetoArty.AutoSize = True
        Me.cbDistancetoArty.Location = New System.Drawing.Point(25, 109)
        Me.cbDistancetoArty.Name = "cbDistancetoArty"
        Me.cbDistancetoArty.Size = New System.Drawing.Size(15, 14)
        Me.cbDistancetoArty.TabIndex = 9999
        Me.cbDistancetoArty.TabStop = False
        Me.cbDistancetoArty.UseVisualStyleBackColor = True
        '
        'cbTargetAzimuth
        '
        Me.cbTargetAzimuth.AutoSize = True
        Me.cbTargetAzimuth.Location = New System.Drawing.Point(25, 67)
        Me.cbTargetAzimuth.Name = "cbTargetAzimuth"
        Me.cbTargetAzimuth.Size = New System.Drawing.Size(15, 14)
        Me.cbTargetAzimuth.TabIndex = 9999
        Me.cbTargetAzimuth.TabStop = False
        Me.cbTargetAzimuth.UseVisualStyleBackColor = True
        '
        'cbDistancetoTarget
        '
        Me.cbDistancetoTarget.AutoSize = True
        Me.cbDistancetoTarget.Location = New System.Drawing.Point(25, 25)
        Me.cbDistancetoTarget.Name = "cbDistancetoTarget"
        Me.cbDistancetoTarget.Size = New System.Drawing.Size(15, 14)
        Me.cbDistancetoTarget.TabIndex = 9999
        Me.cbDistancetoTarget.TabStop = False
        Me.cbDistancetoTarget.UseVisualStyleBackColor = True
        '
        'dgvSaves
        '
        Me.dgvSaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSaves.Location = New System.Drawing.Point(565, 66)
        Me.dgvSaves.Name = "dgvSaves"
        Me.dgvSaves.Size = New System.Drawing.Size(323, 193)
        Me.dgvSaves.TabIndex = 9999
        Me.dgvSaves.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(567, 268)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'BtnDisplay
        '
        Me.BtnDisplay.Enabled = False
        Me.BtnDisplay.Location = New System.Drawing.Point(648, 268)
        Me.BtnDisplay.Name = "BtnDisplay"
        Me.BtnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.BtnDisplay.TabIndex = 7
        Me.BtnDisplay.Text = "Display"
        Me.BtnDisplay.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(729, 268)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Enabled = False
        Me.BtnDelete.Location = New System.Drawing.Point(810, 268)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 9
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'lblTargetIndex
        '
        Me.lblTargetIndex.AutoSize = True
        Me.lblTargetIndex.Location = New System.Drawing.Point(502, 302)
        Me.lblTargetIndex.Name = "lblTargetIndex"
        Me.lblTargetIndex.Size = New System.Drawing.Size(33, 13)
        Me.lblTargetIndex.TabIndex = 9999
        Me.lblTargetIndex.Text = "Index"
        Me.lblTargetIndex.Visible = False
        '
        'lblTargetName
        '
        Me.lblTargetName.AutoSize = True
        Me.lblTargetName.Location = New System.Drawing.Point(670, 302)
        Me.lblTargetName.Name = "lblTargetName"
        Me.lblTargetName.Size = New System.Drawing.Size(35, 13)
        Me.lblTargetName.TabIndex = 9999
        Me.lblTargetName.Text = "Name"
        Me.lblTargetName.Visible = False
        '
        'lblAzimuth
        '
        Me.lblAzimuth.AutoSize = True
        Me.lblAzimuth.Location = New System.Drawing.Point(360, 302)
        Me.lblAzimuth.Name = "lblAzimuth"
        Me.lblAzimuth.Size = New System.Drawing.Size(44, 13)
        Me.lblAzimuth.TabIndex = 9999
        Me.lblAzimuth.Text = "Azimuth"
        Me.lblAzimuth.Visible = False
        '
        'lblDistance
        '
        Me.lblDistance.AutoSize = True
        Me.lblDistance.Location = New System.Drawing.Point(213, 302)
        Me.lblDistance.Name = "lblDistance"
        Me.lblDistance.Size = New System.Drawing.Size(49, 13)
        Me.lblDistance.TabIndex = 9999
        Me.lblDistance.Text = "Distance"
        Me.lblDistance.Visible = False
        '
        'FrmArtyCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 389)
        Me.Controls.Add(Me.lblTargetName)
        Me.Controls.Add(Me.lblDistance)
        Me.Controls.Add(Me.lblAzimuth)
        Me.Controls.Add(Me.lblTargetIndex)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.BtnDisplay)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dgvSaves)
        Me.Controls.Add(Me.grpBoxLock)
        Me.Controls.Add(Me.grpBoxArty)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtMaximum)
        Me.Controls.Add(Me.txtMinimum)
        Me.Controls.Add(Me.txtArtyAzimuth)
        Me.Controls.Add(Me.txtDistancetoArty)
        Me.Controls.Add(Me.txtTargetAzimuth)
        Me.Controls.Add(Me.txtDistancetoTarget)
        Me.Controls.Add(Me.lblArtyAzimuth)
        Me.Controls.Add(Me.lblDistancetoArty)
        Me.Controls.Add(Me.lblTargetAzimuth)
        Me.Controls.Add(Me.lblDistancetoTarget)
        Me.Controls.Add(Me.lblProgramName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmArtyCalculator"
        Me.Text = "CBM Arty Calculator"
        Me.grpBoxArty.ResumeLayout(False)
        Me.grpBoxArty.PerformLayout()
        Me.grpBoxLock.ResumeLayout(False)
        Me.grpBoxLock.PerformLayout()
        CType(Me.dgvSaves, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProgramName As Label
    Friend WithEvents lblDistancetoTarget As Label
    Friend WithEvents lblTargetAzimuth As Label
    Friend WithEvents lblDistancetoArty As Label
    Friend WithEvents lblArtyAzimuth As Label
    Friend WithEvents txtDistancetoTarget As TextBox
    Friend WithEvents txtTargetAzimuth As TextBox
    Friend WithEvents txtDistancetoArty As TextBox
    Friend WithEvents txtArtyAzimuth As TextBox
    Friend WithEvents rBtnMortar As RadioButton
    Friend WithEvents rBtnHowitzer As RadioButton
    Friend WithEvents rBtnFieldArtillery As RadioButton
    Friend WithEvents rBtnGunBoat As RadioButton
    Friend WithEvents rBtnTank As RadioButton
    Friend WithEvents txtMinimum As TextBox
    Friend WithEvents txtMaximum As TextBox
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents grpBoxArty As GroupBox
    Friend WithEvents grpBoxLock As GroupBox
    Friend WithEvents cbDistancetoTarget As CheckBox
    Friend WithEvents cbArtyAzimuth As CheckBox
    Friend WithEvents cbDistancetoArty As CheckBox
    Friend WithEvents cbTargetAzimuth As CheckBox
    Friend WithEvents dgvSaves As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents BtnDisplay As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents lblTargetIndex As Label
    Friend WithEvents lblTargetName As Label
    Friend WithEvents lblAzimuth As Label
    Friend WithEvents lblDistance As Label
End Class
