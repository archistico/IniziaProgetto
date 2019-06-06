<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lbCliente = New System.Windows.Forms.Label()
        Me.tbCliente = New System.Windows.Forms.TextBox()
        Me.btOrigine = New System.Windows.Forms.Button()
        Me.btDestCopia = New System.Windows.Forms.Button()
        Me.fbd = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btCopia = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btAiuto = New System.Windows.Forms.Button()
        Me.lbOrigine = New System.Windows.Forms.Label()
        Me.lbCopia = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(25, 136)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox1.Size = New System.Drawing.Size(344, 420)
        Me.ListBox1.TabIndex = 1
        '
        'lbCliente
        '
        Me.lbCliente.AutoSize = True
        Me.lbCliente.Location = New System.Drawing.Point(389, 140)
        Me.lbCliente.Name = "lbCliente"
        Me.lbCliente.Size = New System.Drawing.Size(52, 13)
        Me.lbCliente.TabIndex = 2
        Me.lbCliente.Text = "CLIENTE"
        '
        'tbCliente
        '
        Me.tbCliente.Location = New System.Drawing.Point(472, 136)
        Me.tbCliente.Name = "tbCliente"
        Me.tbCliente.Size = New System.Drawing.Size(264, 20)
        Me.tbCliente.TabIndex = 3
        '
        'btOrigine
        '
        Me.btOrigine.Location = New System.Drawing.Point(25, 44)
        Me.btOrigine.Name = "btOrigine"
        Me.btOrigine.Size = New System.Drawing.Size(344, 31)
        Me.btOrigine.TabIndex = 4
        Me.btOrigine.Text = "SELEZIONA ORIGINE CARTELLA"
        Me.btOrigine.UseVisualStyleBackColor = True
        '
        'btDestCopia
        '
        Me.btDestCopia.Location = New System.Drawing.Point(392, 44)
        Me.btDestCopia.Name = "btDestCopia"
        Me.btDestCopia.Size = New System.Drawing.Size(344, 31)
        Me.btDestCopia.TabIndex = 5
        Me.btDestCopia.Text = "SELEZIONA DESTINAZIONE PER LA COPIA"
        Me.btDestCopia.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "SELEZIONARE LE CARTELLE DA COPIARE"
        '
        'btCopia
        '
        Me.btCopia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btCopia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCopia.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCopia.Image = Global.IniziaProgetto.My.Resources.Resources.IconaIniziaProgetto
        Me.btCopia.Location = New System.Drawing.Point(392, 177)
        Me.btCopia.Name = "btCopia"
        Me.btCopia.Size = New System.Drawing.Size(344, 379)
        Me.btCopia.TabIndex = 7
        Me.btCopia.Text = "COPIA"
        Me.btCopia.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(375, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "PREPARA CARTELLE PROGETTO"
        '
        'btAiuto
        '
        Me.btAiuto.Location = New System.Drawing.Point(704, 5)
        Me.btAiuto.Name = "btAiuto"
        Me.btAiuto.Size = New System.Drawing.Size(32, 31)
        Me.btAiuto.TabIndex = 9
        Me.btAiuto.Text = "?"
        Me.btAiuto.UseVisualStyleBackColor = True
        '
        'lbOrigine
        '
        Me.lbOrigine.AutoSize = True
        Me.lbOrigine.Location = New System.Drawing.Point(24, 87)
        Me.lbOrigine.Name = "lbOrigine"
        Me.lbOrigine.Size = New System.Drawing.Size(13, 13)
        Me.lbOrigine.TabIndex = 10
        Me.lbOrigine.Text = "--"
        '
        'lbCopia
        '
        Me.lbCopia.AutoSize = True
        Me.lbCopia.Location = New System.Drawing.Point(389, 87)
        Me.lbCopia.Name = "lbCopia"
        Me.lbCopia.Size = New System.Drawing.Size(13, 13)
        Me.lbCopia.TabIndex = 11
        Me.lbCopia.Text = "--"
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 578)
        Me.Controls.Add(Me.lbCopia)
        Me.Controls.Add(Me.lbOrigine)
        Me.Controls.Add(Me.btAiuto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btCopia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btDestCopia)
        Me.Controls.Add(Me.btOrigine)
        Me.Controls.Add(Me.tbCliente)
        Me.Controls.Add(Me.lbCliente)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inizia Progetto - Studio Archistico di Emilie Rollandin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents lbCliente As System.Windows.Forms.Label
    Friend WithEvents tbCliente As System.Windows.Forms.TextBox
    Friend WithEvents btOrigine As System.Windows.Forms.Button
    Friend WithEvents btDestCopia As System.Windows.Forms.Button
    Friend WithEvents fbd As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btCopia As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btAiuto As System.Windows.Forms.Button
    Friend WithEvents lbOrigine As System.Windows.Forms.Label
    Friend WithEvents lbCopia As System.Windows.Forms.Label

End Class
