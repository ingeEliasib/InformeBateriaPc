<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fr_ayuda
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fr_Ayuda))
        Panel1 = New Panel()
        Lklbl_email = New LinkLabel()
        Btn_Cancelar = New Button()
        Btn_EnviarCorreo = New Button()
        Txtb_textogeneral = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Lklbl_email)
        Panel1.Controls.Add(Btn_Cancelar)
        Panel1.Controls.Add(Btn_EnviarCorreo)
        Panel1.Controls.Add(Txtb_textogeneral)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(372, 257)
        Panel1.TabIndex = 0
        ' 
        ' Lklbl_email
        ' 
        Lklbl_email.AutoSize = True
        Lklbl_email.Location = New Point(21, 196)
        Lklbl_email.Name = "Lklbl_email"
        Lklbl_email.Size = New Size(196, 15)
        Lklbl_email.TabIndex = 4
        Lklbl_email.TabStop = True
        Lklbl_email.Text = "Ingenieroeliasibcadena@gmail.com"
        ' 
        ' Btn_Cancelar
        ' 
        Btn_Cancelar.Location = New Point(285, 222)
        Btn_Cancelar.Name = "Btn_Cancelar"
        Btn_Cancelar.Size = New Size(75, 23)
        Btn_Cancelar.TabIndex = 3
        Btn_Cancelar.Text = "Cancelar"
        Btn_Cancelar.UseVisualStyleBackColor = True
        ' 
        ' Btn_EnviarCorreo
        ' 
        Btn_EnviarCorreo.Location = New Point(124, 222)
        Btn_EnviarCorreo.Name = "Btn_EnviarCorreo"
        Btn_EnviarCorreo.Size = New Size(155, 23)
        Btn_EnviarCorreo.TabIndex = 2
        Btn_EnviarCorreo.Text = "Enviar Correo"
        Btn_EnviarCorreo.UseVisualStyleBackColor = True
        ' 
        ' Txtb_textogeneral
        ' 
        Txtb_textogeneral.BackColor = Color.White
        Txtb_textogeneral.BorderStyle = BorderStyle.None
        Txtb_textogeneral.Location = New Point(12, 12)
        Txtb_textogeneral.Multiline = True
        Txtb_textogeneral.Name = "Txtb_textogeneral"
        Txtb_textogeneral.Size = New Size(348, 181)
        Txtb_textogeneral.TabIndex = 1
        ' 
        ' Fr_Ayuda
        ' 
        AcceptButton = Btn_EnviarCorreo
        AccessibleDescription = "ventana con información de ayuda"
        AccessibleName = "Ventana de ayuda"
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = Btn_Cancelar
        ClientSize = New Size(372, 257)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        KeyPreview = True
        MaximizeBox = False
        MinimizeBox = False
        Name = "Fr_Ayuda"
        Text = "Ayuda"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Lklbl_email As LinkLabel
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Btn_EnviarCorreo As Button
    Friend WithEvents Txtb_textogeneral As TextBox
End Class
