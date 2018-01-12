Imports System
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions

Public Class frmKC
    Private Sub btnSelectFile_Click(sender As Object, e As EventArgs) Handles btnSelectFile.Click
        Try
            'Clear contents of 'All keywords' listview
            lstAll.Items.Clear()

            'Get file path from user
            KeywordFilePath.ShowDialog()

            'Read file into raw string, then split it by ','
            Dim keywords_raw As String = File.ReadAllText(KeywordFilePath.FileName)
            Dim keywords_separated() As String = Split(keywords_raw, ",")

            'Enter split keyword data into 'All keywords' listview
            For i = 0 To UBound(keywords_separated)
                lstAll.Items.Add(Trim$(keywords_separated(i)))
            Next

            'Place keyword count in label
            lblCountAll.Text = "Keyword Count: " + lstAll.Items.Count.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAutoFilter_Click(sender As Object, e As EventArgs) Handles btnAutoFilter.Click
        Try
            'Parse criteria words
            Dim criteria_separated() As String = Split(txtCriteria.Text, ", ")

            'Reset 'All keywords' listview
            For Each item As ListViewItem In Me.lstAll.Items
                item.BackColor = Color.White
            Next

            For Each item As ListViewItem In Me.lstAll.Items
                For i = 0 To UBound(criteria_separated)
                    If Regex.IsMatch(item.Text, "\b" + Regex.Escape(criteria_separated(i)) + "\b") Then
                        item.BackColor = Color.LightSeaGreen
                    End If
                Next
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnMoveHighlighted_Click(sender As Object, e As EventArgs) Handles btnMoveHighlighted.Click
        Try
            'Move highlighted contents from 'All keywords' listview to 'Filtered keywords' listview
            For Each item As ListViewItem In Me.lstAll.Items
                If item.BackColor = Color.LightSeaGreen Then
                    lstFiltered.Items.Add(item.Text)
                    lstAll.Items.Remove(item)
                End If
            Next

            'Move contents of 'Filtered keywords' listview to temporary array
            Dim list_holder_array(0 To Me.lstFiltered.Items.Count - 1) As String
            Dim ctr As Integer = 0
            For Each item As ListViewItem In Me.lstFiltered.Items
                list_holder_array(ctr) = item.Text
                ctr = ctr + 1
            Next
            lstFiltered.Items.Clear()

            'Sort the temporary array
            System.Array.Sort(Of String)(list_holder_array)

            'Add the sorted contents of array back to 'Filtered keywords' listview
            For i = 0 To UBound(list_holder_array)
                lstFiltered.Items.Add(list_holder_array(i))
            Next

            'Place keyword count in label
            lblCountAll.Text = "Keyword Count: " + lstAll.Items.Count.ToString()
            lblCountFiltered.Text = "Keyword Count: " + lstFiltered.Items.Count.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDelSelectedFromFiltered_Click(sender As Object, e As EventArgs) Handles btnDelSelectedFromFiltered.Click
        Try
            For Each item As ListViewItem In Me.lstFiltered.SelectedItems
                lstFiltered.Items.Remove(item)
            Next

            'Place keyword count in label
            lblCountFiltered.Text = "Keyword Count: " + lstFiltered.Items.Count.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDelSelectedFromAll_Click(sender As Object, e As EventArgs) Handles btnDelSelectedFromAll.Click
        Try
            For Each item As ListViewItem In Me.lstAll.SelectedItems
                lstAll.Items.Remove(item)
            Next

            'Place keyword count in label
            lblCountAll.Text = "Keyword Count: " + lstAll.Items.Count.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSaveFilteredKeywords_Click(sender As Object, e As EventArgs) Handles btnSaveFilteredKeywords.Click
        Try
            Dim sfile As New SaveFileDialog
            With sfile
                .Title = "Choose your path to save the information"
                .InitialDirectory = "C:\"
                .Filter = ("Text Files (*.txt) | *.txt |CSV Files (*.csv) | *.csv")
            End With

            If sfile.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim Write As New IO.StreamWriter(sfile.FileName)
                'Dim k As ListView.ColumnHeaderCollection = lstFiltered.Columns
                If sfile.FileName.Contains(".csv") Then
                    Dim hdr As String = "Keyword"
                    Write.Write(hdr)
                    Write.Write(vbNewLine)
                End If
                For Each x As ListViewItem In lstFiltered.Items
                    Dim StrLn As String = ""
                    For i = 0 To x.SubItems.Count - 1
                        StrLn = x.SubItems(i).Text
                    Next
                    Write.WriteLine(StrLn)
                Next
                Write.Close() 'Or  Write.Flush()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAllToFiltered_Click(sender As Object, e As EventArgs) Handles btnAllToFiltered.Click
        Try
            'Move selected items from 'All keywords' listview to 'Filtered keywords' listview
            For Each item As ListViewItem In Me.lstAll.SelectedItems
                lstFiltered.Items.Add(item.Text)
                lstAll.Items.Remove(item)
            Next

            'Move contents of 'Filtered keywords' listview to temporary array
            Dim list_holder_array(0 To Me.lstFiltered.Items.Count - 1) As String
            Dim ctr As Integer = 0
            For Each item As ListViewItem In Me.lstFiltered.Items
                list_holder_array(ctr) = item.Text
                ctr = ctr + 1
            Next
            lstFiltered.Items.Clear()

            'Sort the temporary array
            System.Array.Sort(Of String)(list_holder_array)

            'Add the sorted contents of array back to 'Filtered keywords' listview
            For i = 0 To UBound(list_holder_array)
                lstFiltered.Items.Add(list_holder_array(i))
            Next

            'Place keyword count in label
            lblCountAll.Text = "Keyword Count: " + lstAll.Items.Count.ToString()
            lblCountFiltered.Text = "Keyword Count: " + lstFiltered.Items.Count.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnFilteredToAll_Click(sender As Object, e As EventArgs) Handles btnFilteredToAll.Click
        Try
            'Move selected items from 'Filtered keywords' listview to 'All keywords' listview
            For Each item As ListViewItem In Me.lstFiltered.SelectedItems
                lstAll.Items.Add(item.Text)
                lstFiltered.Items.Remove(item)
            Next

            'Move contents of 'All keywords' listview to temporary array
            Dim list_holder_array(0 To Me.lstAll.Items.Count - 1) As String
            Dim ctr As Integer = 0
            For Each item As ListViewItem In Me.lstAll.Items
                list_holder_array(ctr) = item.Text
                ctr = ctr + 1
            Next
            lstAll.Items.Clear()

            'Sort the temporary array
            System.Array.Sort(Of String)(list_holder_array)

            'Add the sorted contents of array back to 'All keywords' listview
            For i = 0 To UBound(list_holder_array)
                lstAll.Items.Add(list_holder_array(i))
            Next

            'Place keyword count in label
            lblCountAll.Text = "Keyword Count: " + lstAll.Items.Count.ToString()
            lblCountFiltered.Text = "Keyword Count: " + lstFiltered.Items.Count.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
 
    Private Sub btnMoveEverythingToFiltered_Click(sender As Object, e As EventArgs) Handles btnMoveEverythingToFiltered.Click
        Try
            'Move all items from 'All keywords' listview to 'Filtered keywords' listview
            For Each item As ListViewItem In Me.lstAll.Items
                lstFiltered.Items.Add(item.Text)
                lstAll.Items.Remove(item)
            Next

            'Move contents of 'Filtered keywords' listview to temporary array
            Dim list_holder_array(0 To Me.lstFiltered.Items.Count - 1) As String
            Dim ctr As Integer = 0
            For Each item As ListViewItem In Me.lstFiltered.Items
                list_holder_array(ctr) = item.Text
                ctr = ctr + 1
            Next
            lstFiltered.Items.Clear()

            'Sort the temporary array
            System.Array.Sort(Of String)(list_holder_array)

            'Add the sorted contents of array back to 'Filtered keywords' listview
            For i = 0 To UBound(list_holder_array)
                lstFiltered.Items.Add(list_holder_array(i))
            Next

            'Place keyword count in label
            lblCountAll.Text = "Keyword Count: " + lstAll.Items.Count.ToString()
            lblCountFiltered.Text = "Keyword Count: " + lstFiltered.Items.Count.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnMoveEverythingToAll_Click(sender As Object, e As EventArgs) Handles btnMoveEverythingToAll.Click
        Try
            'Move all items from 'Filtered keywords' listview to 'All keywords' listview
            For Each item As ListViewItem In Me.lstFiltered.Items
                lstAll.Items.Add(item.Text)
                lstFiltered.Items.Remove(item)
            Next

            'Move contents of 'All keywords' listview to temporary array
            Dim list_holder_array(0 To Me.lstAll.Items.Count - 1) As String
            Dim ctr As Integer = 0
            For Each item As ListViewItem In Me.lstAll.Items
                list_holder_array(ctr) = item.Text
                ctr = ctr + 1
            Next
            lstAll.Items.Clear()

            'Sort the temporary array
            System.Array.Sort(Of String)(list_holder_array)

            'Add the sorted contents of array back to 'All keywords' listview
            For i = 0 To UBound(list_holder_array)
                lstAll.Items.Add(list_holder_array(i))
            Next

            'Place keyword count in label
            lblCountAll.Text = "Keyword Count: " + lstAll.Items.Count.ToString()
            lblCountFiltered.Text = "Keyword Count: " + lstFiltered.Items.Count.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmKC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ToolTip.AutoPopDelay = 5000
            ToolTip.InitialDelay = 1000
            ToolTip.ReshowDelay = 500

            ToolTip.ShowAlways = True

            ToolTip.SetToolTip(btnSaveFilteredKeywords, "Save keywords in Filtered Keywords list to .txt or .csv file.")
            ToolTip.SetToolTip(btnSelectFile, "Select .txt file containing comma separated keywords to load in All Keywords list.")
            ToolTip.SetToolTip(btnAutoFilter, "Highlight keywords in All Keywords list that match criteria.")
            ToolTip.SetToolTip(btnMoveHighlighted, "Move highlighted keywords in All Keywords list to Filtered Keywords list.")
            ToolTip.SetToolTip(btnDelSelectedFromAll, "Delete selected keywords from All Keywords list.")
            ToolTip.SetToolTip(btnDelSelectedFromFiltered, "Delete selected keywords from Filtered Keywords list.")
            ToolTip.SetToolTip(btnMoveEverythingToFiltered, "Move all keywords in All Keywords list to Filtered Keywords list.")
            ToolTip.SetToolTip(btnMoveEverythingToAll, "Move all keywords in Filtered Keywords list to All Keywords list.")
            ToolTip.SetToolTip(btnAllToFiltered, "Move selected keywords in All Keywords list to Filtered Keywords list.")
            ToolTip.SetToolTip(btnFilteredToAll, "Move selected keywords in Filtered Keywords list to All Keywords list.")
            ToolTip.SetToolTip(txtCriteria, "Enter words (separated by comma e.g. word1, word2, word3) based on which Automatic Selection will be made from All Keywords list.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
