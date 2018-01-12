<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKC
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
        Me.components = New System.ComponentModel.Container()
        Me.KeywordFilePath = New System.Windows.Forms.OpenFileDialog()
        Me.btnAllToFiltered = New System.Windows.Forms.Button()
        Me.btnFilteredToAll = New System.Windows.Forms.Button()
        Me.txtCriteria = New System.Windows.Forms.TextBox()
        Me.btnAutoFilter = New System.Windows.Forms.Button()
        Me.btnSelectFile = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMoveHighlighted = New System.Windows.Forms.Button()
        Me.lstAll = New System.Windows.Forms.ListView()
        Me.colh1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstFiltered = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnDelSelectedFromFiltered = New System.Windows.Forms.Button()
        Me.btnDelSelectedFromAll = New System.Windows.Forms.Button()
        Me.btnSaveFilteredKeywords = New System.Windows.Forms.Button()
        Me.lblCountAll = New System.Windows.Forms.Label()
        Me.lblCountFiltered = New System.Windows.Forms.Label()
        Me.btnMoveEverythingToFiltered = New System.Windows.Forms.Button()
        Me.btnMoveEverythingToAll = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'KeywordFilePath
        '
        Me.KeywordFilePath.FileName = "keywords"
        Me.KeywordFilePath.Filter = "Text files|*.txt"
        '
        'btnAllToFiltered
        '
        Me.btnAllToFiltered.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllToFiltered.Location = New System.Drawing.Point(254, 254)
        Me.btnAllToFiltered.Name = "btnAllToFiltered"
        Me.btnAllToFiltered.Size = New System.Drawing.Size(52, 48)
        Me.btnAllToFiltered.TabIndex = 2
        Me.btnAllToFiltered.Text = "->"
        Me.btnAllToFiltered.UseVisualStyleBackColor = True
        '
        'btnFilteredToAll
        '
        Me.btnFilteredToAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilteredToAll.Location = New System.Drawing.Point(254, 308)
        Me.btnFilteredToAll.Name = "btnFilteredToAll"
        Me.btnFilteredToAll.Size = New System.Drawing.Size(52, 48)
        Me.btnFilteredToAll.TabIndex = 3
        Me.btnFilteredToAll.Text = "<-"
        Me.btnFilteredToAll.UseVisualStyleBackColor = True
        '
        'txtCriteria
        '
        Me.txtCriteria.Location = New System.Drawing.Point(89, 70)
        Me.txtCriteria.Multiline = True
        Me.txtCriteria.Name = "txtCriteria"
        Me.txtCriteria.Size = New System.Drawing.Size(454, 57)
        Me.txtCriteria.TabIndex = 4
        '
        'btnAutoFilter
        '
        Me.btnAutoFilter.Location = New System.Drawing.Point(563, 298)
        Me.btnAutoFilter.Name = "btnAutoFilter"
        Me.btnAutoFilter.Size = New System.Drawing.Size(72, 70)
        Me.btnAutoFilter.TabIndex = 5
        Me.btnAutoFilter.Text = "Auto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlight" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Keywords"
        Me.btnAutoFilter.UseVisualStyleBackColor = True
        '
        'btnSelectFile
        '
        Me.btnSelectFile.Location = New System.Drawing.Point(563, 222)
        Me.btnSelectFile.Name = "btnSelectFile"
        Me.btnSelectFile.Size = New System.Drawing.Size(72, 70)
        Me.btnSelectFile.TabIndex = 6
        Me.btnSelectFile.Text = "Load Keyword" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "File"
        Me.btnSelectFile.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 54)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Auto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlight " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Criteria"
        '
        'btnMoveHighlighted
        '
        Me.btnMoveHighlighted.Location = New System.Drawing.Point(563, 374)
        Me.btnMoveHighlighted.Name = "btnMoveHighlighted"
        Me.btnMoveHighlighted.Size = New System.Drawing.Size(72, 70)
        Me.btnMoveHighlighted.TabIndex = 8
        Me.btnMoveHighlighted.Text = "Move" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlighted To" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Filtered List"
        Me.btnMoveHighlighted.UseVisualStyleBackColor = True
        '
        'lstAll
        '
        Me.lstAll.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colh1})
        Me.lstAll.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstAll.Location = New System.Drawing.Point(12, 182)
        Me.lstAll.Name = "lstAll"
        Me.lstAll.Size = New System.Drawing.Size(231, 262)
        Me.lstAll.TabIndex = 9
        Me.lstAll.UseCompatibleStateImageBehavior = False
        Me.lstAll.View = System.Windows.Forms.View.Details
        '
        'colh1
        '
        Me.colh1.Text = "Unfiltered Keywords"
        Me.colh1.Width = 260
        '
        'lstFiltered
        '
        Me.lstFiltered.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lstFiltered.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstFiltered.Location = New System.Drawing.Point(312, 182)
        Me.lstFiltered.Name = "lstFiltered"
        Me.lstFiltered.Size = New System.Drawing.Size(231, 262)
        Me.lstFiltered.TabIndex = 10
        Me.lstFiltered.UseCompatibleStateImageBehavior = False
        Me.lstFiltered.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Unfiltered Keywords"
        Me.ColumnHeader1.Width = 260
        '
        'btnDelSelectedFromFiltered
        '
        Me.btnDelSelectedFromFiltered.ForeColor = System.Drawing.Color.Red
        Me.btnDelSelectedFromFiltered.Location = New System.Drawing.Point(516, 152)
        Me.btnDelSelectedFromFiltered.Name = "btnDelSelectedFromFiltered"
        Me.btnDelSelectedFromFiltered.Size = New System.Drawing.Size(27, 24)
        Me.btnDelSelectedFromFiltered.TabIndex = 11
        Me.btnDelSelectedFromFiltered.Text = "X"
        Me.btnDelSelectedFromFiltered.UseVisualStyleBackColor = True
        '
        'btnDelSelectedFromAll
        '
        Me.btnDelSelectedFromAll.ForeColor = System.Drawing.Color.Red
        Me.btnDelSelectedFromAll.Location = New System.Drawing.Point(216, 152)
        Me.btnDelSelectedFromAll.Name = "btnDelSelectedFromAll"
        Me.btnDelSelectedFromAll.Size = New System.Drawing.Size(27, 24)
        Me.btnDelSelectedFromAll.TabIndex = 12
        Me.btnDelSelectedFromAll.Text = "X"
        Me.btnDelSelectedFromAll.UseVisualStyleBackColor = True
        '
        'btnSaveFilteredKeywords
        '
        Me.btnSaveFilteredKeywords.Location = New System.Drawing.Point(563, 146)
        Me.btnSaveFilteredKeywords.Name = "btnSaveFilteredKeywords"
        Me.btnSaveFilteredKeywords.Size = New System.Drawing.Size(72, 70)
        Me.btnSaveFilteredKeywords.TabIndex = 13
        Me.btnSaveFilteredKeywords.Text = "Save Keyword File"
        Me.btnSaveFilteredKeywords.UseVisualStyleBackColor = True
        '
        'lblCountAll
        '
        Me.lblCountAll.AutoSize = True
        Me.lblCountAll.Location = New System.Drawing.Point(12, 447)
        Me.lblCountAll.Name = "lblCountAll"
        Me.lblCountAll.Size = New System.Drawing.Size(79, 13)
        Me.lblCountAll.TabIndex = 14
        Me.lblCountAll.Text = "Keyword Count"
        Me.lblCountAll.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCountFiltered
        '
        Me.lblCountFiltered.AutoSize = True
        Me.lblCountFiltered.Location = New System.Drawing.Point(309, 447)
        Me.lblCountFiltered.Name = "lblCountFiltered"
        Me.lblCountFiltered.Size = New System.Drawing.Size(79, 13)
        Me.lblCountFiltered.TabIndex = 15
        Me.lblCountFiltered.Text = "Keyword Count"
        Me.lblCountFiltered.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnMoveEverythingToFiltered
        '
        Me.btnMoveEverythingToFiltered.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveEverythingToFiltered.Location = New System.Drawing.Point(254, 200)
        Me.btnMoveEverythingToFiltered.Name = "btnMoveEverythingToFiltered"
        Me.btnMoveEverythingToFiltered.Size = New System.Drawing.Size(52, 48)
        Me.btnMoveEverythingToFiltered.TabIndex = 17
        Me.btnMoveEverythingToFiltered.Text = ">>"
        Me.btnMoveEverythingToFiltered.UseVisualStyleBackColor = True
        '
        'btnMoveEverythingToAll
        '
        Me.btnMoveEverythingToAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveEverythingToAll.Location = New System.Drawing.Point(254, 362)
        Me.btnMoveEverythingToAll.Name = "btnMoveEverythingToAll"
        Me.btnMoveEverythingToAll.Size = New System.Drawing.Size(52, 48)
        Me.btnMoveEverythingToAll.TabIndex = 18
        Me.btnMoveEverythingToAll.Text = "<<"
        Me.btnMoveEverythingToAll.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 18)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "All Keywords"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(309, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 18)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Filtered Keywords"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(297, 39)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Keyword Cleaner"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(592, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "ver. 0.2"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmKC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 468)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnMoveEverythingToAll)
        Me.Controls.Add(Me.btnMoveEverythingToFiltered)
        Me.Controls.Add(Me.lblCountFiltered)
        Me.Controls.Add(Me.lblCountAll)
        Me.Controls.Add(Me.btnSaveFilteredKeywords)
        Me.Controls.Add(Me.btnDelSelectedFromAll)
        Me.Controls.Add(Me.btnDelSelectedFromFiltered)
        Me.Controls.Add(Me.lstFiltered)
        Me.Controls.Add(Me.lstAll)
        Me.Controls.Add(Me.btnMoveHighlighted)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSelectFile)
        Me.Controls.Add(Me.btnAutoFilter)
        Me.Controls.Add(Me.txtCriteria)
        Me.Controls.Add(Me.btnFilteredToAll)
        Me.Controls.Add(Me.btnAllToFiltered)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(663, 507)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(663, 507)
        Me.Name = "frmKC"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Keyword Cleaner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KeywordFilePath As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnAllToFiltered As System.Windows.Forms.Button
    Friend WithEvents btnFilteredToAll As System.Windows.Forms.Button
    Friend WithEvents txtCriteria As System.Windows.Forms.TextBox
    Friend WithEvents btnAutoFilter As System.Windows.Forms.Button
    Friend WithEvents btnSelectFile As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnMoveHighlighted As System.Windows.Forms.Button
    Friend WithEvents lstAll As System.Windows.Forms.ListView
    Friend WithEvents colh1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstFiltered As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnDelSelectedFromFiltered As System.Windows.Forms.Button
    Friend WithEvents btnDelSelectedFromAll As System.Windows.Forms.Button
    Friend WithEvents btnSaveFilteredKeywords As System.Windows.Forms.Button
    Friend WithEvents lblCountAll As System.Windows.Forms.Label
    Friend WithEvents lblCountFiltered As System.Windows.Forms.Label
    Friend WithEvents btnMoveEverythingToFiltered As System.Windows.Forms.Button
    Friend WithEvents btnMoveEverythingToAll As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip

End Class
