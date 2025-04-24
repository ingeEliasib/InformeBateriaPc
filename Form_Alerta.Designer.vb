<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Alerta
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
        Panel1 = New Panel()
        Btn_Aceptar = New Button()
        Btn_informacion = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Btn_Aceptar)
        Panel1.Controls.Add(Btn_informacion)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(399, 140)
        Panel1.TabIndex = 1
        ' 
        ' Btn_Aceptar
        ' 
        Btn_Aceptar.BackColor = SystemColors.ActiveCaption
        Btn_Aceptar.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Btn_Aceptar.Location = New Point(287, 92)
        Btn_Aceptar.Name = "Btn_Aceptar"
        Btn_Aceptar.Size = New Size(100, 36)
        Btn_Aceptar.TabIndex = 2
        Btn_Aceptar.Text = "Aceptar"
        Btn_Aceptar.UseVisualStyleBackColor = False
        ' 
        ' Btn_informacion
        ' 
        Btn_informacion.AccessibleDescription = "Mensaje muestra la información de la batería"
        Btn_informacion.AccessibleName = "Información de batería"
        Btn_informacion.BackColor = Color.White
        Btn_informacion.BackgroundImageLayout = ImageLayout.None
        Btn_informacion.FlatAppearance.BorderSize = 0
        Btn_informacion.FlatStyle = FlatStyle.Flat
        Btn_informacion.Location = New Point(12, 12)
        Btn_informacion.Name = "Btn_informacion"
        Btn_informacion.Size = New Size(375, 74)
        Btn_informacion.TabIndex = 0
        Btn_informacion.Text = "Informaciòn de la bateria actual"
        Btn_informacion.UseVisualStyleBackColor = False
        ' 
        ' Form_Alerta
        ' 
        AcceptButton = Btn_Aceptar
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(399, 140)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Name = "Form_Alerta"
        Text = "Informaciòn baterìa"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_Aceptar As Button
    Friend WithEvents Btn_informacion As Button
End Class
