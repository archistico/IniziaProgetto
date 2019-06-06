Imports System
Imports System.IO

Public Class frmHome
    Dim folderNameOrig As String = ""
    Dim folderNameDest As String = ""

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Using sr As New StreamReader("CartellaIniziale.txt")
                folderNameOrig = sr.ReadToEnd()
            End Using
        Catch ex As Exception
            MessageBox.Show("Errore lettura CartellaIniziale.txt", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Try
            ListBox1.DataSource = (From folder In New IO.DirectoryInfo(folderNameOrig).GetDirectories Select (folder.Name)).ToArray
        Catch ex As Exception
            MessageBox.Show("Directory " & folderNameOrig & " non presente", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'In base al fatto che foldernamedest sia stata messa gestisci differentemente
        If folderNameDest = "" Then
            'ALLORA LEGGI DA FILE
            Dim line As String = ""
            Try
                Using sr As New StreamReader("CartellaCopia.txt")
                    folderNameDest = sr.ReadToEnd()
                End Using
            Catch ex As Exception
                MessageBox.Show("Errore lettura CartellaCopia.txt", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        lbOrigine.Text = folderNameOrig
        lbCopia.Text = folderNameDest
    End Sub

    Private Sub btOrigine_Click(sender As Object, e As EventArgs) Handles btOrigine.Click
        Dim result As DialogResult = fbd.ShowDialog()
        If (result = DialogResult.OK) Then
            folderNameOrig = fbd.SelectedPath
            ListBox1.DataSource = (From folder In New IO.DirectoryInfo(folderNameOrig).GetDirectories Select (folder.Name)).ToArray
        End If
        lbOrigine.Text = folderNameOrig
        lbCopia.Text = folderNameDest
    End Sub

    Private Sub btCopia_Click(sender As Object, e As EventArgs) Handles btCopia.Click
        'Controlla che il nome cliente sia compilato
        If tbCliente.Text = "" Then
            MessageBox.Show("Scrivere il nome del cliente", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbCliente.Focus()
            Exit Sub
        End If
        
        'Se è stata scelta la cartella oppure è stata compilata positivamente dal file
        If Not (folderNameDest) = "" Then
            'CREA CARTELLA CLIENTE
            If (Not System.IO.Directory.Exists(folderNameDest & tbCliente.Text)) Then
                Try
                    System.IO.Directory.CreateDirectory(folderNameDest & tbCliente.Text)
                Catch ex As Exception
                    MessageBox.Show("Errore creazione cartella " & folderNameDest & tbCliente.Text, "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                'Directory già presente
                MessageBox.Show("Cliente già presente, i file verranno copiati nella cartella", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Try
                'COPIO LE DIRECTORY SELEZIONATE DALLA LISTBOX
                Dim i As Integer = 0
                For i = 0 To Me.ListBox1.SelectedItems.Count - 1
                    Try
                        My.Computer.FileSystem.CopyDirectory(folderNameOrig & ListBox1.SelectedItems(i).ToString, folderNameDest & tbCliente.Text & "\" & ListBox1.SelectedItems(i).ToString, False)
                        'MessageBox.Show("COPIO " & folderNameOrig & ListBox1.SelectedItems(i).ToString & " - IN " & folderNameDest & tbCliente.Text & "\" & ListBox1.SelectedItems(i).ToString)
                    Catch ex As Exception
                        MessageBox.Show("Errore nel copiare la cartella " & folderNameDest & tbCliente.Text & "\" & ListBox1.SelectedItems(i).ToString, "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End Try
                Next i
                MessageBox.Show("FATTO", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Errore nella copia dei file" & folderNameDest & tbCliente.Text, "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btDestCopia_Click(sender As Object, e As EventArgs) Handles btDestCopia.Click
        Dim result As DialogResult = fbd.ShowDialog()
        If (result = DialogResult.OK) Then
            folderNameDest = fbd.SelectedPath
        End If
        lbOrigine.Text = folderNameOrig
        lbCopia.Text = folderNameDest
    End Sub

    Private Sub btAiuto_Click(sender As Object, e As EventArgs) Handles btAiuto.Click
        Dim frm As New frmINFO
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            'ok
        End If
    End Sub
End Class
