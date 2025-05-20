<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fr_principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fr_principal))
        Panel1 = New Panel()
        Btn_Ayuda = New Button()
        Txb_DescripcionEstadoBateria = New TextBox()
        Btn_Salir = New Button()
        Btn_ActualizarInformacion = New Button()
        Panel2 = New Panel()
        NotifyIcon1 = New NotifyIcon(components)
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Btn_Ayuda)
        Panel1.Controls.Add(Txb_DescripcionEstadoBateria)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(249, 164)
        Panel1.TabIndex = 0
        ' 
        ' Btn_Ayuda
        ' 
        Btn_Ayuda.AccessibleDescription = ""
        Btn_Ayuda.AccessibleName = "Boton Ayuda"
        Btn_Ayuda.Location = New Point(165, 5)
        Btn_Ayuda.Name = "Btn_Ayuda"
        Btn_Ayuda.Size = New Size(75, 23)
        Btn_Ayuda.TabIndex = 5
        Btn_Ayuda.Text = "Ayuda"
        Btn_Ayuda.UseVisualStyleBackColor = True
        ' 
        ' Txb_DescripcionEstadoBateria
        ' 
        Txb_DescripcionEstadoBateria.AccessibleDescription = ""
        Txb_DescripcionEstadoBateria.AccessibleName = ""
        Txb_DescripcionEstadoBateria.BackColor = Color.White
        Txb_DescripcionEstadoBateria.BorderStyle = BorderStyle.None
        Txb_DescripcionEstadoBateria.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txb_DescripcionEstadoBateria.Location = New Point(6, 32)
        Txb_DescripcionEstadoBateria.Multiline = True
        Txb_DescripcionEstadoBateria.Name = "Txb_DescripcionEstadoBateria"
        Txb_DescripcionEstadoBateria.ReadOnly = True
        Txb_DescripcionEstadoBateria.Size = New Size(234, 129)
        Txb_DescripcionEstadoBateria.TabIndex = 1
        Txb_DescripcionEstadoBateria.Text = "Estado de la Batería:"
        ' 
        ' Btn_Salir
        ' 
        Btn_Salir.AccessibleDescription = ""
        Btn_Salir.AccessibleName = "Salir "
        Btn_Salir.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Btn_Salir.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Salir.ForeColor = Color.White
        Btn_Salir.Location = New Point(143, 2)
        Btn_Salir.Name = "Btn_Salir"
        Btn_Salir.Size = New Size(97, 35)
        Btn_Salir.TabIndex = 4
        Btn_Salir.Text = "Salir"
        Btn_Salir.UseVisualStyleBackColor = False
        ' 
        ' Btn_ActualizarInformacion
        ' 
        Btn_ActualizarInformacion.AccessibleDescription = ""
        Btn_ActualizarInformacion.AccessibleName = "Actualizar información"
        Btn_ActualizarInformacion.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Btn_ActualizarInformacion.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_ActualizarInformacion.Location = New Point(6, 3)
        Btn_ActualizarInformacion.Name = "Btn_ActualizarInformacion"
        Btn_ActualizarInformacion.Size = New Size(130, 35)
        Btn_ActualizarInformacion.TabIndex = 3
        Btn_ActualizarInformacion.Text = "Actualizar"
        Btn_ActualizarInformacion.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlDark
        Panel2.Controls.Add(Btn_ActualizarInformacion)
        Panel2.Controls.Add(Btn_Salir)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 170)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(249, 41)
        Panel2.TabIndex = 5
        ' 
        ' NotifyIcon1
        ' 
        NotifyIcon1.Text = "NotifyIcon1"
        NotifyIcon1.Visible = True
        ' 
        ' Fr_principal
        ' 
        AcceptButton = Btn_ActualizarInformacion
        AccessibleDescription = ""
        AccessibleName = "Ventanta Principal  Batería"
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        CancelButton = Btn_Salir
        ClientSize = New Size(249, 211)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        KeyPreview = True
        MaximizeBox = False
        Name = "Fr_principal"
        Opacity = 0.3R
        StartPosition = FormStartPosition.CenterScreen
        Text = "Carga y Batería"
        TopMost = True
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_Salir As Button
    Friend WithEvents Btn_ActualizarInformacion As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Txb_DescripcionEstadoBateria As TextBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Btn_Ayuda As Button

End Class
