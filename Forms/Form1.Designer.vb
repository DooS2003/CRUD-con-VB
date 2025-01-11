<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Text_marca = New System.Windows.Forms.TextBox()
        Me.Text_sabor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Text_codigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button_guardar = New System.Windows.Forms.Button()
        Me.Button_modificar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button_delete = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Text_marca)
        Me.GroupBox1.Controls.Add(Me.Text_sabor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Text_codigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 252)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PRODUCTOS"
        '
        'Text_marca
        '
        Me.Text_marca.Location = New System.Drawing.Point(103, 180)
        Me.Text_marca.Name = "Text_marca"
        Me.Text_marca.Size = New System.Drawing.Size(151, 34)
        Me.Text_marca.TabIndex = 5
        '
        'Text_sabor
        '
        Me.Text_sabor.Location = New System.Drawing.Point(103, 114)
        Me.Text_sabor.Name = "Text_sabor"
        Me.Text_sabor.Size = New System.Drawing.Size(151, 34)
        Me.Text_sabor.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Marca"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sabor"
        '
        'Text_codigo
        '
        Me.Text_codigo.Location = New System.Drawing.Point(103, 45)
        Me.Text_codigo.Name = "Text_codigo"
        Me.Text_codigo.Size = New System.Drawing.Size(151, 34)
        Me.Text_codigo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "codigo"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(298, 26)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(490, 238)
        Me.DataGridView1.TabIndex = 1
        '
        'Button_guardar
        '
        Me.Button_guardar.Location = New System.Drawing.Point(12, 270)
        Me.Button_guardar.Name = "Button_guardar"
        Me.Button_guardar.Size = New System.Drawing.Size(77, 29)
        Me.Button_guardar.TabIndex = 2
        Me.Button_guardar.Text = "Guardar"
        Me.Button_guardar.UseVisualStyleBackColor = True
        '
        'Button_modificar
        '
        Me.Button_modificar.Location = New System.Drawing.Point(95, 270)
        Me.Button_modificar.Name = "Button_modificar"
        Me.Button_modificar.Size = New System.Drawing.Size(77, 29)
        Me.Button_modificar.TabIndex = 3
        Me.Button_modificar.Text = "Modificar"
        Me.Button_modificar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(178, 270)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 29)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Listar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button_delete
        '
        Me.Button_delete.Location = New System.Drawing.Point(261, 270)
        Me.Button_delete.Name = "Button_delete"
        Me.Button_delete.Size = New System.Drawing.Size(77, 29)
        Me.Button_delete.TabIndex = 5
        Me.Button_delete.Text = "Eliminar"
        Me.Button_delete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button_delete)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button_modificar)
        Me.Controls.Add(Me.Button_guardar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Text_codigo As TextBox
    Friend WithEvents Text_marca As TextBox
    Friend WithEvents Text_sabor As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button_guardar As Button
    Friend WithEvents Button_modificar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button_delete As Button
End Class
