﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Txb_EstadoBateria = New TextBox()
        Btn_Aceptar = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Txb_EstadoBateria)
        Panel1.Controls.Add(Btn_Aceptar)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(399, 97)
        Panel1.TabIndex = 1
        ' 
        ' Txb_EstadoBateria
        ' 
        Txb_EstadoBateria.AccessibleDescription = ""
        Txb_EstadoBateria.AccessibleName = ""
        Txb_EstadoBateria.BackColor = Color.White
        Txb_EstadoBateria.BorderStyle = BorderStyle.None
        Txb_EstadoBateria.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txb_EstadoBateria.Location = New Point(12, 12)
        Txb_EstadoBateria.Multiline = True
        Txb_EstadoBateria.Name = "Txb_EstadoBateria"
        Txb_EstadoBateria.ReadOnly = True
        Txb_EstadoBateria.Size = New Size(375, 37)
        Txb_EstadoBateria.TabIndex = 3
        Txb_EstadoBateria.Text = "Estado de la Batería:"
        ' 
        ' Btn_Aceptar
        ' 
        Btn_Aceptar.AccessibleName = "Aceptar"
        Btn_Aceptar.BackColor = SystemColors.ActiveCaption
        Btn_Aceptar.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Btn_Aceptar.Location = New Point(153, 55)
        Btn_Aceptar.Name = "Btn_Aceptar"
        Btn_Aceptar.Size = New Size(100, 36)
        Btn_Aceptar.TabIndex = 2
        Btn_Aceptar.Text = "Aceptar"
        Btn_Aceptar.UseVisualStyleBackColor = False
        ' 
        ' Form_Alerta
        ' 
        AcceptButton = Btn_Aceptar
        AccessibleName = "Alerta Batería"
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(399, 97)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Name = "Form_Alerta"
        Text = "Alerta baterìa"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_Aceptar As Button
    Friend WithEvents Txb_EstadoBateria As TextBox
End Class
